namespace GLC.Integration.CargowiseOne.CLASSICBRANDS.Pipelines
{
    using System;
    using System.Collections.Generic;
    using Microsoft.BizTalk.PipelineOM;
    using Microsoft.BizTalk.Component;
    using Microsoft.BizTalk.Component.Interop;
    
    
    public sealed class SendEDI945Pipeline : Microsoft.BizTalk.PipelineOM.SendPipeline
    {
        
        private const string _strPipeline = "<?xml version=\"1.0\" encoding=\"utf-16\"?><Document xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instanc"+
"e\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" MajorVersion=\"1\" MinorVersion=\"0\">  <Description /> "+
" <CategoryId>8c6b051c-0ff5-4fc2-9ae5-5016cb726282</CategoryId>  <FriendlyName>Transmit</FriendlyName"+
">  <Stages>    <Stage>      <PolicyFileStage _locAttrData=\"Name\" _locID=\"1\" Name=\"Pre-Assemble\" minO"+
"ccurs=\"0\" maxOccurs=\"-1\" execMethod=\"All\" stageId=\"9d0e4101-4cce-4536-83fa-4a5040674ad6\" />      <Co"+
"mponents>        <Component>          <Name>GLC.Integration.CargowiseOne.CLASSICBRANDS.PipelineCompo"+
"nent.CB945XmlTag,GLC.Integration.CargowiseOne.CLASSICBRANDS.PipelineComponent, Version=1.0.0.0, Cult"+
"ure=neutral, PublicKeyToken=0a6f121f7d5d0b26</Name>          <ComponentName>Change945Weight</Compone"+
"ntName>          <Description>Change945Weight</Description>          <Version>1.0</Version>         "+
" <Properties />          <CachedDisplayName>Change945Weight</CachedDisplayName>          <CachedIsMa"+
"naged>true</CachedIsManaged>        </Component>        <Component>          <Name>GLC.Integration.C"+
"argowiseOne.CLASSICBRANDS.PipelineComponent.CB945FileName,GLC.Integration.CargowiseOne.CLASSICBRANDS"+
".PipelineComponent, Version=1.0.0.0, Culture=neutral, PublicKeyToken=0a6f121f7d5d0b26</Name>        "+
"  <ComponentName>GetCB945FileName</ComponentName>          <Description>Get CB945Filename</Descripti"+
"on>          <Version>1.0</Version>          <Properties />          <CachedDisplayName>GetCB945File"+
"Name</CachedDisplayName>          <CachedIsManaged>true</CachedIsManaged>        </Component>      <"+
"/Components>    </Stage>    <Stage>      <PolicyFileStage _locAttrData=\"Name\" _locID=\"2\" Name=\"Assem"+
"ble\" minOccurs=\"0\" maxOccurs=\"1\" execMethod=\"All\" stageId=\"9d0e4107-4cce-4536-83fa-4a5040674ad6\" /> "+
"     <Components>        <Component>          <Name>Microsoft.BizTalk.Edi.Pipelines.EdiAssembler,Mic"+
"rosoft.BizTalk.Edi.PipelineComponents, Version=3.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad36"+
"4e35</Name>          <ComponentName>EDI Assembler</ComponentName>          <Description>EDI Assemble"+
"r</Description>          <Version>1.1</Version>          <Properties>            <Property Name=\"Ove"+
"rrideFallbackSettings\">              <Value xsi:type=\"xsd:boolean\">true</Value>            </Propert"+
"y>            <Property Name=\"XmlSchemaValidation\">              <Value xsi:type=\"xsd:boolean\">false"+
"</Value>            </Property>            <Property Name=\"EdiDataValidation\">              <Value x"+
"si:type=\"xsd:boolean\">false</Value>            </Property>            <Property Name=\"AllowTrailingD"+
"elimiters\">              <Value xsi:type=\"xsd:boolean\">false</Value>            </Property>         "+
"   <Property Name=\"CharacterSet\">              <Value xsi:type=\"xsd:string\">UTF8</Value>            "+
"</Property>          </Properties>          <CachedDisplayName>EDI Assembler</CachedDisplayName>    "+
"      <CachedIsManaged>true</CachedIsManaged>        </Component>      </Components>    </Stage>    "+
"<Stage>      <PolicyFileStage _locAttrData=\"Name\" _locID=\"3\" Name=\"Encode\" minOccurs=\"0\" maxOccurs=\""+
"-1\" execMethod=\"All\" stageId=\"9d0e4108-4cce-4536-83fa-4a5040674ad6\" />      <Components />    </Stag"+
"e>  </Stages></Document>";
        
