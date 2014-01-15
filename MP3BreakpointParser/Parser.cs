using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace MP3BreakpointParser
{
	/// <summary>
	/// Author：xxh 
	/// CreateTime：2014-01-15 20:56:42 
	/// </summary>
	public class Parser
	{
		#region 变量
		string filePath;//文件路径
		int fileLength;//读取为二进制文件长度
		#endregion

		#region 属性

		#endregion

		#region 委托事件

		#endregion

		#region 构造函数
		public Parser(string path)
		{
			filePath = path;
		}
		#endregion

		#region 业务
		public void ParseMP3()
		{
			////为文件打开一个二进制写入器  
			//FileStream fs;
			////循环读取并输出数据  
			//fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
			//BinaryReader br = new BinaryReader(fs);
			//fileLength = Convert.ToInt32(br.BaseStream.Length);
			//byte[] mp3Bytes = br.ReadBytes(fileLength);

			////ZPlay.zplay_GetWaveOutInfoW();
			//ZPlay player = new ZPlay();
			//player.OpenFile(filePath, TStreamFormat.sfMp3);
			//TStreamInfo StreamInfo = new TStreamInfo();
			//player.GetStreamInfo(ref StreamInfo);
			//double length = System.Convert.ToInt32((int)(StreamInfo.Length.sec));
			//int ii = player.GetFFTGraphParam(TFFTGraphParamID.gpColor1);


			//TWaveOutInfo WaveOutInfo = new TWaveOutInfo();
			//int WaveOutNum = player.EnumerateWaveOut();
			//uint i;
			//for (i = 0; i < WaveOutNum; i++)
			//{
			//    if (player.GetWaveOutInfo(i, ref WaveOutInfo))
			//    {
			//        Console.WriteLine(WaveOutInfo.ProductName);
			//    }
			//}

			//int paizi = player.GetTempo();


			//int[] testeq = new int[1];
			//int num = player.GetEqualizerPoints(ref testeq);
			//for (int iii = 0; iii < num; iii++)
			//{
			//    Console.WriteLine(testeq[i].ToString());
			//}

			//TStreamInfo_Internal
			//ZPlay.zplay_GetStreamInfoW();
			//br.BaseStream.Seek(0, SeekOrigin.Begin); //将文件指针设置到文件开始
			//while (br.BaseStream.Position < br.BaseStream.Length) // 当未到达文件结尾时
			//{
			//    byte[] readBuffer = br.ReadBytes(128);
			//    listByteReader.Add(readBuffer);
			//}

			//fs.Close();
			//br.Close();
		}
		#endregion
	}
}
