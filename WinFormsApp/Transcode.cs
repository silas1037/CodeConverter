using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;
using System.IO;
using System.Collections.Generic;

namespace WinFormsApp
{
    public static class Transcode
    {
        // TODO: 检查源字节流的编码，解决其不是 GBK 编码的异常情况
        // TODO: 修复文件无法转换为 UTF-8 with BOM 编码的问题
        public static byte[] TranscodeByteStream(string filePath, bool bomFlag, string s1, string s2, string format, bool checkBox_inpack)
        {

            var srcc1 = new UTF8Encoding(true);
            List<string> mnewlis = new List<string>();
            if (checkBox_inpack)
            {
                var suffix = "_meat"; // 指定目标文件名中的后缀，与是否包含 BOM 有关
                var extension = Path.GetExtension(filePath); // 获取原文件的扩展名
                var fileName = Path.GetFileNameWithoutExtension(filePath); // 获取原文件的文件名（不包含扩展名）
                var DirName = Path.GetDirectoryName(filePath); // 获取原文件的文件名（不包含扩展名）
                fileName += suffix; // 向目标文件名中添加后缀
                fileName += extension; // 向目标文件名补齐扩展名
                var convertedFilePath = Path.Combine(DirName, fileName); // 指定转换后的文件在服务中保存的路径

                var bytes1 = FileManager.FileToByteStream(convertedFilePath); // 将文件读取为字节流

                string[] mlist = srcc1.GetString(bytes1).Split(new string[] { "\r\n" }, StringSplitOptions.None);
                
                foreach (var si in mlist)
                {
                    if (Regex.IsMatch(si, "^◆\\d+◆(.*)"))
                    {
                        mnewlis.Add(Regex.Match(si, "^◆\\d+◆(.*)").Groups[1].Value);
                    }
                }
            }


            var bytes = FileManager.FileToByteStream(filePath); // 将文件读取为字节流
            // 产生该字节流的文件不是文本文件
            if (!FileManager.IsTextFile(bytes))
            {
                throw new FormatException("此文件不是文本文件，不可转换。");
            }

            var srcc = Encoding.GetEncoding(932);
            var dstc = Encoding.GetEncoding(936);
            switch (s1)
            {
                case "Shift-Jis":
                    srcc= Encoding.GetEncoding(932);
                    break;
                case "GBK":
                    srcc = Encoding.GetEncoding(936);
                    break;
                case "utf-8":
                    srcc = new UTF8Encoding(true);
                    break;
                case "utf-8 BOM":
                    srcc = new UTF8Encoding(false);
                    break;
                default:
                    srcc = Encoding.GetEncoding(s1);
                    break;
            }
            switch (s2)
            {
                case "Shift-Jis":
                    dstc = Encoding.GetEncoding(932);
                    break;
                case "GBK":
                    dstc = Encoding.GetEncoding(936);
                    break;
                case "utf-8":
                    dstc = new UTF8Encoding(true);
                    break;
                case "utf-8 BOM":
                    dstc = new UTF8Encoding(false);
                    break;
                default:
                    dstc = Encoding.GetEncoding(s2);
                    break;
            }

            // GBK 编码
            //var gbk = Encoding.GetEncoding(936);
            // UTF-8 编码
            //var utf8 = new UTF8Encoding(bomFlag);

            // 将字节流从 GBK 转码为 UTF-8
            var utf8bytes = Encoding.Convert(srcc, dstc, bytes);

            string s = srcc.GetString(bytes);

            if (bomFlag)
            {
                string[] s2list = s.Split(new string[] { "\r\n" }, StringSplitOptions.None);
                List<string> s2newlis = new List<string>();
                int inx = 0;
                foreach(var si in s2list)
                {
                    if(Regex.IsMatch(si, format))
                    {
                        s2newlis.Add("◇" + Convert.ToString(inx).PadLeft(6, '0') + "◇" + Regex.Match(si, format).Groups[2].Value);
                        s2newlis.Add("");
                        s2newlis.Add("◆" + Convert.ToString(inx).PadLeft(6, '0') + "◆" + Regex.Match(si, format).Groups[2].Value);
                        s2newlis.Add("");
                        s2newlis.Add("");
                        s2newlis.Add("");
                        inx += 1;
                    }
                }
                s= string.Join("\r\n", s2newlis);
            }
            else if (checkBox_inpack)
            {

                string[] s2list = s.Split(new string[] { "\r\n" }, StringSplitOptions.None);
                List<string> s2newlis = new List<string>();
                int inx = 0;
                foreach (var si in s2list)
                {
                    if (Regex.IsMatch(si, format))
                    {
                        s2newlis.Add(Regex.Match(si, format).Groups[1].Value+ mnewlis[inx] +
                            Regex.Match(si, format).Groups[3].Value);
                        inx += 1;
                    }
                    else
                    {
                        s2newlis.Add(si);
                    }
                }
                s = string.Join("\r\n", s2newlis);

            }

            //cont = "+" + cont;
            if (s2 == "GBK" && s1!="GBK" )
            {
                s = s.Replace("−", "－");
                s = s.Replace("〜", "～");
                s = s.Replace("ﾟ", "°");
                //s = s.Replace("・", "·");
                s = s.Replace("•", "·");
                s = s.Replace("´", "'");
                s = s.Replace("∋", "");
                s = s.Replace("⊆", "");
                s = s.Replace("⊇", "");
                s = s.Replace("⊂", "");
                s = s.Replace("⊃", "");
                s = s.Replace("⇒", "");
                s = s.Replace("⇔", " ");
                s = s.Replace("∀", "");
                s = s.Replace("∃", "");
                s = s.Replace("∂", "");
                s = s.Replace("∇", "▽");
                s = s.Replace("≪", "《");
                s = s.Replace("≫", "》");
                s = s.Replace("∬", "");
                s = s.Replace("Å", "");
                s = s.Replace("♯", "");
                s = s.Replace("♭", "");
                s = s.Replace("♪", "");
                s = s.Replace("†", "");
                s = s.Replace("‡", "");
                s = s.Replace("¶", "");
                s = s.Replace("◯", "〇");
                s = s.Replace("☓", "×");
                s = s.Replace("ﾞ", "");
                s = s.Replace("｡", "。");
                s = s.Replace("｢", "「");
                s = s.Replace("｣", "」");
                s = s.Replace("､", "、");
                s = s.Replace("･", "·");

                s = s.Replace("ｦ", "を");
                s = s.Replace("ｧ", "ぁ");
                s = s.Replace("ｨ", "ぃ");
                s = s.Replace("ｩ", "ぅ");
                s = s.Replace("ｪ", "ぇ");
                s = s.Replace("ｫ", "ぉ");
                s = s.Replace("ｬ", "ゃ");
                s = s.Replace("ｭ", "ゅ");
                s = s.Replace("ｮ", "ょ");
                s = s.Replace("ｯ", "っ");
                s = s.Replace("ｰ", "ー");
                s = s.Replace("ｱ", "あ");
                s = s.Replace("ｲ", "い");
                s = s.Replace("ｳ", "う");
                s = s.Replace("ｴ", "え");
                s = s.Replace("ｵ", "お");
                s = s.Replace("ｶ", "か");
                s = s.Replace("ｷ", "き");
                s = s.Replace("ｸ", "く");
                s = s.Replace("ｹ", "け");
                s = s.Replace("ｺ", "こ");
                s = s.Replace("ｻ", "さ");
                s = s.Replace("ｼ", "し");
                s = s.Replace("ｽ", "す");
                s = s.Replace("ｾ", "せ");
                s = s.Replace("ｿ", "そ");
                s = s.Replace("ﾀ", "た");
                s = s.Replace("ﾁ", "ち");
                s = s.Replace("ﾂ", "つ");
                s = s.Replace("ﾃ", "て");
                s = s.Replace("ﾄ", "と");
                s = s.Replace("ﾅ", "な");
                s = s.Replace("ﾆ", "に");
                s = s.Replace("ﾇ", "ぬ");
                s = s.Replace("ﾈ", "ね");
                s = s.Replace("ﾉ", "の");
                s = s.Replace("ﾊ", "は");
                s = s.Replace("ﾋ", "ひ");
                s = s.Replace("ﾌ", "ふ");
                s = s.Replace("ﾍ", "へ");
                s = s.Replace("ﾎ", "ほ");
                s = s.Replace("ﾏ", "ま");
                s = s.Replace("ﾐ", "み");
                s = s.Replace("ﾑ", "む");
                s = s.Replace("ﾒ", "め");
                s = s.Replace("ﾓ", "も");
                s = s.Replace("ﾔ", "や");
                s = s.Replace("ﾕ", "ゆ");
                s = s.Replace("ﾖ", "よ");
                s = s.Replace("ﾗ", "ら");
                s = s.Replace("ﾘ", "り");
                s = s.Replace("ﾙ", "る");
                s = s.Replace("ﾚ", "れ");
                s = s.Replace("ﾛ", "ろ");
                s = s.Replace("ﾜ", "わ");
                s = s.Replace("ﾝ", "ん");


            }

            byte[] decBytes = dstc.GetBytes(s);

            return decBytes;
        }
    }
}

