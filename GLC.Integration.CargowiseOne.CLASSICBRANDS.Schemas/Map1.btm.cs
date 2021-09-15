namespace GLC.Integration.CargowiseOne.CLASSICBRANDS.Schemas {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"GLC.Integration.CargowiseoneInboundCommon.Schemas.UniversalShipment", typeof(global::GLC.Integration.CargowiseoneInboundCommon.Schemas.UniversalShipment))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"GLC.Integration.CargowiseOne.CLASSICBRANDS.Schemas.EDI945.EDI945Xml", typeof(global::GLC.Integration.CargowiseOne.CLASSICBRANDS.Schemas.EDI945.EDI945Xml))]
    public sealed class Map1 : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:ns0=""http://schemas.microsoft.com/Edi/X12ServiceSchema"" xmlns:ns1=""http://schemas.microsoft.com/BizTalk/EDI/X12/2006/InterchangeXML"" xmlns:ns3=""http://schemas.microsoft.com/BizTalk/EDI/X12/2006"" xmlns:s0=""http://www.cargowise.com/Schemas/Universal/2011/11"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:UniversalShipment"" />
  </xsl:template>
  <xsl:template match=""/s0:UniversalShipment"">
    <ns1:X12InterchangeXml>
      <FunctionalGroup>
        <TransactionSet>
          <ns3:X12_00401_945>
            <ns3:LXLoop1>
              <xsl:for-each select=""s0:Shipment/s0:Order"">
                <xsl:for-each select=""s0:OrderLineCollection"">
                  <xsl:for-each select=""s0:OrderLine"">
                    <ns3:LX>
                      <xsl:if test=""s0:ExpiryDate"">
                        <LX01>
                          <xsl:value-of select=""s0:ExpiryDate/text()"" />
                        </LX01>
                      </xsl:if>
                    </ns3:LX>
                  </xsl:for-each>
                </xsl:for-each>
              </xsl:for-each>
              <xsl:for-each select=""s0:Shipment/s0:PackingLineCollection"">
                <xsl:for-each select=""s0:PackingLine"">
                  <xsl:for-each select=""s0:PackedItemCollection"">
                    <xsl:for-each select=""s0:PackedItem"">
                      <ns3:MAN>
                        <MAN01>
                          <xsl:value-of select=""../../s0:PackType/s0:Code/text()"" />
                        </MAN01>
                        <xsl:if test=""s0:Description"">
                          <MAN02>
                            <xsl:value-of select=""s0:Description/text()"" />
                          </MAN02>
                        </xsl:if>
                        <xsl:if test=""s0:PackedQuantity"">
                          <MAN03>
                            <xsl:value-of select=""s0:PackedQuantity/text()"" />
                          </MAN03>
                        </xsl:if>
                        <xsl:if test=""../../s0:ReferenceNumber"">
                          <MAN04>
                            <xsl:value-of select=""../../s0:ReferenceNumber/text()"" />
                          </MAN04>
                        </xsl:if>
                      </ns3:MAN>
                    </xsl:for-each>
                  </xsl:for-each>
                </xsl:for-each>
              </xsl:for-each>
              <xsl:for-each select=""s0:Shipment/s0:Order"">
                <xsl:for-each select=""s0:OrderLineCollection"">
                  <xsl:for-each select=""s0:OrderLine"">
                    <ns3:N9_2>
                      <xsl:if test=""s0:LineNumber"">
                        <N902>
                          <xsl:value-of select=""s0:LineNumber/text()"" />
                        </N902>
                      </xsl:if>
                    </ns3:N9_2>
                  </xsl:for-each>
                </xsl:for-each>
              </xsl:for-each>
            </ns3:LXLoop1>
          </ns3:X12_00401_945>
        </TransactionSet>
      </FunctionalGroup>
    </ns1:X12InterchangeXml>
  </xsl:template>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"GLC.Integration.CargowiseoneInboundCommon.Schemas.UniversalShipment";
        
        private const global::GLC.Integration.CargowiseoneInboundCommon.Schemas.UniversalShipment _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"GLC.Integration.CargowiseOne.CLASSICBRANDS.Schemas.EDI945.EDI945Xml";
        
        private const global::GLC.Integration.CargowiseOne.CLASSICBRANDS.Schemas.EDI945.EDI945Xml _trgSchemaTypeReference0 = null;
        
        public override string XmlContent {
            get {
                return _strMap;
            }
        }
        
        public override int UseXSLTransform {
            get {
                return _useXSLTransform;
            }
        }
        
        public override string XsltArgumentListContent {
            get {
                return _strArgList;
            }
        }
        
        public override string[] SourceSchemas {
            get {
                string[] _SrcSchemas = new string [1];
                _SrcSchemas[0] = @"GLC.Integration.CargowiseoneInboundCommon.Schemas.UniversalShipment";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"GLC.Integration.CargowiseOne.CLASSICBRANDS.Schemas.EDI945.EDI945Xml";
                return _TrgSchemas;
            }
        }
    }
}
