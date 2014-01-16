using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Controls;


namespace MP3BreakpointParser
{
	/// <summary>
	/// 作者：xxh 
	/// 时间：2014-01-16 14:12:57
	/// 版本：V1.0.0 	 
	/// </summary>
	public partial class UCPlaySpectrum : UserControl
	{
		System.Windows.Forms.Panel panelMain;

		#region 属性
		public IntPtr Handle 
		{ 
			get
			{
				return panelMain.Handle;
			} 
		}
		#endregion

		#region 构造函数
		public UCPlaySpectrum()
		{
			InitializeComponent();
			panelMain = new System.Windows.Forms.Panel();
			//panelMain.BackColor = System.Drawing.Color.White;
			panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			formHostRoot.Child = panelMain;
		}
		#endregion
	}
}
