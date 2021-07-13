using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Aspose.Words;
using Aspose.Words.Tables;
using System.Drawing;

namespace GGZY.Core.Helper
{
    public class AsposeWord
    {
        /// <summary>
        /// word文档
        /// </summary>
        public Document doc;
        /// <summary>
        /// word文档内容对象
        /// </summary>
        public DocumentBuilder builder;

        public AsposeWord()
        {
            doc = new Document();
            builder = new DocumentBuilder(doc);
        }

        public AsposeWord(string strFileName)
        {
            if (!string.IsNullOrEmpty(strFileName))
            {
                doc = new Document(strFileName);
                builder = new DocumentBuilder(doc);
            }
            else
            {
                doc = new Document();
                builder = new DocumentBuilder(doc);
            }
        }

        /// <summary>
        /// 保存文件
        /// </summary>
        /// <param name="strFileName">保存的文件路径（包括文件名）</param>
        /// <param name="saveFormat">文件格式（doc,docx）</param>
        public void SaveAs(string strFileName, string saveFormat)
        {
            switch (saveFormat)
            {
                case "doc":
                    doc.Save(strFileName, SaveFormat.Doc);
                    break;
                case "docx":
                    doc.Save(strFileName, SaveFormat.Docx);
                    break;
                case "pdf":
                    doc.Save(strFileName, SaveFormat.Pdf);
                    break;
            }
        }

        /// <summary>
        /// 保存文件到网页
        /// </summary>
        /// <param name="FileName">保存的文件名</param>
        /// <param name="saveFormat">文件格式（doc,docx）</param>
        public void WriteToWeb(string FileName, string saveFormat)
        {
            if (FileName.Trim() == "")
            {
                FileName = DateTime.Now.ToString("yyyyMMddHHmmssfff");
            }
            System.IO.MemoryStream ms = new System.IO.MemoryStream();//创建缓存
            switch (saveFormat)//保存文档到缓存中
            {
                case "doc":
                    doc.Save(ms, SaveFormat.Doc);
                    break;
                case "docx":
                    doc.Save(ms, SaveFormat.Docx);
                    break;

            }
            HttpContext.Current.Response.Clear();
            HttpContext.Current.Response.Buffer = true;
            HttpContext.Current.Response.ContentType = "application/vnd.ms-word";
            HttpContext.Current.Response.AddHeader("Content-Disposition", string.Format("attachment; filename={0}." + saveFormat, System.Web.HttpUtility.UrlEncode(FileName)));
            HttpContext.Current.Response.BinaryWrite(ms.ToArray());
            ms.Close();
            ms.Dispose();
            HttpContext.Current.ApplicationInstance.CompleteRequest();
        }

        
#pragma warning disable CS1571 // XML 注释中对“strText”有重复的 param 标记
/// <summary>
        /// 添加内容(写完换行)
        /// </summary>
        /// <param name="strText">内容</param>
        /// <param name="conSize">字体大小</param>
        /// <param name="fontName">字体</param>
        /// <param name="conBold">是否变粗</param>
        /// <param name="strText">对齐（left，center，right）</param>
#pragma warning disable CS1573 // 参数“conAlign”在“AsposeWord.WriteLineText(string, double, string, bool, string)”的 XML 注释中没有匹配的 param 标记(但其他参数有)
        public void WriteLineText(string strText, double conSize, string fontName, bool conBold, string conAlign)
#pragma warning restore CS1573 // 参数“conAlign”在“AsposeWord.WriteLineText(string, double, string, bool, string)”的 XML 注释中没有匹配的 param 标记(但其他参数有)
#pragma warning restore CS1571 // XML 注释中对“strText”有重复的 param 标记
        {
            builder.Bold = conBold;
            builder.Font.Size = conSize;
            if (!string.IsNullOrEmpty(fontName))
                builder.Font.Name = fontName;
            builder.ParagraphFormat.Alignment = this.GetAlignment(conAlign);
            builder.Writeln(strText);

        }

        
#pragma warning disable CS1571 // XML 注释中对“strText”有重复的 param 标记
/// <summary>
        /// 添加内容
        /// </summary>
        /// <param name="strText">内容</param>
        /// <param name="conSize">字体大小</param>
        /// <param name="fontName">字体</param>
        /// <param name="conBold">是否变粗</param>
        /// <param name="strText">对齐（left，center，right）</param>
#pragma warning disable CS1573 // 参数“conAlign”在“AsposeWord.WriteText(string, double, string, bool, string)”的 XML 注释中没有匹配的 param 标记(但其他参数有)
        public void WriteText(string strText, double conSize, string fontName, bool conBold, string conAlign)
#pragma warning restore CS1571 // XML 注释中对“strText”有重复的 param 标记
#pragma warning restore CS1573 // 参数“conAlign”在“AsposeWord.WriteText(string, double, string, bool, string)”的 XML 注释中没有匹配的 param 标记(但其他参数有)
        {
            builder.Bold = conBold;
            builder.Font.Size = conSize;
            if (!string.IsNullOrEmpty(fontName))
                builder.Font.Name = fontName;
            builder.ParagraphFormat.Alignment = this.GetAlignment(conAlign);
            builder.Write(strText);

        }

        
#pragma warning disable CS1571 // XML 注释中对“strText”有重复的 param 标记
/// <summary>
        /// 添加段落
        /// </summary>
        /// <param name="strText">内容</param>
        /// <param name="conSize">字体大小</param>
        /// <param name="fontName">字体</param>
        /// <param name="conBold">是否变粗</param>
        /// <param name="strText">对齐（left，center，right）</param>
#pragma warning disable CS1573 // 参数“conAlign”在“AsposeWord.AddParagraph(string, double, string, bool, string)”的 XML 注释中没有匹配的 param 标记(但其他参数有)
        public Paragraph AddParagraph(string strText, double conSize, string fontName, bool conBold, string conAlign)
#pragma warning restore CS1571 // XML 注释中对“strText”有重复的 param 标记
#pragma warning restore CS1573 // 参数“conAlign”在“AsposeWord.AddParagraph(string, double, string, bool, string)”的 XML 注释中没有匹配的 param 标记(但其他参数有)
        {
            Paragraph myParagraph = builder.InsertParagraph();
            myParagraph.ParagraphFormat.Alignment = this.GetAlignment(conAlign);
            Run myRun = new Run(myParagraph.Document);
            myRun.Font.Size = conSize;
            if (!string.IsNullOrEmpty(fontName))
                myRun.Font.Name = fontName;
            myRun.Font.Bold = conBold;
            myRun.Text = strText;
            myParagraph.Runs.Add(myRun);
            return myParagraph;
        }