        private const string _versionDependentGuid = "c10f2f3f-d2ec-4c0b-b502-314ac07704c8";
        
        public SendEDI945Pipeline()
        {
            Microsoft.BizTalk.PipelineOM.Stage stage = this.AddStage(new System.Guid("9d0e4101-4cce-4536-83fa-4a5040674ad6"), Microsoft.BizTalk.PipelineOM.ExecutionMode.all);
            IBaseComponent comp0 = Microsoft.BizTalk.PipelineOM.PipelineManager.CreateComponent("GLC.Integration.CargowiseOne.CLASSICBRANDS.PipelineComponent.CB945XmlTag,GLC.Integration.CargowiseOne.CLASSICBRANDS.PipelineComponent, Version=1.0.0.0, Culture=neutral, PublicKeyToken=0a6f121f7d5d0b26");;
            if (comp0 is IPersistPropertyBag)
            {
                string comp0XmlProperties = "<?xml version=\"1.0\" encoding=\"utf-16\"?><PropertyBag xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-inst"+
"ance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">  <Properties /></PropertyBag>";
                PropertyBag pb = PropertyBag.DeserializeFromXml(comp0XmlProperties);;
                ((IPersistPropertyBag)(comp0)).Load(pb, 0);
            }
            this.AddComponent(stage, comp0);
            IBaseComponent comp1 = Microsoft.BizTalk.PipelineOM.PipelineManager.CreateComponent("GLC.Integration.CargowiseOne.CLASSICBRANDS.PipelineComponent.CB945FileName,GLC.Integration.CargowiseOne.CLASSICBRANDS.PipelineComponent, Version=1.0.0.0, Culture=neutral, PublicKeyToken=0a6f121f7d5d0b26");;
            if (comp1 is IPersistPropertyBag)
            {
                string comp1XmlProperties = "<?xml version=\"1.0\" encoding=\"utf-16\"?><PropertyBag xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-inst"+
"ance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">  <Properties /></PropertyBag>";
                PropertyBag pb = PropertyBag.DeserializeFromXml(comp1XmlProperties);;
                ((IPersistPropertyBag)(comp1)).Load(pb, 0);
            }
            this.AddComponent(stage, comp1);
            stage = this.AddStage(new System.Guid("9d0e4107-4cce-4536-83fa-4a5040674ad6"), Microsoft.BizTalk.PipelineOM.ExecutionMode.all);
            IBaseComponent comp2 = Microsoft.BizTalk.PipelineOM.PipelineManager.CreateComponent("Microsoft.BizTalk.Edi.Pipelines.EdiAssembler,Microsoft.BizTalk.Edi.PipelineComponents, Version=3.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35");;
            if (comp2 is IPersistPropertyBag)
            {
                string comp2XmlProperties = "<?xml version=\"1.0\" encoding=\"utf-16\"?><PropertyBag xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-inst"+
"ance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">  <Properties>    <Property Name=\"OverrideFallbac"+
"kSettings\">      <Value xsi:type=\"xsd:boolean\">true</Value>    </Property>    <Property Name=\"XmlSch"+
"emaValidation\">      <Value xsi:type=\"xsd:boolean\">false</Value>    </Property>    <Property Name=\"E"+
"diDataValidation\">      <Value xsi:type=\"xsd:boolean\">false</Value>    </Property>    <Property Name"+
"=\"AllowTrailingDelimiters\">      <Value xsi:type=\"xsd:boolean\">false</Value>    </Property>    <Prop"+
"erty Name=\"CharacterSet\">      <Value xsi:type=\"xsd:string\">UTF8</Value>    </Property>  </Propertie"+
"s></PropertyBag>";
                PropertyBag pb = PropertyBag.DeserializeFromXml(comp2XmlProperties);;
                ((IPersistPropertyBag)(comp2)).Load(pb, 0);
            }
            this.AddComponent(stage, comp2);
        }
        
        public override string XmlContent
        {
            get
            {
                return _strPipeline;
            }
        }
        
        public override System.Guid VersionDependentGuid
        {
            get
            {
                return new System.Guid(_versionDependentGuid);
            }
        }
    }
}
