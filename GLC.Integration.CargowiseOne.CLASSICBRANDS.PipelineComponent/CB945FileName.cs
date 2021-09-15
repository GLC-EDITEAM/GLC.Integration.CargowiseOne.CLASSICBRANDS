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

namespace GLC.Integration.CargowiseOne.CLASSICBRANDS.PipelineComponent
{
    [Serializable]
    [ComponentCategory(CategoryTypes.CATID_PipelineComponent)]
    [ComponentCategory(CategoryTypes.CATID_Any)]
    [System.Runtime.InteropServices.Guid("08D8DE79-2AF6-4603-8DEB-4B393A93F8BF")]
    public class CB945FileName : IBaseComponent, IComponent, IComponentUI
    {
        #region IBaseComponent

        /// <summary>
        /// Name of the component.
        /// </summary>
        //[Browsable(false)]
        public string Name
        {
            get { return "GetCB945FileName"; }
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
            get { return "Get CB945Filename"; }
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
            XmlDocument document = new XmlDocument();
            document.LoadXml(xml);
            string str2 = document.SelectSingleNode("//W0602").InnerText.ToString();
            string str3 = "EDICB945_" + str2 + "_" + now.ToString("yyyyMMddTHHmmss");
            context.Promote("ReceivedFileName", "http://schemas.microsoft.com/BizTalk/2003/file-properties", str3);
            originalDataStream.Seek(0L, SeekOrigin.Begin);
            inmsg.BodyPart.Data = originalDataStream;
            inmsg.Context = context;
            return inmsg;
        }
        #endregion

    }
}