        public Paragraph InsertCellText(Cell cell, string strText, double conSize, string fontName, bool conBold)
        {
            strText = strText.Replace("\n", "");
            strText = strText.Replace('\r', (char)11);
            Paragraph myParagraph = cell.Paragraphs[0];
            Run myRun = new Run(cell.Document);
            myRun.Font.Size = conSize;
            myRun.Font.Name = fontName;
            myRun.Font.Bold = conBold;
            myRun.Text = strText;
            myParagraph.Runs.Add(myRun);
            return myParagraph;
        }


        public void SetColumnWidth(Table table, int colNum, double width)
        {
            foreach (Row row in table.Rows)
            {
                row.Cells[colNum].CellFormat.PreferredWidth = PreferredWidth.FromPoints(width);
                row.Cells[colNum].CellFormat.Width = width;
            }
        }

        /// <summary>
        /// 设置纸张
        /// </summary>
        /// <param name="papersize">A4，A4H（A4横向），A3，A3H（A3横向），16K，8KH</param>
        public void setPaperSize(string papersize)
        {

            switch (papersize)
            {
                case "A4":
                    foreach (Aspose.Words.Section section in doc)
                    {
                        section.PageSetup.PaperSize = PaperSize.A4;
                        section.PageSetup.Orientation = Orientation.Portrait;
                        section.PageSetup.VerticalAlignment = Aspose.Words.PageVerticalAlignment.Top;
                    }
                    break;
                case "A4H"://A4横向
                    foreach (Aspose.Words.Section section in doc)
                    {
                        section.PageSetup.PaperSize = PaperSize.A4;
                        section.PageSetup.Orientation = Orientation.Landscape;
                        //section.PageSetup.TextColumns.SetCount(2);
                        //section.PageSetup.TextColumns.EvenlySpaced = true;
                        //section.PageSetup.TextColumns.LineBetween = false;
                    }
                    break;
                case "A3":
                    foreach (Aspose.Words.Section section in doc)
                    {
                        section.PageSetup.PaperSize = PaperSize.A3;
                        section.PageSetup.Orientation = Orientation.Portrait;
                    }

                    break;
                case "A3H"://A3横向
                    foreach (Aspose.Words.Section section in doc)
                    {
                        section.PageSetup.PaperSize = PaperSize.A3;
                        section.PageSetup.Orientation = Orientation.Landscape;
                        //section.PageSetup.TextColumns.SetCount(2);
                        section.PageSetup.TextColumns.EvenlySpaced = true;
                        //section.PageSetup.TextColumns.LineBetween = false;
                    }
                    break;
                case "16K":
                    foreach (Aspose.Words.Section section in doc)
                    {
                        section.PageSetup.PaperSize = PaperSize.B5;
                        section.PageSetup.Orientation = Orientation.Portrait;
                    }
                    break;
                case "8KH":
                    foreach (Aspose.Words.Section section in doc)
                    {
                        section.PageSetup.PageWidth = double.Parse("36.4 ");//纸张宽度
                        section.PageSetup.PageHeight = double.Parse("25.7");//纸张高度
                        section.PageSetup.Orientation = Orientation.Landscape;
                        //section.PageSetup.TextColumns.SetCount(2);
                        //section.PageSetup.TextColumns.EvenlySpaced = true;
                        //section.PageSetup.TextColumns.LineBetween = false;
                        //section.PageSetup.LeftMargin = double.Parse("3.35");
                        //section.PageSetup.RightMargin = double.Parse("0.99");
                    }
                    break;
            }
        }

