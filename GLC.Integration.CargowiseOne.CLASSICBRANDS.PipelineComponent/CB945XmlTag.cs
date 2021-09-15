using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO.Compression;
using System.IO;
using Microsoft.BizTalk.Message.Interop;
using Microsoft.BizTalk.Component.Interop;
using GLC.Integration.CargowiseOne.CLASSICBRANDS.Utilites;
using System.Linq;

namespace GLC.Integration.CargowiseOne.CLASSICBRANDS.PipelineComponent
{
    [Serializable]
    [ComponentCategory(CategoryTypes.CATID_PipelineComponent)]
    [ComponentCategory(CategoryTypes.CATID_Any)]
    [System.Runtime.InteropServices.Guid("08D8DE79-2AF6-4603-8DEB-4B393A93F8BF")]
    public class CB945XmlTag : IBaseComponent, IComponent, IComponentUI
    {
        #region IBaseComponent

        /// <summary>
        /// Name of the component.
        /// </summary>
        //[Browsable(false)]
        public string Name
        {
            get { return "Change945Weight"; }
        }

        /// <summary>
        /// Version of the component.
        /// </summary>
        //[Browsable(false)]
        public string Version
        {
            get { return "1.0"; }
        }

        /// <summary>
        /// Description of the component.
        /// </summary>
        // [Browsable(false)]
        public string Description
        {
            get { return "Change945Weight"; }
        }

        #endregion
        #region IComponentUI
        public IntPtr Icon
        {
            get
            {
                return new System.IntPtr();
            }
        }

        public System.Collections.IEnumerator Validate(object projectSystem)
        {
            return null;
        }
        #endregion
        #region IComponent

        public Microsoft.BizTalk.Message.Interop.IBaseMessage Execute(Microsoft.BizTalk.Component.Interop.IPipelineContext pc, Microsoft.BizTalk.Message.Interop.IBaseMessage inmsg)
        {
            IBaseMessageContext context = inmsg.Context;
            Stream originalDataStream = inmsg.BodyPart.GetOriginalDataStream();
            string xml = new StreamReader(originalDataStream).ReadToEnd();
            DateTime now = new DateTime();
            now = DateTime.Now;
            XmlDocument xdoc = new XmlDocument();
            List<WeightClass> data = new List<WeightClass>();
            xdoc.LoadXml(xml);
            XmlNamespaceManager xmn = new XmlNamespaceManager(xdoc.NameTable);
            xmn.AddNamespace("xmlns2", "http://schemas.microsoft.com/BizTalk/EDI/X12/2006");
            //XmlNode node = xdoc.SelectSingleNode(xmlns2+"ns0:W12Loop1");
            XmlNodeList node = xdoc.SelectNodes("//xmlns2:LXLoop1", xmn);
            XmlNodeList doc = xdoc.SelectNodes("//xmlns2:W12Loop1", xmn);
            int elemcnt = doc.Count;
            //foreach (XmlNode nod in node)
            //{
            XmlNodeList nodew12 = xdoc.SelectNodes("//xmlns2:W12Loop1", xmn);
            foreach (XmlNode node12 in nodew12)
            {
                XmlNodeList nodew122 = node12.SelectNodes("xmlns2:W27_2", xmn);
                foreach (XmlNode node1223 in nodew122)
                {
                    string strrefnum = node1223["W2704"].InnerText;
                    double dweight = Convert.ToDouble(node1223["W2705"].InnerText);
                    data.Add(new WeightClass { refnum = strrefnum, weight = dweight });
                }
            }

            //}

            int cntval = data.Count();
            if( cntval>0)
            { 

            for (int i = 1; i <= elemcnt; i++)
            {
                string refnumber = xdoc.DocumentElement.SelectSingleNode("//xmlns2:W12Loop1[" + i + "]/xmlns2:W27_2/W2704", xmn).InnerText;
                double val = data.Where(item => item.refnum == refnumber).Sum(item => item.weight);
                xdoc.DocumentElement.SelectSingleNode("//xmlns2:W12Loop1[" + i + "]/xmlns2:W27_2/W2705", xmn).InnerText = val.ToString();
            }

            }
            string data1 = xdoc.OuterXml.ToString();
            byte[] bytearray = Encoding.UTF8.GetBytes(data1);
            MemoryStream strm = new MemoryStream(bytearray);
            originalDataStream = strm;
            originalDataStream.Seek(0, SeekOrigin.Begin);
            inmsg.BodyPart.Data = originalDataStream;
            inmsg.Context = context;
            return inmsg;
        }
        #endregion

    }
}


