using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class TrionicArray
    {
        public static bool IsTrionic(int[] nums)
        {
            if (nums.Length < 4) return false;

            int Tamanho = nums.Length;
            int PosicaoUltimoElemento = nums.Length - 1;

            int estagio = 1;

            for(int i = 0; i < Tamanho; i++)
            {
                if (i == PosicaoUltimoElemento && estagio != 4) return false;
                if (i == PosicaoUltimoElemento) return true;

                bool EstaSubindo = Subindo(nums[i], nums[i + 1]);

                switch (estagio)
                {
                    case 1:
                        if (EstaSubindo)
                        {
                            estagio = 2;
                        }
                        else
                        {
                            return false;
                        }

                        break;

                    case 2: // Fica Aqui até começar a descer

                        if (!EstaSubindo)
                        {
                            estagio = 3;
                        }

                        break;
                    case 3: // Fica aqui até começar a subir
                        if (EstaSubindo)
                        {
                            estagio = 4;
                        }

                        break;
                    case 4: // Não pode descer

                        if(i == PosicaoUltimoElemento)
                        {
                            return true;
                        }

                        if(i + 1 <= PosicaoUltimoElemento)
                        {
                            if(nums[i] > nums[i + 1])
                            {
                                return false;
                            }
                        }

                        break;
                }

                if (nums[i] == nums[i + 1]) break;
            }

            return false;
        }

        private static bool Subindo(int ValorAtual, int ProximoValor)
        {
            return ValorAtual < ProximoValor;
        }
    }
}