        /// <summary>
        /// 换行
        /// </summary>
        public void InsertLineBreak()
        {
            builder.InsertBreak(BreakType.LineBreak);
        }

        /// <summary>
        /// 换多行
        /// </summary>
        /// <param name="nline"></param>
        public void InsertLineBreak(int nline)
        {
            for (int i = 0; i < nline; i++)
                builder.InsertBreak(BreakType.LineBreak);
        }

        /// <summary>
        /// 获取所有第一级表格
        /// </summary>
        /// <returns></returns>
        public List<Table> GetTables()
        {
            List<Table> tables = new List<Table>();
            foreach (Section setion in doc.Sections)
            {
                tables.AddRange(setion.Body.Tables.ToArray());
            }
            return tables;
        }

        /// <summary>
        /// 获取相同字符串的第一个单元格
        /// </summary>
        public Cell GetFirstCellByText(string text)
        {
            List<Table> list = GetTables();
            foreach (Table tb in list)
            {
                foreach (Row row in tb.Rows)
                {
                    foreach (Cell cell in row.Cells)
                    {
                        if (cell.Range.Text.TrimEnd('\a').IndexOf(text) >= 0)
                            return cell;
                    }
                }
            }
            return null;
        }

        /// <summary>
        /// 获取表格行的索引
        /// </summary>
        public int GetRowIndex(Row row)
        {
            if (row == null) return -1;
            return row.ParentTable.IndexOf(row);
        }

        /// <summary>
        /// 获取单元格在行中的索引
        /// </summary>
        public int GetCellIndex(Cell cell)
        {
            if (cell == null) return -1;
            return cell.ParentRow.IndexOf(cell);
        }

        /// <summary>
        /// 获取单元格跨几行(包括本行)
        /// </summary>
        public int GetRowSpan(Cell cell)
        {
            if (cell == null) return -1;
            int rowSpan = 1;
            if (cell.CellFormat.VerticalMerge != CellMerge.First) return rowSpan;
            int rowIndex = GetRowIndex(cell.ParentRow);
            int cellIndex = GetCellIndex(cell);
            Table tb = cell.ParentRow.ParentTable;
            for (rowIndex += 1; rowIndex < tb.Rows.Count; rowIndex++)
            {
                if (tb.Rows[rowIndex].Cells[cellIndex].CellFormat.VerticalMerge == CellMerge.Previous)
                    rowSpan++;
                else
                    return rowSpan;
            }
            return rowSpan;
        }

