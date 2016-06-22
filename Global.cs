/* 
* por: Gustavo Augusto Hennig
* novembro de 2007
*/
/*
 * Criado por SharpDevelop.
 * Usuário: m31692
 * Data: 8/11/2007
 * Hora: 23:11
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */

using System;

namespace PartCnj
{
	/// <summary>
	/// Description of Global.
	/// </summary>
	public class Global
	{
		public static int TamanhoGrade = 10;
		public static int NroItens;
		public static int MaxGrupos = 6;
		public static int MinGrupos = 2;
		public static int TamPopulacao = 50;
		public static int NroIteracoes = 100;
        public static Matriz Matriz = new Matriz();
        public static Random Random = new Random();
        public static long TempoUltimoMelhorResult = 60000000;

		
	}
}