//# "ｦ": "ヲ",
//# "ｧ": "ァ",
//# "ｨ": "ィ",
//# "ｩ": "ゥ",
//# "ｪ": "ェ",
//# "ｫ": "ォ",
//# "ｬ": "ャ",
//# "ｭ": "ュ",
//# "ｮ": "ョ",
//# "ｯ": "ッ",
//# "ｰ": "ー",
//# "ｱ": "ア",
//# "ｲ": "イ",
//# "ｳ": "ウ",
//# "ｴ": "エ",
//# "ｵ": "オ",
//# "ｶ": "カ",
//# "ｷ": "キ",
//# "ｸ": "ク",
//# "ｹ": "ケ",
//# "ｺ": "コ",
//# "ｻ": "サ",
//# "ｼ": "シ",
//# "ｽ": "ス",
//# "ｾ": "セ",
//# "ｿ": "ソ",
//# "ﾀ": "タ",
//# "ﾁ": "チ",
//# "ﾂ": "ツ",
//# "ﾃ": "テ",
//# "ﾄ": "ト",
//# "ﾅ": "ナ",
//# "ﾆ": "ニ",
//# "ﾇ": "ヌ",
//# "ﾈ": "ネ",
//# "ﾉ": "ノ",
//# "ﾊ": "ハ",
//# "ﾋ": "ヒ",
//# "ﾌ": "フ",
//# "ﾍ": "ヘ",
//# "ﾎ": "ホ",
//# "ﾏ": "マ",
//# "ﾐ": "ミ",
//# "ﾑ": "ム",
//# "ﾒ": "メ",
//# "ﾓ": "モ",
//# "ﾔ": "ヤ",
//# "ﾕ": "ユ",
//# "ﾖ": "ヨ",
//# "ﾗ": "ラ",
//# "ﾘ": "リ",
//# "ﾙ": "ル",
//# "ﾚ": "レ",
//# "ﾛ": "ロ",
//# "ﾜ": "ワ",
//# "ﾝ": "ン",