        /// <summary>
        /// 复制表格的行到新表格中
        /// </summary>
        public Table CopyRowToTable(Table tb, int rowIndex, int rowNum)
        {
            if (rowNum == 0) return null;
            Table tbTemp = new Table(doc);

            for (; rowIndex < tb.Rows.Count; rowIndex++)
            {
                if (rowNum > 0)
                {
                    tbTemp.Rows.Add(tb.Rows[rowIndex].Clone(true));
                    rowNum--;
                }
                else
                    return tbTemp;
            }
            return tbTemp;
        }

        /// <summary>
        /// 移除表格中的行
        /// </summary>
        public void RemoveRows(Table tb, int rowIndex, int rowNum)
        {
            if (rowNum == 0) return;
            for (; rowIndex < tb.Rows.Count; rowIndex++)
            {
                if (rowNum > 0)
                {
                    tb.Rows[rowIndex].Remove();
                    rowIndex--;
                    rowNum--;
                }
            }
        }

        
#pragma warning disable CS1571 // XML 注释中对“align”有重复的 param 标记
#pragma warning disable CS1571 // XML 注释中对“align”有重复的 param 标记
/// <summary>
        /// 插入表格
        /// </summary>
        /// <param name="rowNum">行数</param>
        /// <param name="colNum">列数</param>
        /// <param name="cellWidth">单元格默认宽</param>
        /// <param name="cellHeight">单元格默认高</param>
        /// <param name="align">表格水平对齐方式(left,center,right)</param>
        /// <param name="align">单元格水平对齐方式(left,center,right)</param>
        /// <param name="align">单元格垂直对齐方式(bottom,center,top)</param>
        /// <param name="haveBorder">单元格是否拥有边框</param>
        /// <returns></returns>
#pragma warning disable CS1573 // 参数“valign”在“AsposeWord.InsertTable(int, int, double, double, string, string, string, bool)”的 XML 注释中没有匹配的 param 标记(但其他参数有)
#pragma warning disable CS1573 // 参数“tableAlign”在“AsposeWord.InsertTable(int, int, double, double, string, string, string, bool)”的 XML 注释中没有匹配的 param 标记(但其他参数有)
        public Table InsertTable(int rowNum, int colNum, double cellWidth, double cellHeight, string tableAlign, string align, string valign, bool haveBorder)
#pragma warning restore CS1571 // XML 注释中对“align”有重复的 param 标记
#pragma warning restore CS1573 // 参数“tableAlign”在“AsposeWord.InsertTable(int, int, double, double, string, string, string, bool)”的 XML 注释中没有匹配的 param 标记(但其他参数有)
#pragma warning restore CS1573 // 参数“valign”在“AsposeWord.InsertTable(int, int, double, double, string, string, string, bool)”的 XML 注释中没有匹配的 param 标记(但其他参数有)
#pragma warning restore CS1571 // XML 注释中对“align”有重复的 param 标记
        {
            Table table = builder.StartTable();//开始画Table
            ParagraphAlignment paragraphAlignmentValue = builder.ParagraphFormat.Alignment;//获取默认对齐方式

            ParagraphAlignment cellAlign = this.GetAlignment(align);
            CellVerticalAlignment cellValign = this.GetVAlignment(valign);
            builder.ParagraphFormat.Alignment = this.GetAlignment(tableAlign);

            //添加Word表格
            for (int row = 0; row < rowNum; row++)
            {
                builder.RowFormat.Height = cellHeight;
                for (int col = 0; col < colNum; col++)
                {
                    builder.InsertCell();
                    builder.CellFormat.VerticalAlignment = cellValign;//垂直居中对齐
                    builder.ParagraphFormat.Alignment = cellAlign;//水平居中对齐
                    builder.CellFormat.Width = cellWidth;
                    builder.CellFormat.PreferredWidth = Aspose.Words.Tables.PreferredWidth.FromPoints(cellWidth);
                    if (haveBorder == true)
                    {
                        //设置外框样式   
                        builder.CellFormat.Borders.LineStyle = LineStyle.Single;
                        //样式设置结束   
                    }
                }
                builder.EndRow();
            }
            builder.EndTable();
            builder.ParagraphFormat.Alignment = paragraphAlignmentValue;
            table.Alignment = Aspose.Words.Tables.TableAlignment.Center;
            table.PreferredWidth = Aspose.Words.Tables.PreferredWidth.Auto;
            return table;
        }

        
#pragma warning disable CS1572 // XML 注释中有“cor”的 param 标记，但是没有该名称的参数
/// <summary>
        /// 表格单元格合并
        /// </summary>
        /// <param name="table">所要合并的表格</param>
        /// <param name="row">单元格所在行(以0开始)</param>
        /// <param name="cor">单元格所在列(以0开始)</param>
        /// <param name="rowNum">垂直合并行数</param>
        /// <param name="colNum">水平合并列数</param>
        /// <returns></returns>
#pragma warning disable CS1573 // 参数“col”在“AsposeWord.TableCellMerge(Table, int, int, int, int)”的 XML 注释中没有匹配的 param 标记(但其他参数有)
        public bool TableCellMerge(Table table, int row, int col, int rowNum, int colNum)
#pragma warning restore CS1572 // XML 注释中有“cor”的 param 标记，但是没有该名称的参数
#pragma warning restore CS1573 // 参数“col”在“AsposeWord.TableCellMerge(Table, int, int, int, int)”的 XML 注释中没有匹配的 param 标记(但其他参数有)
        {
            if (rowNum == 0 && colNum == 0)
                return true;
            for (int rowIndex = 0; rowIndex < table.Rows.Count; rowIndex++)
            {
                Row rowTemp = table.Rows[rowIndex];
                for (int colIndex = 0; colIndex < rowTemp.Cells.Count; colIndex++)
                {
                    Cell cellTemp = rowTemp.Cells[colIndex];
                    if (rowIndex == row && colIndex == col)
                    {
                        if (rowNum > 0)
                            cellTemp.CellFormat.VerticalMerge = CellMerge.First;
                        if (colNum > 0)
                            cellTemp.CellFormat.HorizontalMerge = CellMerge.First;
                    }
                    else
                    {
                        if (rowIndex >= row && rowIndex <= (row + rowNum) && colIndex >= col && colIndex <= (col + colNum))
                        {
                            if (rowNum > 0)
                                cellTemp.CellFormat.VerticalMerge = CellMerge.Previous;
                            if (colNum > 0)
                                cellTemp.CellFormat.HorizontalMerge = CellMerge.Previous;
                        }
                    }
                }
            }
            return true;
        }

