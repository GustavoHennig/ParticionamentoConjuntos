/* 
* por: Gustavo Augusto Hennig
* novembro de 2007
*/

/*
 * Criado por SharpDevelop.
 * Usuário: m31692
 * Data: 1/11/2007
 * Hora: 23:05
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */

using System;
using System.Windows.Forms;

namespace PartCnj
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
        {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
		
	}
}