        public bool InsertTable(System.Data.DataTable dt, bool haveBorder)
        {
            Aspose.Words.Tables.Table table = builder.StartTable();//开始画Table
            ParagraphAlignment paragraphAlignmentValue = builder.ParagraphFormat.Alignment;
            builder.ParagraphFormat.Alignment = ParagraphAlignment.Center;
            //添加Word表格
            for (int row = 0; row < dt.Rows.Count; row++)
            {
                builder.RowFormat.Height = 25;
                for (int col = 0; col < dt.Columns.Count; col++)
                {
                    builder.InsertCell();
                    builder.Font.Size = 10.5;
                    builder.Font.Name = "宋体";
                    builder.CellFormat.VerticalAlignment = Aspose.Words.Tables.CellVerticalAlignment.Center;//垂直居中对齐
                    builder.ParagraphFormat.Alignment = ParagraphAlignment.Center;//水平居中对齐
                    builder.CellFormat.Width = 50.0;
                    builder.CellFormat.PreferredWidth = Aspose.Words.Tables.PreferredWidth.FromPoints(50);
                    if (haveBorder == true)
                    {
                        //设置外框样式   
                        builder.CellFormat.Borders.LineStyle = LineStyle.Single;
                        //样式设置结束   
                    }

                    builder.Write(dt.Rows[row][col].ToString());
                }

                builder.EndRow();

            }
            builder.EndTable();
            builder.ParagraphFormat.Alignment = paragraphAlignmentValue;
            table.Alignment = Aspose.Words.Tables.TableAlignment.Center;
            table.PreferredWidth = Aspose.Words.Tables.PreferredWidth.Auto;

            return true;
        }

        /// <summary>
        /// 分页
        /// </summary>
        public void InsertPagebreak()
        {
            builder.InsertBreak(BreakType.PageBreak);
        }

        public void InsertBookMark(string BookMark)
        {
            builder.StartBookmark(BookMark);
            builder.EndBookmark(BookMark);

        }

        public void GotoBookMark(string strBookMarkName)
        {
            builder.MoveToBookmark(strBookMarkName);
        }

        public void ClearBookMark()
        {
            doc.Range.Bookmarks.Clear();
        }

        /// <summary>
        /// 替换文本
        /// </summary>
        public void ReplaceText(string oleText, string newText)
        {
            System.Text.RegularExpressions.Regex reg = new System.Text.RegularExpressions.Regex(oleText);
            int r = doc.Range.Replace(reg, new ReplaceText(newText), false);
        }

        /// <summary>
        /// 指定Range内替换文本
        /// </summary>
        public void ReplaceText(Range range, string oleText, string newText)
        {
            System.Text.RegularExpressions.Regex reg = new System.Text.RegularExpressions.Regex(oleText);
            range.Replace(reg, new ReplaceText(newText), false);
        }

        /// <summary>
        /// 文本替换成html
        /// </summary>
        public void ReplaceHtml(string oleText, string html)
        {
            System.Text.RegularExpressions.Regex reg = new System.Text.RegularExpressions.Regex(oleText);
            doc.Range.Replace(reg, new ReplaceHtml(html), false);
        }

        /// <summary>
        ///指定Range内关键字替换成图片
        /// </summary>
        public void ReplaceAndInsertImage(Range range, string key, string imgUrl)
        {
            System.Text.RegularExpressions.Regex reg = new System.Text.RegularExpressions.Regex(key);
            range.Replace(reg, new ReplaceAndInsertImage(imgUrl), false);
        }

        /// <summary>
        ///关键字替换成图片
        /// </summary>
        public void ReplaceAndInsertImage(string key, string imgUrl)
        {
            System.Text.RegularExpressions.Regex reg = new System.Text.RegularExpressions.Regex(key);
            doc.Range.Replace(reg, new ReplaceAndInsertImage(imgUrl), false);
        }

        /// <summary>
        ///关键字替换成图片
        /// </summary>
        public void ReplaceAndInsertImage(string key, Image img)
        {
            System.Text.RegularExpressions.Regex reg = new System.Text.RegularExpressions.Regex(key);
            doc.Range.Replace(reg, new ReplaceAndInsertImage(img), false);
        }

        /// <summary>
        ///关键字替换成图片
        /// </summary>
        public void ReplaceAndInsertImage(string key, List<Dictionary<string, object>> imgUrl)
        {
            System.Text.RegularExpressions.Regex reg = new System.Text.RegularExpressions.Regex(key);
            doc.Range.Replace(reg, new ReplaceAndInsertImageList(imgUrl), false);
        }

        /// <summary>
        ///关键字替换成图片
        /// </summary>
        public void ReplaceAndInsertImageList(string key, List<Dictionary<string, object>> imgUrl)
        {
            System.Text.RegularExpressions.Regex reg = new System.Text.RegularExpressions.Regex(key);
            doc.Range.Replace(reg, new ReplaceAndInsertImgList(imgUrl), false);
        }

        private ParagraphAlignment GetAlignment(string align)
        {
            switch (align)
            {
                case "left":
                    return ParagraphAlignment.Left;
                case "center":
                    return ParagraphAlignment.Center;
                case "right":
                    return ParagraphAlignment.Right;
                default:
                    return ParagraphAlignment.Left;
            }
        }

        private CellVerticalAlignment GetVAlignment(string valign)
        {
            switch (valign)
            {
                case "top":
                    return CellVerticalAlignment.Top;
                case "center":
                    return CellVerticalAlignment.Center;
                case "bottom":
                    return CellVerticalAlignment.Bottom;
                default:
                    return CellVerticalAlignment.Top;
            }
        }
    }

    /// <summary>
    /// 文本替换类（用来处理"换行符"）
    /// </summary>
    public class ReplaceText : IReplacingCallback
    {
        /// <summary>
        /// 需要替换的文本
        /// </summary>
        public string text { get; set; }

        public ReplaceText(string text)
        {
            this.text = text??string.Empty;
        }

        public ReplaceAction Replacing(ReplacingArgs e)
        {
            e.Replacement = text;
            return ReplaceAction.Replace;
        }
    }

    /// <summary>
    /// 替换插入HTML
    /// </summary>
    public class ReplaceHtml : IReplacingCallback
    {
        /// <summary>
        /// 需要替换的文本
        /// </summary>
        public string htmlStr { get; set; }

        public ReplaceHtml(string html)
        {
            this.htmlStr = html;
        }

        public ReplaceAction Replacing(ReplacingArgs e)
        {
            //获取当前节点
            var node = e.MatchNode;
            //获取当前文档
            Document doc = node.Document as Document;
            DocumentBuilder builder = new DocumentBuilder(doc);
            //将光标移动到指定节点
            builder.MoveTo(node);
            builder.InsertHtml(htmlStr);
            return ReplaceAction.Replace;
        }
    }

    /// <summary>
    /// 替换插入图片
    /// </summary>
    public class ReplaceAndInsertImage : IReplacingCallback
    {
        /// <summary>
        /// 需要插入的图片路径
        /// </summary>
        public string url { get; set; }
        public Image img { get; set; }

        bool isImg = false;

        public ReplaceAndInsertImage(string url)
        {
            isImg = false;
            this.url = url;
        }

        public ReplaceAndInsertImage(Image img)
        {
            isImg = true;
            this.img = img;
        }

        public ReplaceAction Replacing(ReplacingArgs e)
        {
            //获取当前节点
            var node = e.MatchNode;
            //获取当前文档
            Document doc = node.Document as Document;
            DocumentBuilder builder = new DocumentBuilder(doc);
            //将光标移动到指定节点
            builder.MoveTo(node);
            //插入图片
            if (isImg)
                builder.InsertImage(img);
            else
                builder.InsertImage(url);
            return ReplaceAction.Replace;
        }
    }

    public class ReplaceAndInsertImageList : IReplacingCallback
    {
        /// <summary>
        /// 需要插入的图片路径
        /// </summary>
        public List<Dictionary<string, object>> url { get; set; }


        public ReplaceAndInsertImageList(List<Dictionary<string, object>> urlList)
        {
            this.url = urlList;
        }

        public ReplaceAction Replacing(ReplacingArgs e)
        {
            //获取当前节点
            var node = e.MatchNode;
            //获取当前文档
            Document doc = node.Document as Document;
            DocumentBuilder builder = new DocumentBuilder(doc);
            //将光标移动到指定节点
            builder.MoveTo(node);
            //插入图片
            foreach (Dictionary<string, object> d in url)
            {
                string u = d["url"].ToString();
                string name = d["name"].ToString();
                builder.InsertImage(u);
                builder.Write(name);
                builder.InsertBreak(BreakType.PageBreak);
            }
            return ReplaceAction.Replace;
        }
    }

    public class ReplaceAndInsertImgList : IReplacingCallback
    {
        /// <summary>
        /// 需要插入的图片路径
        /// </summary>
        public List<Dictionary<string, object>> url { get; set; }


        public ReplaceAndInsertImgList(List<Dictionary<string, object>> urlList)
        {
            this.url = urlList;
        }

        public ReplaceAction Replacing(ReplacingArgs e)
        {
            //获取当前节点
            var node = e.MatchNode;
            //获取当前文档
            Document doc = node.Document as Document;
            DocumentBuilder builder = new DocumentBuilder(doc);
            //将光标移动到指定节点
            builder.MoveTo(node);
            //插入图片
            foreach (Dictionary<string, object> d in url)
            {
                List<string> urlList = (List<string>)d["url"];
                string name = d["name"].ToString();
                foreach (string u in urlList)
                {
                    builder.InsertImage(u);
                    builder.InsertBreak(BreakType.LineBreak);
                }
                builder.Write(name);
                builder.InsertBreak(BreakType.PageBreak);
            }
            return ReplaceAction.Replace;
        }
    }
}