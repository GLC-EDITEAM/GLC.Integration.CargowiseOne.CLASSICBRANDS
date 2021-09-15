namespace GLC.Integration.CargowiseOne.CLASSICBRANDS.Schemas.EDI945 {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://schemas.microsoft.com/BizTalk/EDI/X12/2006",@"X12_00401_945")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"X12_00401_945"})]
    public sealed class X12_00401_945 : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns=""http://schemas.microsoft.com/BizTalk/EDI/X12/2006"" xmlns:btsedi=""http://schemas.microsoft.com/BizTalk/2005/EdiSchemaEditorExtension"" targetNamespace=""http://schemas.microsoft.com/BizTalk/EDI/X12/2006"" version=""1.0"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <schemaEditorExtension:schemaInfo namespaceAlias=""btsedi"" extensionClass=""Microsoft.BizTalk.Edi.SchemaEditorExtension.EdiSchemaExtension"" standardName=""EDI"" xmlns:schemaEditorExtension=""http://schemas.microsoft.com/BizTalk/2003/SchemaEditorExtensions"" />
      <b:schemaInfo version=""1.0"" document_type=""945"" standard=""EDI"" standards_version=""00401"" root_reference=""X12_00401_945"" displayroot_reference=""X12_00401_945"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" X12ConditionDesignator_Check=""No"" />
    </xs:appinfo>
  </xs:annotation>
  <xs:annotation>
    <xs:documentation xml:lang=""en"">copyright © Microsoft Corporation. All rights reserved.</xs:documentation>
  </xs:annotation>
  <xs:annotation>
    <xs:documentation>Schema name: X12_4010_945</xs:documentation>
  </xs:annotation>
  <xs:element name=""X12_00401_945"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""postfix"" delimiter_type=""inherit_record"" count_ignore=""yes"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Warehouse Shipping Advice"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""ST"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo notes=""Transaction Set Header"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""ST01"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo notes=""Transaction Set Identifier Code_143"" />
                  </xs:appinfo>
                </xs:annotation>
                <xs:simpleType>
                  <xs:restriction base=""X12_AN"">
                    <xs:minLength value=""3"" />
                    <xs:maxLength value=""3"" />
                    <xs:enumeration value=""945"" />
                  </xs:restriction>
                </xs:simpleType>
              </xs:element>
              <xs:element name=""ST02"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo notes=""Transaction Set Control Number_329"" />
                  </xs:appinfo>
                </xs:annotation>
                <xs:simpleType>
                  <xs:restriction base=""X12_AN"">
                    <xs:minLength value=""4"" />
                    <xs:maxLength value=""9"" />
                  </xs:restriction>
                </xs:simpleType>
              </xs:element>
              <xs:element minOccurs=""0"" name=""ST03"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo notes=""Implementation Convention Preference_1705"" />
                  </xs:appinfo>
                </xs:annotation>
                <xs:simpleType>
                  <xs:restriction base=""X12_AN"">
                    <xs:minLength value=""1"" />
                    <xs:maxLength value=""9"" />
                  </xs:restriction>
                </xs:simpleType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element ref=""W06"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""W06"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Warehouse Shipment Identification"">
                <b:Rule subjects=""X12ConditionDesignatorX_Paired"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                  <b:Subject name=""W0607"" />
                  <b:Subject name=""W0608"" />
                </b:Rule>
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element maxOccurs=""10"" ref=""N1Loop1"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for Name"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""10"" ref=""N9"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""N9"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Reference Identification"">
                <b:Rule subjects=""X12ConditionDesignatorX_Required"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                  <b:Subject name=""N902"" />
                  <b:Subject name=""N903"" />
                </b:Rule>
                <b:Rule subjects=""X12ConditionDesignatorX_Conditional"" qualifier=""N906"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                  <b:Subject name=""N905"" />
                </b:Rule>
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""3"" ref=""G61"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""G61"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Contact"">
                <b:Rule subjects=""X12ConditionDesignatorX_Paired"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                  <b:Subject name=""G6103"" />
                  <b:Subject name=""G6104"" />
                </b:Rule>
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""5"" ref=""G62"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""G62"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Date/Time"">
                <b:Rule subjects=""X12ConditionDesignatorX_Required"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                  <b:Subject name=""G6201"" />
                  <b:Subject name=""G6203"" />
                </b:Rule>
                <b:Rule subjects=""X12ConditionDesignatorX_Paired"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                  <b:Subject name=""G6201"" />
                  <b:Subject name=""G6202"" />
                </b:Rule>
                <b:Rule subjects=""X12ConditionDesignatorX_Paired"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                  <b:Subject name=""G6203"" />
                  <b:Subject name=""G6204"" />
                </b:Rule>
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""20"" ref=""NTE"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""NTE"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Note/Special Instruction"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""W27"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""W27"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Carrier Detail"">
                <b:Rule subjects=""X12ConditionDesignatorX_Required"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                  <b:Subject name=""W2702"" />
                  <b:Subject name=""W2703"" />
                </b:Rule>
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""W6"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""W6"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Special Handling Information"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""W28"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""W28"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Consolidation Information"">
                <b:Rule subjects=""X12ConditionDesignatorX_Paired"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                  <b:Subject name=""W2802"" />
                  <b:Subject name=""W2803"" />
                  <b:Subject name=""W2804"" />
                </b:Rule>
                <b:Rule subjects=""X12ConditionDesignatorX_Paired"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                  <b:Subject name=""W2806"" />
                  <b:Subject name=""W2807"" />
                </b:Rule>
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""10"" ref=""W10"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""W10"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Warehouse Additional Carrier Information"">
                <b:Rule subjects=""X12ConditionDesignatorX_Paired"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                  <b:Subject name=""W1006"" />
                  <b:Subject name=""W1007"" />
                </b:Rule>
                <b:Rule subjects=""X12ConditionDesignatorX_Paired"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                  <b:Subject name=""W1008"" />
                  <b:Subject name=""W1009"" />
                </b:Rule>
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""5"" ref=""G72"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""G72"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Allowance or Charge"">
                <b:Rule subjects=""X12ConditionDesignatorX_Required"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                  <b:Subject name=""G7203"" />
                  <b:Subject name=""G7205"" />
                  <b:Subject name=""G7208"" />
                  <b:Subject name=""G7209"" />
                </b:Rule>
                <b:Rule subjects=""X12ConditionDesignatorX_Exclusion"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                  <b:Subject name=""G7205"" />
                  <b:Subject name=""G7208"" />
                  <b:Subject name=""G7209"" />
                </b:Rule>
                <b:Rule subjects=""X12ConditionDesignatorX_Paired"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                  <b:Subject name=""G7206"" />
                  <b:Subject name=""G7207"" />
                </b:Rule>
                <b:Rule subjects=""X12ConditionDesignatorX_Paired"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                  <b:Subject name=""G7209"" />
                  <b:Subject name=""G7210"" />
                </b:Rule>
                <b:Rule subjects=""X12ConditionDesignatorX_Conditional"" qualifier=""G7211"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                  <b:Subject name=""G7203"" />
                </b:Rule>
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""10"" ref=""LMLoop1"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for Code Source Information"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""LXLoop1"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for Assigned Number"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""W03"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""W03"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Total Shipment Information"">
                <b:Rule subjects=""X12ConditionDesignatorX_Conditional"" qualifier=""W0302"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                  <b:Subject name=""W0303"" />
                </b:Rule>
                <b:Rule subjects=""X12ConditionDesignatorX_Paired"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                  <b:Subject name=""W0304"" />
                  <b:Subject name=""W0305"" />
                </b:Rule>
                <b:Rule subjects=""X12ConditionDesignatorX_Paired"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                  <b:Subject name=""W0306"" />
                  <b:Subject name=""W0307"" />
                </b:Rule>
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""SE"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo notes=""Transaction Set Trailer"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""SE01"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo notes=""Number of Included Segments_96"" />
                  </xs:appinfo>
                </xs:annotation>
                <xs:simpleType>
                  <xs:restriction base=""X12_AN"">
                    <xs:minLength value=""1"" />
                    <xs:maxLength value=""10"" />
                  </xs:restriction>
                </xs:simpleType>
              </xs:element>
              <xs:element name=""SE02"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo notes=""Transaction Set Control Number_329"" />
                  </xs:appinfo>
                </xs:annotation>
                <xs:simpleType>
                  <xs:restriction base=""X12_AN"">
                    <xs:minLength value=""4"" />
                    <xs:maxLength value=""9"" />
                  </xs:restriction>
                </xs:simpleType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""N1Loop1"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for Name"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""N1"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""N1"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Name"">
                <b:Rule subjects=""X12ConditionDesignatorX_Required"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                  <b:Subject name=""N102"" />
                  <b:Subject name=""N103"" />
                </b:Rule>
                <b:Rule subjects=""X12ConditionDesignatorX_Paired"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                  <b:Subject name=""N103"" />
                  <b:Subject name=""N104"" />
                </b:Rule>
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""N2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""N2"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Additional Name Information"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""2"" ref=""N3"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""N3"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Address Information"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""N4"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""N4"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Geographic Location"">
                <b:Rule subjects=""X12ConditionDesignatorX_Conditional"" qualifier=""N406"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                  <b:Subject name=""N405"" />
                </b:Rule>
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""5"" ref=""PER"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""PER"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Administrative Communications Contact"">
                <b:Rule subjects=""X12ConditionDesignatorX_Paired"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                  <b:Subject name=""PER03"" />
                  <b:Subject name=""PER04"" />
                </b:Rule>
                <b:Rule subjects=""X12ConditionDesignatorX_Paired"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                  <b:Subject name=""PER05"" />
                  <b:Subject name=""PER06"" />
                </b:Rule>
                <b:Rule subjects=""X12ConditionDesignatorX_Paired"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                  <b:Subject name=""PER07"" />
                  <b:Subject name=""PER08"" />
                </b:Rule>
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""LMLoop1"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for Code Source Information"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""LM"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""LM"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Code Source Information"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element maxOccurs=""100"" ref=""LQ"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""LQ"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Industry Code"">
                <b:Rule subjects=""X12ConditionDesignatorX_Conditional"" qualifier=""LQ01"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                  <b:Subject name=""LQ02"" />
                </b:Rule>
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""LMLoop2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for Code Source Information"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""LM_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""LM"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Code Source Information"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element maxOccurs=""100"" ref=""LQ_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""LQ"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Industry Code"">
                <b:Rule subjects=""X12ConditionDesignatorX_Conditional"" qualifier=""LQ01"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                  <b:Subject name=""LQ02"" />
                </b:Rule>
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""LMLoop3"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for Code Source Information"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""LM_3"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""LM"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Code Source Information"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element maxOccurs=""100"" ref=""LQ_3"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""LQ"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Industry Code"">
                <b:Rule subjects=""X12ConditionDesignatorX_Conditional"" qualifier=""LQ01"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                  <b:Subject name=""LQ02"" />
                </b:Rule>
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""LXLoop2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for Assigned Number"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""LX_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""LX"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Assigned Number"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""N9_4"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""N9"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Reference Identification"">
                <b:Rule subjects=""X12ConditionDesignatorX_Required"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                  <b:Subject name=""N902"" />
                  <b:Subject name=""N903"" />
                </b:Rule>
                <b:Rule subjects=""X12ConditionDesignatorX_Conditional"" qualifier=""N906"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                  <b:Subject name=""N905"" />
                </b:Rule>
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""10"" ref=""G62_3"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""G62"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Date/Time"">
                <b:Rule subjects=""X12ConditionDesignatorX_Required"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                  <b:Subject name=""G6201"" />
                  <b:Subject name=""G6203"" />
                </b:Rule>
                <b:Rule subjects=""X12ConditionDesignatorX_Paired"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                  <b:Subject name=""G6201"" />
                  <b:Subject name=""G6202"" />
                </b:Rule>
                <b:Rule subjects=""X12ConditionDesignatorX_Paired"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                  <b:Subject name=""G6203"" />
                  <b:Subject name=""G6204"" />
                </b:Rule>
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""N1_3"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""N1"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Name"">
                <b:Rule subjects=""X12ConditionDesignatorX_Required"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                  <b:Subject name=""N102"" />
                  <b:Subject name=""N103"" />
                </b:Rule>
                <b:Rule subjects=""X12ConditionDesignatorX_Paired"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                  <b:Subject name=""N103"" />
                  <b:Subject name=""N104"" />
                </b:Rule>
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""10"" ref=""LMLoop3"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for Code Source Information"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""LSLoop1"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for Loop Header"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""1"" maxOccurs=""1"" ref=""LS"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""LS"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop Header"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""LXLoop2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for Assigned Number"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""1"" maxOccurs=""1"" ref=""LE"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""LE"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop Trailer"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""FA1Loop1"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for Type of Financial Accounting Data"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""FA1"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""FA1"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Type of Financial Accounting Data"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element maxOccurs=""unbounded"" ref=""FA2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""FA2"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Accounting Data"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""W12Loop1"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for Warehouse Item Detail"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""W12"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""W12"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Warehouse Item Detail"">
                <b:Rule subjects=""X12ConditionDesignatorX_Required"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                  <b:Subject name=""W1206"" />
                  <b:Subject name=""W1207"" />
                </b:Rule>
                <b:Rule subjects=""X12ConditionDesignatorX_Paired"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                  <b:Subject name=""W1207"" />
                  <b:Subject name=""W1208"" />
                </b:Rule>
                <b:Rule subjects=""X12ConditionDesignatorX_Paired"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                  <b:Subject name=""W1210"" />
                  <b:Subject name=""W1211"" />
                  <b:Subject name=""W1212"" />
                </b:Rule>
                <b:Rule subjects=""X12ConditionDesignatorX_Paired"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                  <b:Subject name=""W1213"" />
                  <b:Subject name=""W1214"" />
                  <b:Subject name=""W1215"" />
                </b:Rule>
                <b:Rule subjects=""X12ConditionDesignatorX_Paired"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                  <b:Subject name=""W1217"" />
                  <b:Subject name=""W1218"" />
                </b:Rule>
                <b:Rule subjects=""X12ConditionDesignatorX_Paired"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                  <b:Subject name=""W1221"" />
                  <b:Subject name=""W1222"" />
                </b:Rule>
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""5"" ref=""G69"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""G69"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Line Item Detail - Description"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""200"" ref=""N9_3"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""N9"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Reference Identification"">
                <b:Rule subjects=""X12ConditionDesignatorX_Required"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                  <b:Subject name=""N902"" />
                  <b:Subject name=""N903"" />
                </b:Rule>
                <b:Rule subjects=""X12ConditionDesignatorX_Conditional"" qualifier=""N906"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                  <b:Subject name=""N905"" />
                </b:Rule>
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""10"" ref=""G62_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""G62"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Date/Time"">
                <b:Rule subjects=""X12ConditionDesignatorX_Required"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                  <b:Subject name=""G6201"" />
                  <b:Subject name=""G6203"" />
                </b:Rule>
                <b:Rule subjects=""X12ConditionDesignatorX_Paired"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                  <b:Subject name=""G6201"" />
                  <b:Subject name=""G6202"" />
                </b:Rule>
                <b:Rule subjects=""X12ConditionDesignatorX_Paired"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                  <b:Subject name=""G6203"" />
                  <b:Subject name=""G6204"" />
                </b:Rule>
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""10"" ref=""QTY"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""QTY"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Quantity"">
                <b:Rule subjects=""X12ConditionDesignatorX_Required"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                  <b:Subject name=""QTY02"" />
                  <b:Subject name=""QTY04"" />
                </b:Rule>
                <b:Rule subjects=""X12ConditionDesignatorX_Exclusion"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                  <b:Subject name=""QTY02"" />
                  <b:Subject name=""QTY04"" />
                </b:Rule>
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""5"" ref=""MEA"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""MEA"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Measurements"">
                <b:Rule subjects=""X12ConditionDesignatorX_Required"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                  <b:Subject name=""MEA03"" />
                  <b:Subject name=""MEA05"" />
                  <b:Subject name=""MEA06"" />
                  <b:Subject name=""MEA08"" />
                </b:Rule>
                <b:Rule subjects=""X12ConditionDesignatorX_Conditional"" qualifier=""MEA05"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                  <b:Subject name=""C001_2"" />
                </b:Rule>
                <b:Rule subjects=""X12ConditionDesignatorX_Conditional"" qualifier=""MEA06"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                  <b:Subject name=""C001_2"" />
                </b:Rule>
                <b:Rule subjects=""X12ConditionDesignatorX_ListConditional"" qualifier=""MEA07"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                  <b:Subject name=""MEA03"" />
                  <b:Subject name=""MEA05"" />
                  <b:Subject name=""MEA06"" />
                </b:Rule>
                <b:Rule subjects=""X12ConditionDesignatorX_Exclusion"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                  <b:Subject name=""MEA08"" />
                  <b:Subject name=""MEA03"" />
                </b:Rule>
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""AMT"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""AMT"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Monetary Amount"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""5"" ref=""R4"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""R4"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Port or Terminal"">
                <b:Rule subjects=""X12ConditionDesignatorX_Paired"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                  <b:Subject name=""R402"" />
                  <b:Subject name=""R403"" />
                </b:Rule>
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""W27_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""W27"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Carrier Detail"">
                <b:Rule subjects=""X12ConditionDesignatorX_Required"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                  <b:Subject name=""W2702"" />
                  <b:Subject name=""W2703"" />
                </b:Rule>
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""5"" ref=""N1_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""N1"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Name"">
                <b:Rule subjects=""X12ConditionDesignatorX_Required"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                  <b:Subject name=""N102"" />
                  <b:Subject name=""N103"" />
                </b:Rule>
                <b:Rule subjects=""X12ConditionDesignatorX_Paired"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                  <b:Subject name=""N103"" />
                  <b:Subject name=""N104"" />
                </b:Rule>
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""5"" ref=""G72_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""G72"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Allowance or Charge"">
                <b:Rule subjects=""X12ConditionDesignatorX_Required"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                  <b:Subject name=""G7203"" />
                  <b:Subject name=""G7205"" />
                  <b:Subject name=""G7208"" />
                  <b:Subject name=""G7209"" />
                </b:Rule>
                <b:Rule subjects=""X12ConditionDesignatorX_Exclusion"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                  <b:Subject name=""G7205"" />
                  <b:Subject name=""G7208"" />
                  <b:Subject name=""G7209"" />
                </b:Rule>
                <b:Rule subjects=""X12ConditionDesignatorX_Paired"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                  <b:Subject name=""G7206"" />
                  <b:Subject name=""G7207"" />
                </b:Rule>
                <b:Rule subjects=""X12ConditionDesignatorX_Paired"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                  <b:Subject name=""G7209"" />
                  <b:Subject name=""G7210"" />
                </b:Rule>
                <b:Rule subjects=""X12ConditionDesignatorX_Conditional"" qualifier=""G7211"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                  <b:Subject name=""G7203"" />
                </b:Rule>
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""10"" ref=""LMLoop2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for Code Source Information"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""LSLoop1"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for Loop Header"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""FA1Loop1"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for Type of Financial Accounting Data"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""LXLoop1"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for Assigned Number"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""LX"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""LX"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Assigned Number"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""MAN"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""MAN"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Marks and Numbers"">
                <b:Rule subjects=""X12ConditionDesignatorX_Paired"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                  <b:Subject name=""MAN04"" />
                  <b:Subject name=""MAN05"" />
                </b:Rule>
                <b:Rule subjects=""X12ConditionDesignatorX_Conditional"" qualifier=""MAN06"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                  <b:Subject name=""MAN05"" />
                </b:Rule>
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""PAL"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""PAL"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Pallet Information"">
                <b:Rule subjects=""X12ConditionDesignatorX_Paired"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                  <b:Subject name=""PAL05"" />
                  <b:Subject name=""PAL06"" />
                </b:Rule>
                <b:Rule subjects=""X12ConditionDesignatorX_Conditional"" qualifier=""PAL07"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                  <b:Subject name=""PAL10"" />
                </b:Rule>
                <b:Rule subjects=""X12ConditionDesignatorX_Conditional"" qualifier=""PAL08"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                  <b:Subject name=""PAL10"" />
                </b:Rule>
                <b:Rule subjects=""X12ConditionDesignatorX_Conditional"" qualifier=""PAL09"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                  <b:Subject name=""PAL10"" />
                </b:Rule>
                <b:Rule subjects=""X12ConditionDesignatorX_ListConditional"" qualifier=""PAL10"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                  <b:Subject name=""PAL07"" />
                  <b:Subject name=""PAL08"" />
                  <b:Subject name=""PAL09"" />
                </b:Rule>
                <b:Rule subjects=""X12ConditionDesignatorX_Paired"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                  <b:Subject name=""PAL11"" />
                  <b:Subject name=""PAL12"" />
                </b:Rule>
                <b:Rule subjects=""X12ConditionDesignatorX_Paired"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                  <b:Subject name=""PAL13"" />
                  <b:Subject name=""PAL14"" />
                </b:Rule>
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""5"" ref=""N9_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""N9"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Reference Identification"">
                <b:Rule subjects=""X12ConditionDesignatorX_Required"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                  <b:Subject name=""N902"" />
                  <b:Subject name=""N903"" />
                </b:Rule>
                <b:Rule subjects=""X12ConditionDesignatorX_Conditional"" qualifier=""N906"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                  <b:Subject name=""N905"" />
                </b:Rule>
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""W12Loop1"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for Warehouse Item Detail"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""W06"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""W06"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Warehouse Shipment Identification"">
          <b:Rule subjects=""X12ConditionDesignatorX_Paired"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
            <b:Subject name=""W0607"" />
            <b:Subject name=""W0608"" />
          </b:Rule>
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""W0601"" type=""X12_ID_514"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Reporting Code_514"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""W0602"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Depositor Order Number_285"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""22"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""W0603"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Date_373"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_DT"">
              <xs:minLength value=""8"" />
              <xs:maxLength value=""8"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""W0604"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Shipment Identification Number_145"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""30"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""W0605"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Agent Shipment ID Number_531"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""12"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""W0606"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Purchase Order Number_324"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""22"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""W0607"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Master Reference (Link) Number_474"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""22"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""W0608"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Link Sequence Number_472"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_N0"">
              <xs:minLength value=""6"" />
              <xs:maxLength value=""6"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""W0609"" type=""X12_ID_152"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Special Handling Code_152"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""W0610"" type=""X12_ID_891"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Shipping Date Change Reason Code_891"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""W0611"" type=""X12_ID_640"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Transaction Type Code_640"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""W0612"" type=""X12_ID_306"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Action Code_306"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""N1"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""N1"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Name"">
          <b:Rule subjects=""X12ConditionDesignatorX_Required"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
            <b:Subject name=""N102"" />
            <b:Subject name=""N103"" />
          </b:Rule>
          <b:Rule subjects=""X12ConditionDesignatorX_Paired"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
            <b:Subject name=""N103"" />
            <b:Subject name=""N104"" />
          </b:Rule>
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""N101"" type=""X12_ID_98"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Entity Identifier Code_98"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""N102"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Name_93"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""60"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""N103"" type=""X12_ID_66"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Identification Code Qualifier_66"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""N104"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Identification Code_67"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_AN"">
              <xs:minLength value=""2"" />
              <xs:maxLength value=""80"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""N105"" type=""X12_ID_706"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Entity Relationship Code_706"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""N106"" type=""X12_ID_98"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Entity Identifier Code_98"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""N2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""N2"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Additional Name Information"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""N201"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Name_93"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""60"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""N202"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Name_93"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""60"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""N3"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""N3"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Address Information"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""N301"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Address Information_166"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""55"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""N302"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Address Information_166"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""55"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""N4"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""N4"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Geographic Location"">
          <b:Rule subjects=""X12ConditionDesignatorX_Conditional"" qualifier=""N406"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
            <b:Subject name=""N405"" />
          </b:Rule>
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""N401"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""City Name_19"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_AN"">
              <xs:minLength value=""2"" />
              <xs:maxLength value=""30"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""N402"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""State or Province Code_156"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_ID"">
              <xs:length value=""2"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""N403"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Postal Code_116"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_ID"">
              <xs:minLength value=""3"" />
              <xs:maxLength value=""15"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""N404"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Country Code_26"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_ID"">
              <xs:minLength value=""2"" />
              <xs:maxLength value=""3"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""N405"" type=""X12_ID_309"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Location Qualifier_309"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""N406"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Location Identifier_310"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""30"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""PER"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""PER"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Administrative Communications Contact"">
          <b:Rule subjects=""X12ConditionDesignatorX_Paired"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
            <b:Subject name=""PER03"" />
            <b:Subject name=""PER04"" />
          </b:Rule>
          <b:Rule subjects=""X12ConditionDesignatorX_Paired"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
            <b:Subject name=""PER05"" />
            <b:Subject name=""PER06"" />
          </b:Rule>
          <b:Rule subjects=""X12ConditionDesignatorX_Paired"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
            <b:Subject name=""PER07"" />
            <b:Subject name=""PER08"" />
          </b:Rule>
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""PER01"" type=""X12_ID_366"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Contact Function Code_366"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""PER02"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Name_93"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""60"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""PER03"" type=""X12_ID_365"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Communication Number Qualifier_365"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""PER04"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Communication Number_364"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""80"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""PER05"" type=""X12_ID_365"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Communication Number Qualifier_365"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""PER06"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Communication Number_364"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""80"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""PER07"" type=""X12_ID_365"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Communication Number Qualifier_365"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""PER08"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Communication Number_364"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""80"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""PER09"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Contact Inquiry Reference_443"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""20"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""N9"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""N9"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Reference Identification"">
          <b:Rule subjects=""X12ConditionDesignatorX_Required"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
            <b:Subject name=""N902"" />
            <b:Subject name=""N903"" />
          </b:Rule>
          <b:Rule subjects=""X12ConditionDesignatorX_Conditional"" qualifier=""N906"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
            <b:Subject name=""N905"" />
          </b:Rule>
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""N901"" type=""X12_ID_128"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Reference Identification Qualifier_128"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""N902"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Reference Identification_127"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""30"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""N903"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Free-form Description_369"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""45"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""N904"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Date_373"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_DT"">
              <xs:minLength value=""8"" />
              <xs:maxLength value=""8"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""N905"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Time_337"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_TM"">
              <xs:minLength value=""4"" />
              <xs:maxLength value=""8"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""N906"" type=""X12_ID_623"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Time Code_623"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C040"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Reference Identifier"">
                <b:Rule subjects=""X12ConditionDesignatorX_Paired"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                  <b:Subject name=""C04003"" />
                  <b:Subject name=""C04004"" />
                </b:Rule>
                <b:Rule subjects=""X12ConditionDesignatorX_Paired"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                  <b:Subject name=""C04005"" />
                  <b:Subject name=""C04006"" />
                </b:Rule>
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""G61"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""G61"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Contact"">
          <b:Rule subjects=""X12ConditionDesignatorX_Paired"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
            <b:Subject name=""G6103"" />
            <b:Subject name=""G6104"" />
          </b:Rule>
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""G6101"" type=""X12_ID_366"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Contact Function Code_366"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element name=""G6102"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Name_93"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""60"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""G6103"" type=""X12_ID_365"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Communication Number Qualifier_365"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""G6104"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Communication Number_364"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""80"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""G6105"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Contact Inquiry Reference_443"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""20"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""G62"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""G62"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Date/Time"">
          <b:Rule subjects=""X12ConditionDesignatorX_Required"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
            <b:Subject name=""G6201"" />
            <b:Subject name=""G6203"" />
          </b:Rule>
          <b:Rule subjects=""X12ConditionDesignatorX_Paired"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
            <b:Subject name=""G6201"" />
            <b:Subject name=""G6202"" />
          </b:Rule>
          <b:Rule subjects=""X12ConditionDesignatorX_Paired"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
            <b:Subject name=""G6203"" />
            <b:Subject name=""G6204"" />
          </b:Rule>
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""G6201"" type=""X12_ID_432"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Date Qualifier_432"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""G6202"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Date_373"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_DT"">
              <xs:minLength value=""8"" />
              <xs:maxLength value=""8"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""G6203"" type=""X12_ID_176"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Time Qualifier_176"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""G6204"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Time_337"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_TM"">
              <xs:minLength value=""4"" />
              <xs:maxLength value=""8"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""G6205"" type=""X12_ID_623"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Time Code_623"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""NTE"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""NTE"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Note/Special Instruction"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""NTE01"" type=""X12_ID_363"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Note Reference Code_363"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element name=""NTE02"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Description_352"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""80"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""W27"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""W27"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Carrier Detail"">
          <b:Rule subjects=""X12ConditionDesignatorX_Required"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
            <b:Subject name=""W2702"" />
            <b:Subject name=""W2703"" />
          </b:Rule>
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""W2701"" type=""X12_ID_91"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Transportation Method/Type Code_91"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""W2702"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Standard Carrier Alpha Code_140"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_ID"">
              <xs:minLength value=""2"" />
              <xs:maxLength value=""4"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""W2703"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Routing_387"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""W2704"" type=""X12_ID_146"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Shipment Method of Payment_146"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""W2705"" type=""X12_ID_40"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Equipment Description Code_40"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""W2706"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Equipment Initial_206"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""4"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""W2707"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Equipment Number_207"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""10"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""W2708"" type=""X12_ID_368"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Shipment/Order Status Code_368"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""W2709"" type=""X12_ID_152"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Special Handling Code_152"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""W2710"" type=""X12_ID_890"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Carrier/Route Change Reason Code_890"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""W6"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""W6"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Special Handling Information"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""W601"" type=""X12_ID_152"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Special Handling Code_152"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""W602"" type=""X12_ID_152"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Special Handling Code_152"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""W603"" type=""X12_ID_152"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Special Handling Code_152"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""W604"" type=""X12_ID_152"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Special Handling Code_152"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""W28"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""W28"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Consolidation Information"">
          <b:Rule subjects=""X12ConditionDesignatorX_Paired"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
            <b:Subject name=""W2802"" />
            <b:Subject name=""W2803"" />
            <b:Subject name=""W2804"" />
          </b:Rule>
          <b:Rule subjects=""X12ConditionDesignatorX_Paired"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
            <b:Subject name=""W2806"" />
            <b:Subject name=""W2807"" />
          </b:Rule>
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""W2801"" type=""X12_ID_604"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Consolidation Code_604"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""W2802"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Weight_81"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_R"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""10"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""W2803"" type=""X12_ID_187"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Weight Qualifier_187"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""W2804"" type=""X12_ID_188"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Weight Unit Code_188"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""W2805"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Total Stopoffs_466"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_N0"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""2"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""W2806"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Location Identifier_310"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""30"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""W2807"" type=""X12_ID_309"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Location Qualifier_309"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""W2808"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Bill of Lading/Waybill Number_598"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""12"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""W10"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""W10"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Warehouse Additional Carrier Information"">
          <b:Rule subjects=""X12ConditionDesignatorX_Paired"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
            <b:Subject name=""W1006"" />
            <b:Subject name=""W1007"" />
          </b:Rule>
          <b:Rule subjects=""X12ConditionDesignatorX_Paired"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
            <b:Subject name=""W1008"" />
            <b:Subject name=""W1009"" />
          </b:Rule>
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""W1001"" type=""X12_ID_400"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Unit Load Option Code_400"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""W1002"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Quantity of Pallets Shipped_406"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_N0"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""3"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""W1003"" type=""X12_ID_399"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Pallet Exchange Code_399"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""W1004"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Seal Number_225"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_AN"">
              <xs:minLength value=""2"" />
              <xs:maxLength value=""15"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""W1005"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Seal Number_225"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_AN"">
              <xs:minLength value=""2"" />
              <xs:maxLength value=""15"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""W1006"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Temperature_408"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_R"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""4"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""W1007"" type=""X12_ID_355"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Unit or Basis for Measurement Code_355"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""W1008"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Temperature_408"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_R"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""4"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""W1009"" type=""X12_ID_355"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Unit or Basis for Measurement Code_355"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""G72"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""G72"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Allowance or Charge"">
          <b:Rule subjects=""X12ConditionDesignatorX_Required"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
            <b:Subject name=""G7203"" />
            <b:Subject name=""G7205"" />
            <b:Subject name=""G7208"" />
            <b:Subject name=""G7209"" />
          </b:Rule>
          <b:Rule subjects=""X12ConditionDesignatorX_Exclusion"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
            <b:Subject name=""G7205"" />
            <b:Subject name=""G7208"" />
            <b:Subject name=""G7209"" />
          </b:Rule>
          <b:Rule subjects=""X12ConditionDesignatorX_Paired"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
            <b:Subject name=""G7206"" />
            <b:Subject name=""G7207"" />
          </b:Rule>
          <b:Rule subjects=""X12ConditionDesignatorX_Paired"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
            <b:Subject name=""G7209"" />
            <b:Subject name=""G7210"" />
          </b:Rule>
          <b:Rule subjects=""X12ConditionDesignatorX_Conditional"" qualifier=""G7211"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
            <b:Subject name=""G7203"" />
          </b:Rule>
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""G7201"" type=""X12_ID_340"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Allowance or Charge Code_340"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element name=""G7202"" type=""X12_ID_331"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Allowance or Charge Method of Handling Code_331"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""G7203"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Allowance or Charge Number_341"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""16"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""G7204"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Exception Number_769"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""16"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""G7205"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Allowance or Charge Rate_359"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_R"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""15"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""G7206"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Allowance or Charge Quantity_339"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_R"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""10"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""G7207"" type=""X12_ID_355"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Unit or Basis for Measurement Code_355"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""G7208"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Allowance or Charge Total Amount_360"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_N2"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""15"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""G7209"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Percent_332"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_R"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""6"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""G7210"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Dollar Basis For Percent_828"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_R"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""9"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""G7211"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Option Number_770"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""20"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""LM"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""LM"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Code Source Information"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""LM01"" type=""X12_ID_559"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Agency Qualifier Code_559"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""LM02"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Source Subqualifier_822"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""15"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""LQ"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""LQ"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Industry Code"">
          <b:Rule subjects=""X12ConditionDesignatorX_Conditional"" qualifier=""LQ01"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
            <b:Subject name=""LQ02"" />
          </b:Rule>
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""LQ01"" type=""X12_ID_1270"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code List Qualifier Code_1270"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""LQ02"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Industry Code_1271"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""30"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""LX"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""LX"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Assigned Number"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""LX01"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Assigned Number_554"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_N0"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""6"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""MAN"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""MAN"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Marks and Numbers"">
          <b:Rule subjects=""X12ConditionDesignatorX_Paired"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
            <b:Subject name=""MAN04"" />
            <b:Subject name=""MAN05"" />
          </b:Rule>
          <b:Rule subjects=""X12ConditionDesignatorX_Conditional"" qualifier=""MAN06"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
            <b:Subject name=""MAN05"" />
          </b:Rule>
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""MAN01"" type=""X12_ID_88"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Marks and Numbers Qualifier_88"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element name=""MAN02"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Marks and Numbers_87"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""48"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""MAN03"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Marks and Numbers_87"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""48"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""MAN04"" type=""X12_ID_88"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Marks and Numbers Qualifier_88"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""MAN05"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Marks and Numbers_87"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""48"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""MAN06"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Marks and Numbers_87"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""48"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""PAL"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""PAL"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Pallet Information"">
          <b:Rule subjects=""X12ConditionDesignatorX_Paired"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
            <b:Subject name=""PAL05"" />
            <b:Subject name=""PAL06"" />
          </b:Rule>
          <b:Rule subjects=""X12ConditionDesignatorX_Conditional"" qualifier=""PAL07"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
            <b:Subject name=""PAL10"" />
          </b:Rule>
          <b:Rule subjects=""X12ConditionDesignatorX_Conditional"" qualifier=""PAL08"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
            <b:Subject name=""PAL10"" />
          </b:Rule>
          <b:Rule subjects=""X12ConditionDesignatorX_Conditional"" qualifier=""PAL09"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
            <b:Subject name=""PAL10"" />
          </b:Rule>
          <b:Rule subjects=""X12ConditionDesignatorX_ListConditional"" qualifier=""PAL10"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
            <b:Subject name=""PAL07"" />
            <b:Subject name=""PAL08"" />
            <b:Subject name=""PAL09"" />
          </b:Rule>
          <b:Rule subjects=""X12ConditionDesignatorX_Paired"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
            <b:Subject name=""PAL11"" />
            <b:Subject name=""PAL12"" />
          </b:Rule>
          <b:Rule subjects=""X12ConditionDesignatorX_Paired"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
            <b:Subject name=""PAL13"" />
            <b:Subject name=""PAL14"" />
          </b:Rule>
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""PAL01"" type=""X12_ID_883"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Pallet Type Code_883"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""PAL02"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Pallet Tiers_884"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_N0"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""3"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""PAL03"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Pallet Blocks_885"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_N0"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""3"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""PAL04"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Pack_356"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_N0"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""6"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""PAL05"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Unit Weight_395"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_R"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""8"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""PAL06"" type=""X12_ID_355"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Unit or Basis for Measurement Code_355"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""PAL07"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Length_82"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_R"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""8"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""PAL08"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Width_189"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_R"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""8"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""PAL09"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Height_65"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_R"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""8"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""PAL10"" type=""X12_ID_355"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Unit or Basis for Measurement Code_355"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""PAL11"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Gross Weight per Pack_384"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_R"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""9"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""PAL12"" type=""X12_ID_355"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Unit or Basis for Measurement Code_355"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""PAL13"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Gross Volume per Pack_385"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_R"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""9"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""PAL14"" type=""X12_ID_355"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Unit or Basis for Measurement Code_355"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""PAL15"" type=""X12_ID_399"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Pallet Exchange Code_399"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""PAL16"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Inner Pack_810"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_N0"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""6"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""N9_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""N9_2"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Reference Identification"">
          <b:Rule subjects=""X12ConditionDesignatorX_Required"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
            <b:Subject name=""N902"" />
            <b:Subject name=""N903"" />
          </b:Rule>
          <b:Rule subjects=""X12ConditionDesignatorX_Conditional"" qualifier=""N906"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
            <b:Subject name=""N905"" />
          </b:Rule>
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""N901"" type=""X12_ID_128"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Reference Identification Qualifier_128"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""N902"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Reference Identification_127"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""30"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""N903"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Free-form Description_369"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""45"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""N904"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Date_373"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_DT"">
              <xs:minLength value=""8"" />
              <xs:maxLength value=""8"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""N905"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Time_337"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_TM"">
              <xs:minLength value=""4"" />
              <xs:maxLength value=""8"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""N906"" type=""X12_ID_623"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Time Code_623"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C040_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Reference Identifier"">
                <b:Rule subjects=""X12ConditionDesignatorX_Paired"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                  <b:Subject name=""C04003"" />
                  <b:Subject name=""C04004"" />
                </b:Rule>
                <b:Rule subjects=""X12ConditionDesignatorX_Paired"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                  <b:Subject name=""C04005"" />
                  <b:Subject name=""C04006"" />
                </b:Rule>
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""W12"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""W12"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Warehouse Item Detail"">
          <b:Rule subjects=""X12ConditionDesignatorX_Required"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
            <b:Subject name=""W1206"" />
            <b:Subject name=""W1207"" />
          </b:Rule>
          <b:Rule subjects=""X12ConditionDesignatorX_Paired"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
            <b:Subject name=""W1207"" />
            <b:Subject name=""W1208"" />
          </b:Rule>
          <b:Rule subjects=""X12ConditionDesignatorX_Paired"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
            <b:Subject name=""W1210"" />
            <b:Subject name=""W1211"" />
            <b:Subject name=""W1212"" />
          </b:Rule>
          <b:Rule subjects=""X12ConditionDesignatorX_Paired"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
            <b:Subject name=""W1213"" />
            <b:Subject name=""W1214"" />
            <b:Subject name=""W1215"" />
          </b:Rule>
          <b:Rule subjects=""X12ConditionDesignatorX_Paired"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
            <b:Subject name=""W1217"" />
            <b:Subject name=""W1218"" />
          </b:Rule>
          <b:Rule subjects=""X12ConditionDesignatorX_Paired"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
            <b:Subject name=""W1221"" />
            <b:Subject name=""W1222"" />
          </b:Rule>
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""W1201"" type=""X12_ID_368"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Shipment/Order Status Code_368"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""W1202"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Quantity Ordered_330"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_R"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""15"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""W1203"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Number of Units Shipped_382"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_R"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""10"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""W1204"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Quantity Difference_383"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_R"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""9"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""W1205"" type=""X12_ID_355"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Unit or Basis for Measurement Code_355"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""W1206"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""U.P.C. Case Code_438"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_AN"">
              <xs:length value=""12"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""W1207"" type=""X12_ID_235"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Product/Service ID Qualifier_235"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""W1208"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Product/Service ID_234"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""48"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""W1209"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Warehouse Lot Number_451"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""12"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""W1210"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Weight_81"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_R"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""10"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""W1211"" type=""X12_ID_187"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Weight Qualifier_187"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""W1212"" type=""X12_ID_188"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Weight Unit Code_188"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""W1213"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Weight_81"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_R"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""10"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""W1214"" type=""X12_ID_187"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Weight Qualifier_187"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""W1215"" type=""X12_ID_188"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Weight Unit Code_188"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""W1216"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""U.P.C. Case Code_438"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_AN"">
              <xs:length value=""12"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""W1217"" type=""X12_ID_235"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Product/Service ID Qualifier_235"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""W1218"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Product/Service ID_234"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""48"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""W1219"" type=""X12_ID_892"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Line Item Change Reason Code_892"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""W1220"" type=""X12_ID_893"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Warehouse Detail Adjustment Identifier_893"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""W1221"" type=""X12_ID_235"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Product/Service ID Qualifier_235"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""W1222"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Product/Service ID_234"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""48"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""G69"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""G69"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Line Item Detail - Description"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""G6901"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Free-form Description_369"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""45"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""N9_3"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""N9_3"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Reference Identification"">
          <b:Rule subjects=""X12ConditionDesignatorX_Required"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
            <b:Subject name=""N902"" />
            <b:Subject name=""N903"" />
          </b:Rule>
          <b:Rule subjects=""X12ConditionDesignatorX_Conditional"" qualifier=""N906"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
            <b:Subject name=""N905"" />
          </b:Rule>
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""N901"" type=""X12_ID_128"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Reference Identification Qualifier_128"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""N902"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Reference Identification_127"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""30"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""N903"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Free-form Description_369"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""45"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""N904"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Date_373"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_DT"">
              <xs:minLength value=""8"" />
              <xs:maxLength value=""8"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""N905"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Time_337"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_TM"">
              <xs:minLength value=""4"" />
              <xs:maxLength value=""8"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""N906"" type=""X12_ID_623"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Time Code_623"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C040_3"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Reference Identifier"">
                <b:Rule subjects=""X12ConditionDesignatorX_Paired"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                  <b:Subject name=""C04003"" />
                  <b:Subject name=""C04004"" />
                </b:Rule>
                <b:Rule subjects=""X12ConditionDesignatorX_Paired"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                  <b:Subject name=""C04005"" />
                  <b:Subject name=""C04006"" />
                </b:Rule>
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""G62_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""G62_2"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Date/Time"">
          <b:Rule subjects=""X12ConditionDesignatorX_Required"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
            <b:Subject name=""G6201"" />
            <b:Subject name=""G6203"" />
          </b:Rule>
          <b:Rule subjects=""X12ConditionDesignatorX_Paired"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
            <b:Subject name=""G6201"" />
            <b:Subject name=""G6202"" />
          </b:Rule>
          <b:Rule subjects=""X12ConditionDesignatorX_Paired"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
            <b:Subject name=""G6203"" />
            <b:Subject name=""G6204"" />
          </b:Rule>
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""G6201"" type=""X12_ID_432"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Date Qualifier_432"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""G6202"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Date_373"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_DT"">
              <xs:minLength value=""8"" />
              <xs:maxLength value=""8"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""G6203"" type=""X12_ID_176"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Time Qualifier_176"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""G6204"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Time_337"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_TM"">
              <xs:minLength value=""4"" />
              <xs:maxLength value=""8"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""G6205"" type=""X12_ID_623"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Time Code_623"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""QTY"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""QTY"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Quantity"">
          <b:Rule subjects=""X12ConditionDesignatorX_Required"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
            <b:Subject name=""QTY02"" />
            <b:Subject name=""QTY04"" />
          </b:Rule>
          <b:Rule subjects=""X12ConditionDesignatorX_Exclusion"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
            <b:Subject name=""QTY02"" />
            <b:Subject name=""QTY04"" />
          </b:Rule>
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""QTY01"" type=""X12_ID_673"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Quantity Qualifier_673"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""QTY02"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Quantity_380"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_R"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""15"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C001"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Composite Unit of Measure"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""QTY04"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Free-Form Message_61"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""30"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""MEA"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""MEA"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Measurements"">
          <b:Rule subjects=""X12ConditionDesignatorX_Required"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
            <b:Subject name=""MEA03"" />
            <b:Subject name=""MEA05"" />
            <b:Subject name=""MEA06"" />
            <b:Subject name=""MEA08"" />
          </b:Rule>
          <b:Rule subjects=""X12ConditionDesignatorX_Conditional"" qualifier=""MEA05"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
            <b:Subject name=""C001_2"" />
          </b:Rule>
          <b:Rule subjects=""X12ConditionDesignatorX_Conditional"" qualifier=""MEA06"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
            <b:Subject name=""C001_2"" />
          </b:Rule>
          <b:Rule subjects=""X12ConditionDesignatorX_ListConditional"" qualifier=""MEA07"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
            <b:Subject name=""MEA03"" />
            <b:Subject name=""MEA05"" />
            <b:Subject name=""MEA06"" />
          </b:Rule>
          <b:Rule subjects=""X12ConditionDesignatorX_Exclusion"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
            <b:Subject name=""MEA08"" />
            <b:Subject name=""MEA03"" />
          </b:Rule>
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""MEA01"" type=""X12_ID_737"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Measurement Reference ID Code_737"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""MEA02"" type=""X12_ID_738"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Measurement Qualifier_738"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""MEA03"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Measurement Value_739"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_R"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""20"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C001_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Composite Unit of Measure"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""MEA05"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Range Minimum_740"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_R"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""20"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""MEA06"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Range Maximum_741"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_R"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""20"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""MEA07"" type=""X12_ID_935"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Measurement Significance Code_935"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""MEA08"" type=""X12_ID_936"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Measurement Attribute Code_936"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""MEA09"" type=""X12_ID_752"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Surface/Layer/Position Code_752"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""MEA10"" type=""X12_ID_1373"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Measurement Method or Device_1373"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""AMT"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""AMT"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Monetary Amount"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""AMT01"" type=""X12_ID_522"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Amount Qualifier Code_522"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element name=""AMT02"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Monetary Amount_782"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_R"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""18"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""AMT03"" type=""X12_ID_478"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Credit/Debit Flag Code_478"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""R4"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""R4"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Port or Terminal"">
          <b:Rule subjects=""X12ConditionDesignatorX_Paired"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
            <b:Subject name=""R402"" />
            <b:Subject name=""R403"" />
          </b:Rule>
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""R401"" type=""X12_ID_115"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Port or Terminal Function Code_115"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""R402"" type=""X12_ID_309"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Location Qualifier_309"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""R403"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Location Identifier_310"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""30"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""R404"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Port Name_114"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_AN"">
              <xs:minLength value=""2"" />
              <xs:maxLength value=""24"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""R405"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Country Code_26"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_ID"">
              <xs:minLength value=""2"" />
              <xs:maxLength value=""3"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""R406"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Terminal Name_174"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_AN"">
              <xs:minLength value=""2"" />
              <xs:maxLength value=""30"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""R407"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Pier Number_113"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""4"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""R408"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""State or Province Code_156"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_ID"">
              <xs:length value=""2"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""W27_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""W27_2"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Carrier Detail"">
          <b:Rule subjects=""X12ConditionDesignatorX_Required"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
            <b:Subject name=""W2702"" />
            <b:Subject name=""W2703"" />
          </b:Rule>
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""W2701"" type=""X12_ID_91"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Transportation Method/Type Code_91"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""W2702"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Standard Carrier Alpha Code_140"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_ID"">
              <xs:minLength value=""2"" />
              <xs:maxLength value=""4"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""W2703"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Routing_387"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""W2704"" type=""X12_ID_146"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Shipment Method of Payment_146"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""W2705"" type=""X12_ID_40"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Equipment Description Code_40"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""W2706"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Equipment Initial_206"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""4"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""W2707"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Equipment Number_207"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""10"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""W2708"" type=""X12_ID_368"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Shipment/Order Status Code_368"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""W2709"" type=""X12_ID_152"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Special Handling Code_152"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""W2710"" type=""X12_ID_890"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Carrier/Route Change Reason Code_890"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""N1_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""N1_2"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Name"">
          <b:Rule subjects=""X12ConditionDesignatorX_Required"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
            <b:Subject name=""N102"" />
            <b:Subject name=""N103"" />
          </b:Rule>
          <b:Rule subjects=""X12ConditionDesignatorX_Paired"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
            <b:Subject name=""N103"" />
            <b:Subject name=""N104"" />
          </b:Rule>
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""N101"" type=""X12_ID_98"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Entity Identifier Code_98"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""N102"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Name_93"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""60"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""N103"" type=""X12_ID_66"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Identification Code Qualifier_66"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""N104"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Identification Code_67"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_AN"">
              <xs:minLength value=""2"" />
              <xs:maxLength value=""80"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""N105"" type=""X12_ID_706"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Entity Relationship Code_706"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""N106"" type=""X12_ID_98"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Entity Identifier Code_98"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""G72_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""G72_2"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Allowance or Charge"">
          <b:Rule subjects=""X12ConditionDesignatorX_Required"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
            <b:Subject name=""G7203"" />
            <b:Subject name=""G7205"" />
            <b:Subject name=""G7208"" />
            <b:Subject name=""G7209"" />
          </b:Rule>
          <b:Rule subjects=""X12ConditionDesignatorX_Exclusion"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
            <b:Subject name=""G7205"" />
            <b:Subject name=""G7208"" />
            <b:Subject name=""G7209"" />
          </b:Rule>
          <b:Rule subjects=""X12ConditionDesignatorX_Paired"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
            <b:Subject name=""G7206"" />
            <b:Subject name=""G7207"" />
          </b:Rule>
          <b:Rule subjects=""X12ConditionDesignatorX_Paired"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
            <b:Subject name=""G7209"" />
            <b:Subject name=""G7210"" />
          </b:Rule>
          <b:Rule subjects=""X12ConditionDesignatorX_Conditional"" qualifier=""G7211"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
            <b:Subject name=""G7203"" />
          </b:Rule>
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""G7201"" type=""X12_ID_340"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Allowance or Charge Code_340"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element name=""G7202"" type=""X12_ID_331"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Allowance or Charge Method of Handling Code_331"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""G7203"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Allowance or Charge Number_341"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""16"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""G7204"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Exception Number_769"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""16"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""G7205"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Allowance or Charge Rate_359"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_R"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""15"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""G7206"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Allowance or Charge Quantity_339"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_R"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""10"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""G7207"" type=""X12_ID_355"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Unit or Basis for Measurement Code_355"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""G7208"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Allowance or Charge Total Amount_360"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_N2"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""15"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""G7209"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Percent_332"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_R"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""6"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""G7210"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Dollar Basis For Percent_828"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_R"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""9"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""G7211"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Option Number_770"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""20"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""LM_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""LM_2"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Code Source Information"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""LM01"" type=""X12_ID_559"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Agency Qualifier Code_559"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""LM02"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Source Subqualifier_822"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""15"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""LQ_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""LQ_2"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Industry Code"">
          <b:Rule subjects=""X12ConditionDesignatorX_Conditional"" qualifier=""LQ01"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
            <b:Subject name=""LQ02"" />
          </b:Rule>
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""LQ01"" type=""X12_ID_1270"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code List Qualifier Code_1270"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""LQ02"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Industry Code_1271"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""30"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""LS"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""LS"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop Header"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""LS01"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Loop Identifier Code_447"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""6"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""LX_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""LX_2"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Assigned Number"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""LX01"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Assigned Number_554"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_N0"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""6"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""N9_4"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""N9_4"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Reference Identification"">
          <b:Rule subjects=""X12ConditionDesignatorX_Required"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
            <b:Subject name=""N902"" />
            <b:Subject name=""N903"" />
          </b:Rule>
          <b:Rule subjects=""X12ConditionDesignatorX_Conditional"" qualifier=""N906"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
            <b:Subject name=""N905"" />
          </b:Rule>
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""N901"" type=""X12_ID_128"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Reference Identification Qualifier_128"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""N902"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Reference Identification_127"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""30"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""N903"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Free-form Description_369"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""45"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""N904"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Date_373"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_DT"">
              <xs:minLength value=""8"" />
              <xs:maxLength value=""8"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""N905"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Time_337"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_TM"">
              <xs:minLength value=""4"" />
              <xs:maxLength value=""8"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""N906"" type=""X12_ID_623"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Time Code_623"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C040_4"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Reference Identifier"">
                <b:Rule subjects=""X12ConditionDesignatorX_Paired"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                  <b:Subject name=""C04003"" />
                  <b:Subject name=""C04004"" />
                </b:Rule>
                <b:Rule subjects=""X12ConditionDesignatorX_Paired"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                  <b:Subject name=""C04005"" />
                  <b:Subject name=""C04006"" />
                </b:Rule>
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""G62_3"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""G62_3"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Date/Time"">
          <b:Rule subjects=""X12ConditionDesignatorX_Required"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
            <b:Subject name=""G6201"" />
            <b:Subject name=""G6203"" />
          </b:Rule>
          <b:Rule subjects=""X12ConditionDesignatorX_Paired"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
            <b:Subject name=""G6201"" />
            <b:Subject name=""G6202"" />
          </b:Rule>
          <b:Rule subjects=""X12ConditionDesignatorX_Paired"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
            <b:Subject name=""G6203"" />
            <b:Subject name=""G6204"" />
          </b:Rule>
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""G6201"" type=""X12_ID_432"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Date Qualifier_432"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""G6202"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Date_373"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_DT"">
              <xs:minLength value=""8"" />
              <xs:maxLength value=""8"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""G6203"" type=""X12_ID_176"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Time Qualifier_176"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""G6204"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Time_337"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_TM"">
              <xs:minLength value=""4"" />
              <xs:maxLength value=""8"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""G6205"" type=""X12_ID_623"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Time Code_623"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""N1_3"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""N1_3"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Name"">
          <b:Rule subjects=""X12ConditionDesignatorX_Required"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
            <b:Subject name=""N102"" />
            <b:Subject name=""N103"" />
          </b:Rule>
          <b:Rule subjects=""X12ConditionDesignatorX_Paired"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
            <b:Subject name=""N103"" />
            <b:Subject name=""N104"" />
          </b:Rule>
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""N101"" type=""X12_ID_98"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Entity Identifier Code_98"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""N102"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Name_93"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""60"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""N103"" type=""X12_ID_66"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Identification Code Qualifier_66"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""N104"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Identification Code_67"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_AN"">
              <xs:minLength value=""2"" />
              <xs:maxLength value=""80"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""N105"" type=""X12_ID_706"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Entity Relationship Code_706"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""N106"" type=""X12_ID_98"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Entity Identifier Code_98"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""LM_3"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""LM_3"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Code Source Information"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""LM01"" type=""X12_ID_559"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Agency Qualifier Code_559"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""LM02"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Source Subqualifier_822"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""15"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""LQ_3"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""LQ_3"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Industry Code"">
          <b:Rule subjects=""X12ConditionDesignatorX_Conditional"" qualifier=""LQ01"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
            <b:Subject name=""LQ02"" />
          </b:Rule>
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""LQ01"" type=""X12_ID_1270"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code List Qualifier Code_1270"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""LQ02"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Industry Code_1271"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""30"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""LE"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""LE"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop Trailer"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""LE01"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Loop Identifier Code_447"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""6"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""FA1"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""FA1"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Type of Financial Accounting Data"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""FA101"" type=""X12_ID_559"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Agency Qualifier Code_559"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""FA102"" type=""X12_ID_1300"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Service, Promotion, Allowance, or Charge Code_1300"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""FA103"" type=""X12_ID_248"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Allowance or Charge Indicator_248"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""FA2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""FA2"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Accounting Data"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""FA201"" type=""X12_ID_1196"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Breakdown Structure Detail Code_1196"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element name=""FA202"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Financial Information Code_1195"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""80"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""W03"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""W03"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Total Shipment Information"">
          <b:Rule subjects=""X12ConditionDesignatorX_Conditional"" qualifier=""W0302"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
            <b:Subject name=""W0303"" />
          </b:Rule>
          <b:Rule subjects=""X12ConditionDesignatorX_Paired"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
            <b:Subject name=""W0304"" />
            <b:Subject name=""W0305"" />
          </b:Rule>
          <b:Rule subjects=""X12ConditionDesignatorX_Paired"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
            <b:Subject name=""W0306"" />
            <b:Subject name=""W0307"" />
          </b:Rule>
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""W0301"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Number of Units Shipped_382"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_R"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""10"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""W0302"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Weight_81"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_R"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""10"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""W0303"" type=""X12_ID_355"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Unit or Basis for Measurement Code_355"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""W0304"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Volume_183"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_R"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""8"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""W0305"" type=""X12_ID_355"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Unit or Basis for Measurement Code_355"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""W0306"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Lading Quantity_80"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_N0"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""7"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""W0307"" type=""X12_ID_355"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Unit or Basis for Measurement Code_355"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C040"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Reference Identifier"">
          <b:Rule subjects=""X12ConditionDesignatorX_Paired"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
            <b:Subject name=""C04003"" />
            <b:Subject name=""C04004"" />
          </b:Rule>
          <b:Rule subjects=""X12ConditionDesignatorX_Paired"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
            <b:Subject name=""C04005"" />
            <b:Subject name=""C04006"" />
          </b:Rule>
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C04001"" type=""X12_ID_128"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Reference Identification Qualifier_128"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element name=""C04002"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Reference Identification_127"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""30"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C04003"" type=""X12_ID_128"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Reference Identification Qualifier_128"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C04004"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Reference Identification_127"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""30"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C04005"" type=""X12_ID_128"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Reference Identification Qualifier_128"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C04006"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Reference Identification_127"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""30"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C040_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Reference Identifier"">
          <b:Rule subjects=""X12ConditionDesignatorX_Paired"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
            <b:Subject name=""C04003"" />
            <b:Subject name=""C04004"" />
          </b:Rule>
          <b:Rule subjects=""X12ConditionDesignatorX_Paired"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
            <b:Subject name=""C04005"" />
            <b:Subject name=""C04006"" />
          </b:Rule>
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C04001"" type=""X12_ID_128"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Reference Identification Qualifier_128"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element name=""C04002"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Reference Identification_127"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""30"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C04003"" type=""X12_ID_128"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Reference Identification Qualifier_128"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C04004"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Reference Identification_127"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""30"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C04005"" type=""X12_ID_128"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Reference Identification Qualifier_128"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C04006"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Reference Identification_127"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""30"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C040_3"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Reference Identifier"">
          <b:Rule subjects=""X12ConditionDesignatorX_Paired"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
            <b:Subject name=""C04003"" />
            <b:Subject name=""C04004"" />
          </b:Rule>
          <b:Rule subjects=""X12ConditionDesignatorX_Paired"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
            <b:Subject name=""C04005"" />
            <b:Subject name=""C04006"" />
          </b:Rule>
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C04001"" type=""X12_ID_128"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Reference Identification Qualifier_128"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element name=""C04002"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Reference Identification_127"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""30"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C04003"" type=""X12_ID_128"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Reference Identification Qualifier_128"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C04004"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Reference Identification_127"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""30"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C04005"" type=""X12_ID_128"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Reference Identification Qualifier_128"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C04006"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Reference Identification_127"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""30"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C001"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Composite Unit of Measure"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C00101"" type=""X12_ID_355"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Unit or Basis for Measurement Code_355"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C00102"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Exponent_1018"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_R"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""15"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C00103"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Multiplier_649"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_R"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""10"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C00104"" type=""X12_ID_355"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Unit or Basis for Measurement Code_355"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C00105"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Exponent_1018"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_R"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""15"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C00106"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Multiplier_649"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_R"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""10"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C00107"" type=""X12_ID_355"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Unit or Basis for Measurement Code_355"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C00108"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Exponent_1018"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_R"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""15"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C00109"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Multiplier_649"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_R"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""10"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C00110"" type=""X12_ID_355"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Unit or Basis for Measurement Code_355"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C00111"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Exponent_1018"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_R"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""15"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C00112"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Multiplier_649"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_R"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""10"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C00113"" type=""X12_ID_355"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Unit or Basis for Measurement Code_355"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C00114"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Exponent_1018"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_R"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""15"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C00115"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Multiplier_649"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_R"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""10"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C001_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Composite Unit of Measure"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C00101"" type=""X12_ID_355"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Unit or Basis for Measurement Code_355"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C00102"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Exponent_1018"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_R"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""15"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C00103"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Multiplier_649"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_R"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""10"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C00104"" type=""X12_ID_355"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Unit or Basis for Measurement Code_355"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C00105"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Exponent_1018"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_R"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""15"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C00106"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Multiplier_649"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_R"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""10"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C00107"" type=""X12_ID_355"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Unit or Basis for Measurement Code_355"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C00108"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Exponent_1018"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_R"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""15"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C00109"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Multiplier_649"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_R"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""10"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C00110"" type=""X12_ID_355"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Unit or Basis for Measurement Code_355"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C00111"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Exponent_1018"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_R"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""15"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C00112"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Multiplier_649"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_R"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""10"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C00113"" type=""X12_ID_355"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Unit or Basis for Measurement Code_355"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C00114"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Exponent_1018"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_R"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""15"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C00115"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Multiplier_649"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_R"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""10"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C040_4"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Reference Identifier"">
          <b:Rule subjects=""X12ConditionDesignatorX_Paired"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
            <b:Subject name=""C04003"" />
            <b:Subject name=""C04004"" />
          </b:Rule>
          <b:Rule subjects=""X12ConditionDesignatorX_Paired"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
            <b:Subject name=""C04005"" />
            <b:Subject name=""C04006"" />
          </b:Rule>
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C04001"" type=""X12_ID_128"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Reference Identification Qualifier_128"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element name=""C04002"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Reference Identification_127"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""30"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C04003"" type=""X12_ID_128"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Reference Identification Qualifier_128"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C04004"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Reference Identification_127"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""30"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C04005"" type=""X12_ID_128"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Reference Identification Qualifier_128"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C04006"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Reference Identification_127"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""30"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:simpleType name=""X12_ID_514"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""A"" />
      <xs:enumeration value=""B"" />
      <xs:enumeration value=""C"" />
      <xs:enumeration value=""F"" />
      <xs:enumeration value=""J"" />
      <xs:enumeration value=""K"" />
      <xs:enumeration value=""N"" />
      <xs:enumeration value=""O"" />
      <xs:enumeration value=""P"" />
      <xs:enumeration value=""R"" />
      <xs:enumeration value=""S"" />
      <xs:enumeration value=""X"" />
      <xs:enumeration value=""Y"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""X12_ID_152"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""045"" />
      <xs:enumeration value=""15"" />
      <xs:enumeration value=""170"" />
      <xs:enumeration value=""25"" />
      <xs:enumeration value=""35"" />
      <xs:enumeration value=""45"" />
      <xs:enumeration value=""510"" />
      <xs:enumeration value=""520"" />
      <xs:enumeration value=""550"" />
      <xs:enumeration value=""555"" />
      <xs:enumeration value=""565"" />
      <xs:enumeration value=""570"" />
      <xs:enumeration value=""585"" />
      <xs:enumeration value=""665"" />
      <xs:enumeration value=""670"" />
      <xs:enumeration value=""675"" />
      <xs:enumeration value=""761"" />
      <xs:enumeration value=""A1M"" />
      <xs:enumeration value=""A3M"" />
      <xs:enumeration value=""A5M"" />
      <xs:enumeration value=""AAS"" />
      <xs:enumeration value=""AB"" />
      <xs:enumeration value=""ADL"" />
      <xs:enumeration value=""AFN"" />
      <xs:enumeration value=""AGG"" />
      <xs:enumeration value=""AGS"" />
      <xs:enumeration value=""AIB"" />
      <xs:enumeration value=""AK"" />
      <xs:enumeration value=""ALP"" />
      <xs:enumeration value=""ALT"" />
      <xs:enumeration value=""AMM"" />
      <xs:enumeration value=""ANC"" />
      <xs:enumeration value=""APD"" />
      <xs:enumeration value=""APL"" />
      <xs:enumeration value=""ARC"" />
      <xs:enumeration value=""ARG"" />
      <xs:enumeration value=""ARR"" />
      <xs:enumeration value=""ART"" />
      <xs:enumeration value=""ASY"" />
      <xs:enumeration value=""AT"" />
      <xs:enumeration value=""AUX"" />
      <xs:enumeration value=""AV"" />
      <xs:enumeration value=""AW"" />
      <xs:enumeration value=""BA"" />
      <xs:enumeration value=""BCP"" />
      <xs:enumeration value=""BKA"" />
      <xs:enumeration value=""BL"" />
      <xs:enumeration value=""BLK"" />
      <xs:enumeration value=""BLS"" />
      <xs:enumeration value=""BN"" />
      <xs:enumeration value=""BNS"" />
      <xs:enumeration value=""BOX"" />
      <xs:enumeration value=""BU2"" />
      <xs:enumeration value=""BU4"" />
      <xs:enumeration value=""BUA"" />
      <xs:enumeration value=""BW"" />
      <xs:enumeration value=""CA2"" />
      <xs:enumeration value=""CA4"" />
      <xs:enumeration value=""CAR"" />
      <xs:enumeration value=""CC"" />
      <xs:enumeration value=""CCB"" />
      <xs:enumeration value=""CCH"" />
      <xs:enumeration value=""CCS"" />
      <xs:enumeration value=""CD"" />
      <xs:enumeration value=""CDD"" />
      <xs:enumeration value=""CE"" />
      <xs:enumeration value=""CF"" />
      <xs:enumeration value=""CFC"" />
      <xs:enumeration value=""CFL"" />
      <xs:enumeration value=""CGC"" />
      <xs:enumeration value=""CGR"" />
      <xs:enumeration value=""CGT"" />
      <xs:enumeration value=""CH"" />
      <xs:enumeration value=""CHN"" />
      <xs:enumeration value=""CI"" />
      <xs:enumeration value=""CIP"" />
      <xs:enumeration value=""CIS"" />
      <xs:enumeration value=""CLN"" />
      <xs:enumeration value=""CLS"" />
      <xs:enumeration value=""CM"" />
      <xs:enumeration value=""CMD"" />
      <xs:enumeration value=""CNL"" />
      <xs:enumeration value=""CNS"" />
      <xs:enumeration value=""CO"" />
      <xs:enumeration value=""CON"" />
      <xs:enumeration value=""COR"" />
      <xs:enumeration value=""COU"" />
      <xs:enumeration value=""COV"" />
      <xs:enumeration value=""CPC"" />
      <xs:enumeration value=""CPM"" />
      <xs:enumeration value=""CR"" />
      <xs:enumeration value=""CRL"" />
      <xs:enumeration value=""CSD"" />
      <xs:enumeration value=""CSP"" />
      <xs:enumeration value=""CTL"" />
      <xs:enumeration value=""CTM"" />
      <xs:enumeration value=""CTR"" />
      <xs:enumeration value=""CUF"" />
      <xs:enumeration value=""CW"" />
      <xs:enumeration value=""CX"" />
      <xs:enumeration value=""CY"" />
      <xs:enumeration value=""DA"" />
      <xs:enumeration value=""DBL"" />
      <xs:enumeration value=""DBP"" />
      <xs:enumeration value=""DCS"" />
      <xs:enumeration value=""DDN"" />
      <xs:enumeration value=""DDP"" />
      <xs:enumeration value=""DDS"" />
      <xs:enumeration value=""DDZ"" />
      <xs:enumeration value=""DE"" />
      <xs:enumeration value=""DEL"" />
      <xs:enumeration value=""DEP"" />
      <xs:enumeration value=""DET"" />
      <xs:enumeration value=""DEZ"" />
      <xs:enumeration value=""DFD"" />
      <xs:enumeration value=""DFM"" />
      <xs:enumeration value=""DFS"" />
      <xs:enumeration value=""DIS"" />
      <xs:enumeration value=""DLP"" />
      <xs:enumeration value=""DLR"" />
      <xs:enumeration value=""DM"" />
      <xs:enumeration value=""DN"" />
      <xs:enumeration value=""DNC"" />
      <xs:enumeration value=""DNF"" />
      <xs:enumeration value=""DNT"" />
      <xs:enumeration value=""DOC"" />
      <xs:enumeration value=""DOV"" />
      <xs:enumeration value=""DPB"" />
      <xs:enumeration value=""DPD"" />
      <xs:enumeration value=""DPE"" />
      <xs:enumeration value=""DPL"" />
      <xs:enumeration value=""DPT"" />
      <xs:enumeration value=""DPU"" />
      <xs:enumeration value=""DR"" />
      <xs:enumeration value=""DRO"" />
      <xs:enumeration value=""DRU"" />
      <xs:enumeration value=""DS"" />
      <xs:enumeration value=""DSK"" />
      <xs:enumeration value=""DSM"" />
      <xs:enumeration value=""DSR"" />
      <xs:enumeration value=""DSV"" />
      <xs:enumeration value=""DT"" />
      <xs:enumeration value=""DTB"" />
      <xs:enumeration value=""DTP"" />
      <xs:enumeration value=""DTV"" />
      <xs:enumeration value=""DU"" />
      <xs:enumeration value=""DV"" />
      <xs:enumeration value=""DW"" />
      <xs:enumeration value=""DWP"" />
      <xs:enumeration value=""EAX"" />
      <xs:enumeration value=""ECR"" />
      <xs:enumeration value=""ECS"" />
      <xs:enumeration value=""ED"" />
      <xs:enumeration value=""EDD"" />
      <xs:enumeration value=""EDO"" />
      <xs:enumeration value=""EE"" />
      <xs:enumeration value=""EED"" />
      <xs:enumeration value=""EL"" />
      <xs:enumeration value=""ELS"" />
      <xs:enumeration value=""EMR"" />
      <xs:enumeration value=""EMT"" />
      <xs:enumeration value=""END"" />
      <xs:enumeration value=""EP"" />
      <xs:enumeration value=""ER"" />
      <xs:enumeration value=""ERS"" />
      <xs:enumeration value=""ERT"" />
      <xs:enumeration value=""EV"" />
      <xs:enumeration value=""EW"" />
      <xs:enumeration value=""EX"" />
      <xs:enumeration value=""EXC"" />
      <xs:enumeration value=""EXD"" />
      <xs:enumeration value=""EXL"" />
      <xs:enumeration value=""EXO"" />
      <xs:enumeration value=""EXP"" />
      <xs:enumeration value=""EXQ"" />
      <xs:enumeration value=""EXT"" />
      <xs:enumeration value=""EXU"" />
      <xs:enumeration value=""EXZ"" />
      <xs:enumeration value=""EZE"" />
      <xs:enumeration value=""FA"" />
      <xs:enumeration value=""FAK"" />
      <xs:enumeration value=""FAS"" />
      <xs:enumeration value=""FB"" />
      <xs:enumeration value=""FC"" />
      <xs:enumeration value=""FCS"" />
      <xs:enumeration value=""FD"" />
      <xs:enumeration value=""FFC"" />
      <xs:enumeration value=""FFS"" />
      <xs:enumeration value=""FG"" />
      <xs:enumeration value=""FL"" />
      <xs:enumeration value=""FLS"" />
      <xs:enumeration value=""FP"" />
      <xs:enumeration value=""FPT"" />
      <xs:enumeration value=""FR"" />
      <xs:enumeration value=""FRZ"" />
      <xs:enumeration value=""FS"" />
      <xs:enumeration value=""FST"" />
      <xs:enumeration value=""FTR"" />
      <xs:enumeration value=""GI"" />
      <xs:enumeration value=""GMS"" />
      <xs:enumeration value=""GOC"" />
      <xs:enumeration value=""GSP"" />
      <xs:enumeration value=""GSS"" />
      <xs:enumeration value=""HAL"" />
      <xs:enumeration value=""HAN"" />
      <xs:enumeration value=""HBR"" />
      <xs:enumeration value=""HDH"" />
      <xs:enumeration value=""HDW"" />
      <xs:enumeration value=""HE"" />
      <xs:enumeration value=""HEA"" />
      <xs:enumeration value=""HES"" />
      <xs:enumeration value=""HET"" />
      <xs:enumeration value=""HH"" />
      <xs:enumeration value=""HM"" />
      <xs:enumeration value=""HMA"" />
      <xs:enumeration value=""HMI"" />
      <xs:enumeration value=""HO"" />
      <xs:enumeration value=""HOL"" />
      <xs:enumeration value=""HOR"" />
      <xs:enumeration value=""HOS"" />
      <xs:enumeration value=""HOX"" />
      <xs:enumeration value=""HP"" />
      <xs:enumeration value=""HQT"" />
      <xs:enumeration value=""HR"" />
      <xs:enumeration value=""HRS"" />
      <xs:enumeration value=""HT"" />
      <xs:enumeration value=""HTI"" />
      <xs:enumeration value=""HV"" />
      <xs:enumeration value=""HW"" />
      <xs:enumeration value=""HZC"" />
      <xs:enumeration value=""HZD"" />
      <xs:enumeration value=""IB"" />
      <xs:enumeration value=""IC"" />
      <xs:enumeration value=""ID"" />
      <xs:enumeration value=""IDC"" />
      <xs:enumeration value=""IDL"" />
      <xs:enumeration value=""IIH"" />
      <xs:enumeration value=""IM"" />
      <xs:enumeration value=""IMP"" />
      <xs:enumeration value=""IMS"" />
      <xs:enumeration value=""INT"" />
      <xs:enumeration value=""IP"" />
      <xs:enumeration value=""IPU"" />
      <xs:enumeration value=""IR"" />
      <xs:enumeration value=""IS"" />
      <xs:enumeration value=""ITS"" />
      <xs:enumeration value=""JIT"" />
      <xs:enumeration value=""JLX"" />
      <xs:enumeration value=""JS"" />
      <xs:enumeration value=""KEG"" />
      <xs:enumeration value=""KMD"" />
      <xs:enumeration value=""LAB"" />
      <xs:enumeration value=""LAY"" />
      <xs:enumeration value=""LB"" />
      <xs:enumeration value=""LBL"" />
      <xs:enumeration value=""LBR"" />
      <xs:enumeration value=""LBT"" />
      <xs:enumeration value=""LC"" />
      <xs:enumeration value=""LC2"" />
      <xs:enumeration value=""LC4"" />
      <xs:enumeration value=""LCL"" />
      <xs:enumeration value=""LD"" />
      <xs:enumeration value=""LEC"" />
      <xs:enumeration value=""LF"" />
      <xs:enumeration value=""LFD"" />
      <xs:enumeration value=""LHS"" />
      <xs:enumeration value=""LIE"" />
      <xs:enumeration value=""LMD"" />
      <xs:enumeration value=""LME"" />
      <xs:enumeration value=""LN"" />
      <xs:enumeration value=""LP"" />
      <xs:enumeration value=""LPD"" />
      <xs:enumeration value=""LR"" />
      <xs:enumeration value=""LS"" />
      <xs:enumeration value=""LT"" />
      <xs:enumeration value=""LTE"" />
      <xs:enumeration value=""LTT"" />
      <xs:enumeration value=""LYC"" />
      <xs:enumeration value=""MAT"" />
      <xs:enumeration value=""MC"" />
      <xs:enumeration value=""MEN"" />
      <xs:enumeration value=""MES"" />
      <xs:enumeration value=""MET"" />
      <xs:enumeration value=""MF"" />
      <xs:enumeration value=""MIN"" />
      <xs:enumeration value=""MNS"" />
      <xs:enumeration value=""MOT"" />
      <xs:enumeration value=""MP"" />
      <xs:enumeration value=""MR"" />
      <xs:enumeration value=""MRF"" />
      <xs:enumeration value=""MSS"" />
      <xs:enumeration value=""MTE"" />
      <xs:enumeration value=""MVS"" />
      <xs:enumeration value=""NC"" />
      <xs:enumeration value=""ND"" />
      <xs:enumeration value=""NE"" />
      <xs:enumeration value=""NH"" />
      <xs:enumeration value=""NHC"" />
      <xs:enumeration value=""NHL"" />
      <xs:enumeration value=""NI"" />
      <xs:enumeration value=""NP"" />
      <xs:enumeration value=""NPR"" />
      <xs:enumeration value=""NS"" />
      <xs:enumeration value=""NSV"" />
      <xs:enumeration value=""NT"" />
      <xs:enumeration value=""NW"" />
      <xs:enumeration value=""NX"" />
      <xs:enumeration value=""OAH"" />
      <xs:enumeration value=""OBL"" />
      <xs:enumeration value=""OCA"" />
      <xs:enumeration value=""OCL"" />
      <xs:enumeration value=""OCN"" />
      <xs:enumeration value=""OCS"" />
      <xs:enumeration value=""OCV"" />
      <xs:enumeration value=""ODI"" />
      <xs:enumeration value=""OEH"" />
      <xs:enumeration value=""OFH"" />
      <xs:enumeration value=""OFU"" />
      <xs:enumeration value=""OHC"" />
      <xs:enumeration value=""OIL"" />
      <xs:enumeration value=""ONC"" />
      <xs:enumeration value=""ONS"" />
      <xs:enumeration value=""OOB"" />
      <xs:enumeration value=""OOD"" />
      <xs:enumeration value=""OOL"" />
      <xs:enumeration value=""OPR"" />
      <xs:enumeration value=""OPT"" />
      <xs:enumeration value=""OS"" />
      <xs:enumeration value=""OSB"" />
      <xs:enumeration value=""OST"" />
      <xs:enumeration value=""OTC"" />
      <xs:enumeration value=""OTD"" />
      <xs:enumeration value=""OTH"" />
      <xs:enumeration value=""OTO"" />
      <xs:enumeration value=""OTS"" />
      <xs:enumeration value=""OUC"" />
      <xs:enumeration value=""OUW"" />
      <xs:enumeration value=""OV"" />
      <xs:enumeration value=""OVR"" />
      <xs:enumeration value=""OWC"" />
      <xs:enumeration value=""OWR"" />
      <xs:enumeration value=""PAJ"" />
      <xs:enumeration value=""PAV"" />
      <xs:enumeration value=""PB"" />
      <xs:enumeration value=""PD"" />
      <xs:enumeration value=""PDS"" />
      <xs:enumeration value=""PDY"" />
      <xs:enumeration value=""PER"" />
      <xs:enumeration value=""PFH"" />
      <xs:enumeration value=""PG"" />
      <xs:enumeration value=""PHR"" />
      <xs:enumeration value=""PI"" />
      <xs:enumeration value=""PIR"" />
      <xs:enumeration value=""PMM"" />
      <xs:enumeration value=""PMR"" />
      <xs:enumeration value=""PMS"" />
      <xs:enumeration value=""PMT"" />
      <xs:enumeration value=""POC"" />
      <xs:enumeration value=""PPD"" />
      <xs:enumeration value=""PRL"" />
      <xs:enumeration value=""PRT"" />
      <xs:enumeration value=""PS"" />
      <xs:enumeration value=""PSG"" />
      <xs:enumeration value=""PSS"" />
      <xs:enumeration value=""PTS"" />
      <xs:enumeration value=""PUC"" />
      <xs:enumeration value=""PUD"" />
      <xs:enumeration value=""PUK"" />
      <xs:enumeration value=""PUP"" />
      <xs:enumeration value=""PVB"" />
      <xs:enumeration value=""PVD"" />
      <xs:enumeration value=""PVI"" />
      <xs:enumeration value=""PVL"" />
      <xs:enumeration value=""PVP"" />
      <xs:enumeration value=""PVS"" />
      <xs:enumeration value=""PVT"" />
      <xs:enumeration value=""PW"" />
      <xs:enumeration value=""PYS"" />
      <xs:enumeration value=""RA"" />
      <xs:enumeration value=""RB"" />
      <xs:enumeration value=""RC"" />
      <xs:enumeration value=""RCC"" />
      <xs:enumeration value=""RCL"" />
      <xs:enumeration value=""RDH"" />
      <xs:enumeration value=""RDR"" />
      <xs:enumeration value=""REP"" />
      <xs:enumeration value=""RES"" />
      <xs:enumeration value=""RFM"" />
      <xs:enumeration value=""RIE"" />
      <xs:enumeration value=""RLS"" />
      <xs:enumeration value=""RM"" />
      <xs:enumeration value=""RMC"" />
      <xs:enumeration value=""RMP"" />
      <xs:enumeration value=""RMS"" />
      <xs:enumeration value=""RO"" />
      <xs:enumeration value=""RPD"" />
      <xs:enumeration value=""RR"" />
      <xs:enumeration value=""RRR"" />
      <xs:enumeration value=""RS"" />
      <xs:enumeration value=""RSP"" />
      <xs:enumeration value=""RSS"" />
      <xs:enumeration value=""RSV"" />
      <xs:enumeration value=""RT"" />
      <xs:enumeration value=""RWR"" />
      <xs:enumeration value=""SAS"" />
      <xs:enumeration value=""SAT"" />
      <xs:enumeration value=""SB"" />
      <xs:enumeration value=""SC"" />
      <xs:enumeration value=""SCC"" />
      <xs:enumeration value=""SCL"" />
      <xs:enumeration value=""SD"" />
      <xs:enumeration value=""SDL"" />
      <xs:enumeration value=""SDS"" />
      <xs:enumeration value=""SE"" />
      <xs:enumeration value=""SEC"" />
      <xs:enumeration value=""SED"" />
      <xs:enumeration value=""SEE"" />
      <xs:enumeration value=""SER"" />
      <xs:enumeration value=""SEV"" />
      <xs:enumeration value=""SFB"" />
      <xs:enumeration value=""SFD"" />
      <xs:enumeration value=""SFE"" />
      <xs:enumeration value=""SFT"" />
      <xs:enumeration value=""SGL"" />
      <xs:enumeration value=""SH"" />
      <xs:enumeration value=""SHH"" />
      <xs:enumeration value=""SHL"" />
      <xs:enumeration value=""SHW"" />
      <xs:enumeration value=""SI"" />
      <xs:enumeration value=""SK"" />
      <xs:enumeration value=""SKT"" />
      <xs:enumeration value=""SLC"" />
      <xs:enumeration value=""SM"" />
      <xs:enumeration value=""SMP"" />
      <xs:enumeration value=""SMS"" />
      <xs:enumeration value=""SNM"" />
      <xs:enumeration value=""SNS"" />
      <xs:enumeration value=""SNT"" />
      <xs:enumeration value=""SOC"" />
      <xs:enumeration value=""SOL"" />
      <xs:enumeration value=""SP"" />
      <xs:enumeration value=""SPC"" />
      <xs:enumeration value=""SPR"" />
      <xs:enumeration value=""SPT"" />
      <xs:enumeration value=""SPU"" />
      <xs:enumeration value=""SR"" />
      <xs:enumeration value=""SRG"" />
      <xs:enumeration value=""SRS"" />
      <xs:enumeration value=""SSC"" />
      <xs:enumeration value=""SSN"" />
      <xs:enumeration value=""SSU"" />
      <xs:enumeration value=""ST"" />
      <xs:enumeration value=""STA"" />
      <xs:enumeration value=""STD"" />
      <xs:enumeration value=""STO"" />
      <xs:enumeration value=""STP"" />
      <xs:enumeration value=""STR"" />
      <xs:enumeration value=""SUA"" />
      <xs:enumeration value=""SUB"" />
      <xs:enumeration value=""SUP"" />
      <xs:enumeration value=""SVS"" />
      <xs:enumeration value=""SW"" />
      <xs:enumeration value=""TA"" />
      <xs:enumeration value=""TC"" />
      <xs:enumeration value=""TDC"" />
      <xs:enumeration value=""TDP"" />
      <xs:enumeration value=""TER"" />
      <xs:enumeration value=""TF"" />
      <xs:enumeration value=""TLS"" />
      <xs:enumeration value=""TMS"" />
      <xs:enumeration value=""TMV"" />
      <xs:enumeration value=""TN"" />
      <xs:enumeration value=""TOF"" />
      <xs:enumeration value=""TPS"" />
      <xs:enumeration value=""TRA"" />
      <xs:enumeration value=""TRK"" />
      <xs:enumeration value=""TRL"" />
      <xs:enumeration value=""TRM"" />
      <xs:enumeration value=""TRN"" />
      <xs:enumeration value=""TRP"" />
      <xs:enumeration value=""TRS"" />
      <xs:enumeration value=""TRT"" />
      <xs:enumeration value=""TS"" />
      <xs:enumeration value=""TSC"" />
      <xs:enumeration value=""TSP"" />
      <xs:enumeration value=""TSS"" />
      <xs:enumeration value=""TT"" />
      <xs:enumeration value=""TV"" />
      <xs:enumeration value=""UB"" />
      <xs:enumeration value=""UFC"" />
      <xs:enumeration value=""UI"" />
      <xs:enumeration value=""UL"" />
      <xs:enumeration value=""UN"" />
      <xs:enumeration value=""UP"" />
      <xs:enumeration value=""UPK"" />
      <xs:enumeration value=""UR"" />
      <xs:enumeration value=""URC"" />
      <xs:enumeration value=""US"" />
      <xs:enumeration value=""UTL"" />
      <xs:enumeration value=""VAC"" />
      <xs:enumeration value=""VAN"" />
      <xs:enumeration value=""VCL"" />
      <xs:enumeration value=""VFN"" />
      <xs:enumeration value=""VIS"" />
      <xs:enumeration value=""VN"" />
      <xs:enumeration value=""VSO"" />
      <xs:enumeration value=""VT"" />
      <xs:enumeration value=""VTS"" />
      <xs:enumeration value=""WB"" />
      <xs:enumeration value=""WBB"" />
      <xs:enumeration value=""WCT"" />
      <xs:enumeration value=""WD"" />
      <xs:enumeration value=""WDS"" />
      <xs:enumeration value=""WE"" />
      <xs:enumeration value=""WFG"" />
      <xs:enumeration value=""WH"" />
      <xs:enumeration value=""WI"" />
      <xs:enumeration value=""WM"" />
      <xs:enumeration value=""WO"" />
      <xs:enumeration value=""WRB"" />
      <xs:enumeration value=""WRI"" />
      <xs:enumeration value=""WTV"" />
      <xs:enumeration value=""WW"" />
      <xs:enumeration value=""XP"" />
      <xs:enumeration value=""XT"" />
      <xs:enumeration value=""ZZZ"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""X12_ID_891"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""01"" />
      <xs:enumeration value=""02"" />
      <xs:enumeration value=""03"" />
      <xs:enumeration value=""04"" />
      <xs:enumeration value=""05"" />
      <xs:enumeration value=""06"" />
      <xs:enumeration value=""07"" />
      <xs:enumeration value=""08"" />
      <xs:enumeration value=""09"" />
      <xs:enumeration value=""10"" />
      <xs:enumeration value=""11"" />
      <xs:enumeration value=""12"" />
      <xs:enumeration value=""13"" />
      <xs:enumeration value=""14"" />
      <xs:enumeration value=""15"" />
      <xs:enumeration value=""16"" />
      <xs:enumeration value=""17"" />
      <xs:enumeration value=""18"" />
      <xs:enumeration value=""19"" />
      <xs:enumeration value=""ZZ"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""X12_ID_640"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""01"" />
      <xs:enumeration value=""02"" />
      <xs:enumeration value=""03"" />
      <xs:enumeration value=""04"" />
      <xs:enumeration value=""05"" />
      <xs:enumeration value=""06"" />
      <xs:enumeration value=""07"" />
      <xs:enumeration value=""08"" />
      <xs:enumeration value=""09"" />
      <xs:enumeration value=""10"" />
      <xs:enumeration value=""11"" />
      <xs:enumeration value=""13"" />
      <xs:enumeration value=""14"" />
      <xs:enumeration value=""15"" />
      <xs:enumeration value=""16"" />
      <xs:enumeration value=""17"" />
      <xs:enumeration value=""18"" />
      <xs:enumeration value=""19"" />
      <xs:enumeration value=""20"" />
      <xs:enumeration value=""21"" />
      <xs:enumeration value=""22"" />
      <xs:enumeration value=""23"" />
      <xs:enumeration value=""24"" />
      <xs:enumeration value=""25"" />
      <xs:enumeration value=""26"" />
      <xs:enumeration value=""27"" />
      <xs:enumeration value=""28"" />
      <xs:enumeration value=""29"" />
      <xs:enumeration value=""30"" />
      <xs:enumeration value=""33"" />
      <xs:enumeration value=""34"" />
      <xs:enumeration value=""35"" />
      <xs:enumeration value=""36"" />
      <xs:enumeration value=""37"" />
      <xs:enumeration value=""38"" />
      <xs:enumeration value=""39"" />
      <xs:enumeration value=""3M"" />
      <xs:enumeration value=""40"" />
      <xs:enumeration value=""41"" />
      <xs:enumeration value=""60"" />
      <xs:enumeration value=""62"" />
      <xs:enumeration value=""63"" />
      <xs:enumeration value=""64"" />
      <xs:enumeration value=""65"" />
      <xs:enumeration value=""66"" />
      <xs:enumeration value=""67"" />
      <xs:enumeration value=""68"" />
      <xs:enumeration value=""69"" />
      <xs:enumeration value=""6A"" />
      <xs:enumeration value=""6C"" />
      <xs:enumeration value=""6N"" />
      <xs:enumeration value=""6R"" />
      <xs:enumeration value=""6S"" />
      <xs:enumeration value=""70"" />
      <xs:enumeration value=""71"" />
      <xs:enumeration value=""72"" />
      <xs:enumeration value=""73"" />
      <xs:enumeration value=""74"" />
      <xs:enumeration value=""75"" />
      <xs:enumeration value=""76"" />
      <xs:enumeration value=""77"" />
      <xs:enumeration value=""78"" />
      <xs:enumeration value=""79"" />
      <xs:enumeration value=""80"" />
      <xs:enumeration value=""81"" />
      <xs:enumeration value=""82"" />
      <xs:enumeration value=""83"" />
      <xs:enumeration value=""85"" />
      <xs:enumeration value=""87"" />
      <xs:enumeration value=""88"" />
      <xs:enumeration value=""91"" />
      <xs:enumeration value=""94"" />
      <xs:enumeration value=""95"" />
      <xs:enumeration value=""97"" />
      <xs:enumeration value=""98"" />
      <xs:enumeration value=""99"" />
      <xs:enumeration value=""A0"" />
      <xs:enumeration value=""A1"" />
      <xs:enumeration value=""A3"" />
      <xs:enumeration value=""A4"" />
      <xs:enumeration value=""A5"" />
      <xs:enumeration value=""A6"" />
      <xs:enumeration value=""A7"" />
      <xs:enumeration value=""AA"" />
      <xs:enumeration value=""AB"" />
      <xs:enumeration value=""AC"" />
      <xs:enumeration value=""AD"" />
      <xs:enumeration value=""AE"" />
      <xs:enumeration value=""AF"" />
      <xs:enumeration value=""AG"" />
      <xs:enumeration value=""AI"" />
      <xs:enumeration value=""AM"" />
      <xs:enumeration value=""AN"" />
      <xs:enumeration value=""AP"" />
      <xs:enumeration value=""AQ"" />
      <xs:enumeration value=""AR"" />
      <xs:enumeration value=""AS"" />
      <xs:enumeration value=""AT"" />
      <xs:enumeration value=""AV"" />
      <xs:enumeration value=""AW"" />
      <xs:enumeration value=""AZ"" />
      <xs:enumeration value=""BA"" />
      <xs:enumeration value=""BB"" />
      <xs:enumeration value=""BD"" />
      <xs:enumeration value=""BF"" />
      <xs:enumeration value=""BH"" />
      <xs:enumeration value=""BJ"" />
      <xs:enumeration value=""BK"" />
      <xs:enumeration value=""BL"" />
      <xs:enumeration value=""BM"" />
      <xs:enumeration value=""BN"" />
      <xs:enumeration value=""BO"" />
      <xs:enumeration value=""BP"" />
      <xs:enumeration value=""BR"" />
      <xs:enumeration value=""BS"" />
      <xs:enumeration value=""BT"" />
      <xs:enumeration value=""BU"" />
      <xs:enumeration value=""BV"" />
      <xs:enumeration value=""BW"" />
      <xs:enumeration value=""C0"" />
      <xs:enumeration value=""C1"" />
      <xs:enumeration value=""C2"" />
      <xs:enumeration value=""C3"" />
      <xs:enumeration value=""CA"" />
      <xs:enumeration value=""CB"" />
      <xs:enumeration value=""CC"" />
      <xs:enumeration value=""CD"" />
      <xs:enumeration value=""CE"" />
      <xs:enumeration value=""CF"" />
      <xs:enumeration value=""CG"" />
      <xs:enumeration value=""CH"" />
      <xs:enumeration value=""CI"" />
      <xs:enumeration value=""CJ"" />
      <xs:enumeration value=""CK"" />
      <xs:enumeration value=""CL"" />
      <xs:enumeration value=""CM"" />
      <xs:enumeration value=""CN"" />
      <xs:enumeration value=""CO"" />
      <xs:enumeration value=""CP"" />
      <xs:enumeration value=""CR"" />
      <xs:enumeration value=""CS"" />
      <xs:enumeration value=""CT"" />
      <xs:enumeration value=""CU"" />
      <xs:enumeration value=""CV"" />
      <xs:enumeration value=""CW"" />
      <xs:enumeration value=""CX"" />
      <xs:enumeration value=""CY"" />
      <xs:enumeration value=""CZ"" />
      <xs:enumeration value=""D1"" />
      <xs:enumeration value=""D4"" />
      <xs:enumeration value=""DA"" />
      <xs:enumeration value=""DB"" />
      <xs:enumeration value=""DC"" />
      <xs:enumeration value=""DD"" />
      <xs:enumeration value=""DE"" />
      <xs:enumeration value=""DF"" />
      <xs:enumeration value=""DG"" />
      <xs:enumeration value=""DH"" />
      <xs:enumeration value=""DI"" />
      <xs:enumeration value=""DK"" />
      <xs:enumeration value=""DL"" />
      <xs:enumeration value=""DN"" />
      <xs:enumeration value=""DO"" />
      <xs:enumeration value=""DP"" />
      <xs:enumeration value=""DQ"" />
      <xs:enumeration value=""DR"" />
      <xs:enumeration value=""DS"" />
      <xs:enumeration value=""DT"" />
      <xs:enumeration value=""DU"" />
      <xs:enumeration value=""EA"" />
      <xs:enumeration value=""EB"" />
      <xs:enumeration value=""EF"" />
      <xs:enumeration value=""EI"" />
      <xs:enumeration value=""EM"" />
      <xs:enumeration value=""EP"" />
      <xs:enumeration value=""ER"" />
      <xs:enumeration value=""EX"" />
      <xs:enumeration value=""FA"" />
      <xs:enumeration value=""FB"" />
      <xs:enumeration value=""FC"" />
      <xs:enumeration value=""FD"" />
      <xs:enumeration value=""FE"" />
      <xs:enumeration value=""FF"" />
      <xs:enumeration value=""FG"" />
      <xs:enumeration value=""FI"" />
      <xs:enumeration value=""FL"" />
      <xs:enumeration value=""FM"" />
      <xs:enumeration value=""FN"" />
      <xs:enumeration value=""FP"" />
      <xs:enumeration value=""FR"" />
      <xs:enumeration value=""FS"" />
      <xs:enumeration value=""FT"" />
      <xs:enumeration value=""GA"" />
      <xs:enumeration value=""GI"" />
      <xs:enumeration value=""GR"" />
      <xs:enumeration value=""HP"" />
      <xs:enumeration value=""I1"" />
      <xs:enumeration value=""IA"" />
      <xs:enumeration value=""IB"" />
      <xs:enumeration value=""IC"" />
      <xs:enumeration value=""ID"" />
      <xs:enumeration value=""IE"" />
      <xs:enumeration value=""IF"" />
      <xs:enumeration value=""II"" />
      <xs:enumeration value=""IM"" />
      <xs:enumeration value=""IN"" />
      <xs:enumeration value=""IO"" />
      <xs:enumeration value=""IR"" />
      <xs:enumeration value=""IU"" />
      <xs:enumeration value=""IW"" />
      <xs:enumeration value=""IX"" />
      <xs:enumeration value=""IZ"" />
      <xs:enumeration value=""JM"" />
      <xs:enumeration value=""JO"" />
      <xs:enumeration value=""JR"" />
      <xs:enumeration value=""JS"" />
      <xs:enumeration value=""JU"" />
      <xs:enumeration value=""JX"" />
      <xs:enumeration value=""KB"" />
      <xs:enumeration value=""KC"" />
      <xs:enumeration value=""KD"" />
      <xs:enumeration value=""KE"" />
      <xs:enumeration value=""KF"" />
      <xs:enumeration value=""KG"" />
      <xs:enumeration value=""KH"" />
      <xs:enumeration value=""KI"" />
      <xs:enumeration value=""KJ"" />
      <xs:enumeration value=""KK"" />
      <xs:enumeration value=""KL"" />
      <xs:enumeration value=""KM"" />
      <xs:enumeration value=""KN"" />
      <xs:enumeration value=""KS"" />
      <xs:enumeration value=""KT"" />
      <xs:enumeration value=""LC"" />
      <xs:enumeration value=""LD"" />
      <xs:enumeration value=""LE"" />
      <xs:enumeration value=""LF"" />
      <xs:enumeration value=""LN"" />
      <xs:enumeration value=""LO"" />
      <xs:enumeration value=""LP"" />
      <xs:enumeration value=""LR"" />
      <xs:enumeration value=""LV"" />
      <xs:enumeration value=""M1"" />
      <xs:enumeration value=""MA"" />
      <xs:enumeration value=""MB"" />
      <xs:enumeration value=""MC"" />
      <xs:enumeration value=""MD"" />
      <xs:enumeration value=""ME"" />
      <xs:enumeration value=""MF"" />
      <xs:enumeration value=""MI"" />
      <xs:enumeration value=""ML"" />
      <xs:enumeration value=""MM"" />
      <xs:enumeration value=""MP"" />
      <xs:enumeration value=""MR"" />
      <xs:enumeration value=""MS"" />
      <xs:enumeration value=""MU"" />
      <xs:enumeration value=""N1"" />
      <xs:enumeration value=""N2"" />
      <xs:enumeration value=""N3"" />
      <xs:enumeration value=""N4"" />
      <xs:enumeration value=""N5"" />
      <xs:enumeration value=""N6"" />
      <xs:enumeration value=""N7"" />
      <xs:enumeration value=""N8"" />
      <xs:enumeration value=""NA"" />
      <xs:enumeration value=""NB"" />
      <xs:enumeration value=""NC"" />
      <xs:enumeration value=""ND"" />
      <xs:enumeration value=""NE"" />
      <xs:enumeration value=""NF"" />
      <xs:enumeration value=""NG"" />
      <xs:enumeration value=""NH"" />
      <xs:enumeration value=""NI"" />
      <xs:enumeration value=""NJ"" />
      <xs:enumeration value=""NK"" />
      <xs:enumeration value=""NL"" />
      <xs:enumeration value=""NM"" />
      <xs:enumeration value=""NO"" />
      <xs:enumeration value=""NP"" />
      <xs:enumeration value=""NQ"" />
      <xs:enumeration value=""NR"" />
      <xs:enumeration value=""NT"" />
      <xs:enumeration value=""NU"" />
      <xs:enumeration value=""OC"" />
      <xs:enumeration value=""OF"" />
      <xs:enumeration value=""OP"" />
      <xs:enumeration value=""OR"" />
      <xs:enumeration value=""P1"" />
      <xs:enumeration value=""PA"" />
      <xs:enumeration value=""PB"" />
      <xs:enumeration value=""PC"" />
      <xs:enumeration value=""PD"" />
      <xs:enumeration value=""PE"" />
      <xs:enumeration value=""PF"" />
      <xs:enumeration value=""PG"" />
      <xs:enumeration value=""PI"" />
      <xs:enumeration value=""PL"" />
      <xs:enumeration value=""PM"" />
      <xs:enumeration value=""PO"" />
      <xs:enumeration value=""PP"" />
      <xs:enumeration value=""PR"" />
      <xs:enumeration value=""PS"" />
      <xs:enumeration value=""PT"" />
      <xs:enumeration value=""PU"" />
      <xs:enumeration value=""PV"" />
      <xs:enumeration value=""PW"" />
      <xs:enumeration value=""PX"" />
      <xs:enumeration value=""PZ"" />
      <xs:enumeration value=""QA"" />
      <xs:enumeration value=""QB"" />
      <xs:enumeration value=""QC"" />
      <xs:enumeration value=""QD"" />
      <xs:enumeration value=""QE"" />
      <xs:enumeration value=""QF"" />
      <xs:enumeration value=""QG"" />
      <xs:enumeration value=""QH"" />
      <xs:enumeration value=""QJ"" />
      <xs:enumeration value=""QK"" />
      <xs:enumeration value=""QL"" />
      <xs:enumeration value=""QP"" />
      <xs:enumeration value=""QR"" />
      <xs:enumeration value=""R1"" />
      <xs:enumeration value=""R2"" />
      <xs:enumeration value=""R3"" />
      <xs:enumeration value=""R4"" />
      <xs:enumeration value=""R5"" />
      <xs:enumeration value=""R6"" />
      <xs:enumeration value=""R7"" />
      <xs:enumeration value=""R8"" />
      <xs:enumeration value=""RA"" />
      <xs:enumeration value=""RB"" />
      <xs:enumeration value=""RC"" />
      <xs:enumeration value=""RD"" />
      <xs:enumeration value=""RE"" />
      <xs:enumeration value=""RF"" />
      <xs:enumeration value=""RG"" />
      <xs:enumeration value=""RH"" />
      <xs:enumeration value=""RK"" />
      <xs:enumeration value=""RM"" />
      <xs:enumeration value=""RP"" />
      <xs:enumeration value=""RQ"" />
      <xs:enumeration value=""RS"" />
      <xs:enumeration value=""RT"" />
      <xs:enumeration value=""RU"" />
      <xs:enumeration value=""RZ"" />
      <xs:enumeration value=""S1"" />
      <xs:enumeration value=""S2"" />
      <xs:enumeration value=""S3"" />
      <xs:enumeration value=""S4"" />
      <xs:enumeration value=""SA"" />
      <xs:enumeration value=""SB"" />
      <xs:enumeration value=""SC"" />
      <xs:enumeration value=""SD"" />
      <xs:enumeration value=""SE"" />
      <xs:enumeration value=""SF"" />
      <xs:enumeration value=""SG"" />
      <xs:enumeration value=""SH"" />
      <xs:enumeration value=""SL"" />
      <xs:enumeration value=""SM"" />
      <xs:enumeration value=""SO"" />
      <xs:enumeration value=""SP"" />
      <xs:enumeration value=""SQ"" />
      <xs:enumeration value=""SR"" />
      <xs:enumeration value=""SS"" />
      <xs:enumeration value=""ST"" />
      <xs:enumeration value=""SU"" />
      <xs:enumeration value=""SV"" />
      <xs:enumeration value=""TD"" />
      <xs:enumeration value=""TG"" />
      <xs:enumeration value=""TH"" />
      <xs:enumeration value=""TI"" />
      <xs:enumeration value=""TJ"" />
      <xs:enumeration value=""TK"" />
      <xs:enumeration value=""TP"" />
      <xs:enumeration value=""TR"" />
      <xs:enumeration value=""TS"" />
      <xs:enumeration value=""TT"" />
      <xs:enumeration value=""TX"" />
      <xs:enumeration value=""U1"" />
      <xs:enumeration value=""U2"" />
      <xs:enumeration value=""U4"" />
      <xs:enumeration value=""U5"" />
      <xs:enumeration value=""U9"" />
      <xs:enumeration value=""UA"" />
      <xs:enumeration value=""UC"" />
      <xs:enumeration value=""UD"" />
      <xs:enumeration value=""UF"" />
      <xs:enumeration value=""UI"" />
      <xs:enumeration value=""UM"" />
      <xs:enumeration value=""UO"" />
      <xs:enumeration value=""UP"" />
      <xs:enumeration value=""UR"" />
      <xs:enumeration value=""UT"" />
      <xs:enumeration value=""V1"" />
      <xs:enumeration value=""VH"" />
      <xs:enumeration value=""VJ"" />
      <xs:enumeration value=""VL"" />
      <xs:enumeration value=""VM"" />
      <xs:enumeration value=""VN"" />
      <xs:enumeration value=""VO"" />
      <xs:enumeration value=""VP"" />
      <xs:enumeration value=""VQ"" />
      <xs:enumeration value=""VR"" />
      <xs:enumeration value=""W1"" />
      <xs:enumeration value=""W4"" />
      <xs:enumeration value=""W5"" />
      <xs:enumeration value=""WA"" />
      <xs:enumeration value=""WC"" />
      <xs:enumeration value=""WD"" />
      <xs:enumeration value=""WH"" />
      <xs:enumeration value=""WO"" />
      <xs:enumeration value=""WS"" />
      <xs:enumeration value=""WT"" />
      <xs:enumeration value=""X1"" />
      <xs:enumeration value=""XA"" />
      <xs:enumeration value=""XB"" />
      <xs:enumeration value=""XC"" />
      <xs:enumeration value=""XD"" />
      <xs:enumeration value=""XX"" />
      <xs:enumeration value=""XY"" />
      <xs:enumeration value=""XZ"" />
      <xs:enumeration value=""YI"" />
      <xs:enumeration value=""YR"" />
      <xs:enumeration value=""ZA"" />
      <xs:enumeration value=""ZB"" />
      <xs:enumeration value=""ZC"" />
      <xs:enumeration value=""ZD"" />
      <xs:enumeration value=""ZE"" />
      <xs:enumeration value=""ZF"" />
      <xs:enumeration value=""ZG"" />
      <xs:enumeration value=""ZH"" />
      <xs:enumeration value=""ZI"" />
      <xs:enumeration value=""ZJ"" />
      <xs:enumeration value=""ZK"" />
      <xs:enumeration value=""ZL"" />
      <xs:enumeration value=""ZM"" />
      <xs:enumeration value=""ZN"" />
      <xs:enumeration value=""ZO"" />
      <xs:enumeration value=""ZP"" />
      <xs:enumeration value=""ZQ"" />
      <xs:enumeration value=""ZR"" />
      <xs:enumeration value=""ZS"" />
      <xs:enumeration value=""ZT"" />
      <xs:enumeration value=""ZU"" />
      <xs:enumeration value=""ZW"" />
      <xs:enumeration value=""ZZ"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""X12_ID_306"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""1"" />
      <xs:enumeration value=""10"" />
      <xs:enumeration value=""11"" />
      <xs:enumeration value=""12"" />
      <xs:enumeration value=""13"" />
      <xs:enumeration value=""14"" />
      <xs:enumeration value=""15"" />
      <xs:enumeration value=""16"" />
      <xs:enumeration value=""17"" />
      <xs:enumeration value=""18"" />
      <xs:enumeration value=""19"" />
      <xs:enumeration value=""2"" />
      <xs:enumeration value=""20"" />
      <xs:enumeration value=""21"" />
      <xs:enumeration value=""22"" />
      <xs:enumeration value=""23"" />
      <xs:enumeration value=""24"" />
      <xs:enumeration value=""25"" />
      <xs:enumeration value=""26"" />
      <xs:enumeration value=""27"" />
      <xs:enumeration value=""28"" />
      <xs:enumeration value=""29"" />
      <xs:enumeration value=""3"" />
      <xs:enumeration value=""30"" />
      <xs:enumeration value=""31"" />
      <xs:enumeration value=""32"" />
      <xs:enumeration value=""34"" />
      <xs:enumeration value=""35"" />
      <xs:enumeration value=""36"" />
      <xs:enumeration value=""37"" />
      <xs:enumeration value=""38"" />
      <xs:enumeration value=""39"" />
      <xs:enumeration value=""4"" />
      <xs:enumeration value=""40"" />
      <xs:enumeration value=""41"" />
      <xs:enumeration value=""42"" />
      <xs:enumeration value=""43"" />
      <xs:enumeration value=""44"" />
      <xs:enumeration value=""45"" />
      <xs:enumeration value=""46"" />
      <xs:enumeration value=""47"" />
      <xs:enumeration value=""48"" />
      <xs:enumeration value=""49"" />
      <xs:enumeration value=""5"" />
      <xs:enumeration value=""50"" />
      <xs:enumeration value=""51"" />
      <xs:enumeration value=""52"" />
      <xs:enumeration value=""53"" />
      <xs:enumeration value=""54"" />
      <xs:enumeration value=""55"" />
      <xs:enumeration value=""56"" />
      <xs:enumeration value=""57"" />
      <xs:enumeration value=""58"" />
      <xs:enumeration value=""59"" />
      <xs:enumeration value=""6"" />
      <xs:enumeration value=""60"" />
      <xs:enumeration value=""61"" />
      <xs:enumeration value=""62"" />
      <xs:enumeration value=""63"" />
      <xs:enumeration value=""64"" />
      <xs:enumeration value=""65"" />
      <xs:enumeration value=""66"" />
      <xs:enumeration value=""67"" />
      <xs:enumeration value=""68"" />
      <xs:enumeration value=""69"" />
      <xs:enumeration value=""7"" />
      <xs:enumeration value=""70"" />
      <xs:enumeration value=""71"" />
      <xs:enumeration value=""72"" />
      <xs:enumeration value=""73"" />
      <xs:enumeration value=""74"" />
      <xs:enumeration value=""75"" />
      <xs:enumeration value=""76"" />
      <xs:enumeration value=""77"" />
      <xs:enumeration value=""78"" />
      <xs:enumeration value=""79"" />
      <xs:enumeration value=""8"" />
      <xs:enumeration value=""80"" />
      <xs:enumeration value=""81"" />
      <xs:enumeration value=""82"" />
      <xs:enumeration value=""83"" />
      <xs:enumeration value=""84"" />
      <xs:enumeration value=""85"" />
      <xs:enumeration value=""86"" />
      <xs:enumeration value=""87"" />
      <xs:enumeration value=""88"" />
      <xs:enumeration value=""89"" />
      <xs:enumeration value=""9"" />
      <xs:enumeration value=""90"" />
      <xs:enumeration value=""A"" />
      <xs:enumeration value=""A1"" />
      <xs:enumeration value=""A2"" />
      <xs:enumeration value=""A3"" />
      <xs:enumeration value=""A4"" />
      <xs:enumeration value=""A5"" />
      <xs:enumeration value=""A6"" />
      <xs:enumeration value=""AA"" />
      <xs:enumeration value=""AB"" />
      <xs:enumeration value=""AC"" />
      <xs:enumeration value=""AD"" />
      <xs:enumeration value=""AE"" />
      <xs:enumeration value=""AF"" />
      <xs:enumeration value=""AG"" />
      <xs:enumeration value=""AH"" />
      <xs:enumeration value=""AI"" />
      <xs:enumeration value=""AJ"" />
      <xs:enumeration value=""AL"" />
      <xs:enumeration value=""AP"" />
      <xs:enumeration value=""AQ"" />
      <xs:enumeration value=""AR"" />
      <xs:enumeration value=""AS"" />
      <xs:enumeration value=""AT"" />
      <xs:enumeration value=""AV"" />
      <xs:enumeration value=""AW"" />
      <xs:enumeration value=""AX"" />
      <xs:enumeration value=""B"" />
      <xs:enumeration value=""BD"" />
      <xs:enumeration value=""BI"" />
      <xs:enumeration value=""BO"" />
      <xs:enumeration value=""C"" />
      <xs:enumeration value=""C1"" />
      <xs:enumeration value=""C2"" />
      <xs:enumeration value=""CA"" />
      <xs:enumeration value=""CB"" />
      <xs:enumeration value=""CC"" />
      <xs:enumeration value=""CD"" />
      <xs:enumeration value=""CE"" />
      <xs:enumeration value=""CF"" />
      <xs:enumeration value=""CG"" />
      <xs:enumeration value=""CL"" />
      <xs:enumeration value=""CM"" />
      <xs:enumeration value=""CN"" />
      <xs:enumeration value=""CO"" />
      <xs:enumeration value=""CP"" />
      <xs:enumeration value=""CS"" />
      <xs:enumeration value=""CT"" />
      <xs:enumeration value=""CU"" />
      <xs:enumeration value=""CV"" />
      <xs:enumeration value=""CX"" />
      <xs:enumeration value=""D"" />
      <xs:enumeration value=""D1"" />
      <xs:enumeration value=""D2"" />
      <xs:enumeration value=""DA"" />
      <xs:enumeration value=""DB"" />
      <xs:enumeration value=""DC"" />
      <xs:enumeration value=""DD"" />
      <xs:enumeration value=""DE"" />
      <xs:enumeration value=""DF"" />
      <xs:enumeration value=""DG"" />
      <xs:enumeration value=""DH"" />
      <xs:enumeration value=""DI"" />
      <xs:enumeration value=""DJ"" />
      <xs:enumeration value=""DK"" />
      <xs:enumeration value=""DL"" />
      <xs:enumeration value=""DP"" />
      <xs:enumeration value=""DR"" />
      <xs:enumeration value=""DS"" />
      <xs:enumeration value=""DT"" />
      <xs:enumeration value=""DX"" />
      <xs:enumeration value=""E"" />
      <xs:enumeration value=""EA"" />
      <xs:enumeration value=""EB"" />
      <xs:enumeration value=""EC"" />
      <xs:enumeration value=""ED"" />
      <xs:enumeration value=""EE"" />
      <xs:enumeration value=""EN"" />
      <xs:enumeration value=""EP"" />
      <xs:enumeration value=""ER"" />
      <xs:enumeration value=""EV"" />
      <xs:enumeration value=""EX"" />
      <xs:enumeration value=""F"" />
      <xs:enumeration value=""F1"" />
      <xs:enumeration value=""FA"" />
      <xs:enumeration value=""FC"" />
      <xs:enumeration value=""FI"" />
      <xs:enumeration value=""FO"" />
      <xs:enumeration value=""FR"" />
      <xs:enumeration value=""G"" />
      <xs:enumeration value=""GR"" />
      <xs:enumeration value=""H"" />
      <xs:enumeration value=""HR"" />
      <xs:enumeration value=""I"" />
      <xs:enumeration value=""I1"" />
      <xs:enumeration value=""IA"" />
      <xs:enumeration value=""IM"" />
      <xs:enumeration value=""IN"" />
      <xs:enumeration value=""IS"" />
      <xs:enumeration value=""IT"" />
      <xs:enumeration value=""J"" />
      <xs:enumeration value=""JA"" />
      <xs:enumeration value=""JO"" />
      <xs:enumeration value=""JU"" />
      <xs:enumeration value=""K"" />
      <xs:enumeration value=""KA"" />
      <xs:enumeration value=""L"" />
      <xs:enumeration value=""LC"" />
      <xs:enumeration value=""LQ"" />
      <xs:enumeration value=""M"" />
      <xs:enumeration value=""ME"" />
      <xs:enumeration value=""MO"" />
      <xs:enumeration value=""N"" />
      <xs:enumeration value=""NA"" />
      <xs:enumeration value=""ND"" />
      <xs:enumeration value=""NP"" />
      <xs:enumeration value=""NS"" />
      <xs:enumeration value=""O"" />
      <xs:enumeration value=""OD"" />
      <xs:enumeration value=""OP"" />
      <xs:enumeration value=""OR"" />
      <xs:enumeration value=""OT"" />
      <xs:enumeration value=""P"" />
      <xs:enumeration value=""P1"" />
      <xs:enumeration value=""PA"" />
      <xs:enumeration value=""PB"" />
      <xs:enumeration value=""PC"" />
      <xs:enumeration value=""PD"" />
      <xs:enumeration value=""PF"" />
      <xs:enumeration value=""PI"" />
      <xs:enumeration value=""PJ"" />
      <xs:enumeration value=""PO"" />
      <xs:enumeration value=""PP"" />
      <xs:enumeration value=""PR"" />
      <xs:enumeration value=""PS"" />
      <xs:enumeration value=""PT"" />
      <xs:enumeration value=""PU"" />
      <xs:enumeration value=""PV"" />
      <xs:enumeration value=""Q"" />
      <xs:enumeration value=""R"" />
      <xs:enumeration value=""R1"" />
      <xs:enumeration value=""R2"" />
      <xs:enumeration value=""R3"" />
      <xs:enumeration value=""R4"" />
      <xs:enumeration value=""R5"" />
      <xs:enumeration value=""R6"" />
      <xs:enumeration value=""R7"" />
      <xs:enumeration value=""R8"" />
      <xs:enumeration value=""R9"" />
      <xs:enumeration value=""RA"" />
      <xs:enumeration value=""RB"" />
      <xs:enumeration value=""RC"" />
      <xs:enumeration value=""RD"" />
      <xs:enumeration value=""RE"" />
      <xs:enumeration value=""RF"" />
      <xs:enumeration value=""RG"" />
      <xs:enumeration value=""RH"" />
      <xs:enumeration value=""RI"" />
      <xs:enumeration value=""RJ"" />
      <xs:enumeration value=""RK"" />
      <xs:enumeration value=""RL"" />
      <xs:enumeration value=""RM"" />
      <xs:enumeration value=""RN"" />
      <xs:enumeration value=""RO"" />
      <xs:enumeration value=""RP"" />
      <xs:enumeration value=""RQ"" />
      <xs:enumeration value=""RR"" />
      <xs:enumeration value=""RS"" />
      <xs:enumeration value=""RT"" />
      <xs:enumeration value=""RU"" />
      <xs:enumeration value=""RV"" />
      <xs:enumeration value=""RW"" />
      <xs:enumeration value=""RX"" />
      <xs:enumeration value=""S"" />
      <xs:enumeration value=""S1"" />
      <xs:enumeration value=""S2"" />
      <xs:enumeration value=""SA"" />
      <xs:enumeration value=""SB"" />
      <xs:enumeration value=""SC"" />
      <xs:enumeration value=""SD"" />
      <xs:enumeration value=""SE"" />
      <xs:enumeration value=""SL"" />
      <xs:enumeration value=""SR"" />
      <xs:enumeration value=""SS"" />
      <xs:enumeration value=""SU"" />
      <xs:enumeration value=""SV"" />
      <xs:enumeration value=""SZ"" />
      <xs:enumeration value=""T"" />
      <xs:enumeration value=""TD"" />
      <xs:enumeration value=""TE"" />
      <xs:enumeration value=""TG"" />
      <xs:enumeration value=""TN"" />
      <xs:enumeration value=""TP"" />
      <xs:enumeration value=""TR"" />
      <xs:enumeration value=""TS"" />
      <xs:enumeration value=""TU"" />
      <xs:enumeration value=""U"" />
      <xs:enumeration value=""V"" />
      <xs:enumeration value=""VA"" />
      <xs:enumeration value=""W"" />
      <xs:enumeration value=""W1"" />
      <xs:enumeration value=""WD"" />
      <xs:enumeration value=""WI"" />
      <xs:enumeration value=""WQ"" />
      <xs:enumeration value=""WV"" />
      <xs:enumeration value=""X"" />
      <xs:enumeration value=""Y"" />
      <xs:enumeration value=""Z"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""X12_ID_98"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""001"" />
      <xs:enumeration value=""002"" />
      <xs:enumeration value=""003"" />
      <xs:enumeration value=""004"" />
      <xs:enumeration value=""005"" />
      <xs:enumeration value=""006"" />
      <xs:enumeration value=""007"" />
      <xs:enumeration value=""01"" />
      <xs:enumeration value=""02"" />
      <xs:enumeration value=""03"" />
      <xs:enumeration value=""04"" />
      <xs:enumeration value=""05"" />
      <xs:enumeration value=""06"" />
      <xs:enumeration value=""07"" />
      <xs:enumeration value=""08"" />
      <xs:enumeration value=""09"" />
      <xs:enumeration value=""0A"" />
      <xs:enumeration value=""0B"" />
      <xs:enumeration value=""0D"" />
      <xs:enumeration value=""0E"" />
      <xs:enumeration value=""0F"" />
      <xs:enumeration value=""0H"" />
      <xs:enumeration value=""10"" />
      <xs:enumeration value=""11"" />
      <xs:enumeration value=""12"" />
      <xs:enumeration value=""13"" />
      <xs:enumeration value=""14"" />
      <xs:enumeration value=""15"" />
      <xs:enumeration value=""16"" />
      <xs:enumeration value=""17"" />
      <xs:enumeration value=""18"" />
      <xs:enumeration value=""19"" />
      <xs:enumeration value=""1A"" />
      <xs:enumeration value=""1B"" />
      <xs:enumeration value=""1C"" />
      <xs:enumeration value=""1D"" />
      <xs:enumeration value=""1E"" />
      <xs:enumeration value=""1F"" />
      <xs:enumeration value=""1G"" />
      <xs:enumeration value=""1H"" />
      <xs:enumeration value=""1I"" />
      <xs:enumeration value=""1J"" />
      <xs:enumeration value=""1K"" />
      <xs:enumeration value=""1L"" />
      <xs:enumeration value=""1M"" />
      <xs:enumeration value=""1N"" />
      <xs:enumeration value=""1O"" />
      <xs:enumeration value=""1P"" />
      <xs:enumeration value=""1Q"" />
      <xs:enumeration value=""1R"" />
      <xs:enumeration value=""1S"" />
      <xs:enumeration value=""1T"" />
      <xs:enumeration value=""1U"" />
      <xs:enumeration value=""1V"" />
      <xs:enumeration value=""1W"" />
      <xs:enumeration value=""1X"" />
      <xs:enumeration value=""1Y"" />
      <xs:enumeration value=""1Z"" />
      <xs:enumeration value=""20"" />
      <xs:enumeration value=""21"" />
      <xs:enumeration value=""22"" />
      <xs:enumeration value=""23"" />
      <xs:enumeration value=""24"" />
      <xs:enumeration value=""25"" />
      <xs:enumeration value=""26"" />
      <xs:enumeration value=""27"" />
      <xs:enumeration value=""28"" />
      <xs:enumeration value=""29"" />
      <xs:enumeration value=""2A"" />
      <xs:enumeration value=""2B"" />
      <xs:enumeration value=""2C"" />
      <xs:enumeration value=""2D"" />
      <xs:enumeration value=""2E"" />
      <xs:enumeration value=""2F"" />
      <xs:enumeration value=""2G"" />
      <xs:enumeration value=""2H"" />
      <xs:enumeration value=""2I"" />
      <xs:enumeration value=""2J"" />
      <xs:enumeration value=""2K"" />
      <xs:enumeration value=""2L"" />
      <xs:enumeration value=""2M"" />
      <xs:enumeration value=""2N"" />
      <xs:enumeration value=""2O"" />
      <xs:enumeration value=""2P"" />
      <xs:enumeration value=""2Q"" />
      <xs:enumeration value=""2R"" />
      <xs:enumeration value=""2S"" />
      <xs:enumeration value=""2T"" />
      <xs:enumeration value=""2U"" />
      <xs:enumeration value=""2V"" />
      <xs:enumeration value=""2W"" />
      <xs:enumeration value=""2X"" />
      <xs:enumeration value=""2Y"" />
      <xs:enumeration value=""2Z"" />
      <xs:enumeration value=""30"" />
      <xs:enumeration value=""31"" />
      <xs:enumeration value=""32"" />
      <xs:enumeration value=""33"" />
      <xs:enumeration value=""34"" />
      <xs:enumeration value=""35"" />
      <xs:enumeration value=""36"" />
      <xs:enumeration value=""37"" />
      <xs:enumeration value=""38"" />
      <xs:enumeration value=""39"" />
      <xs:enumeration value=""3A"" />
      <xs:enumeration value=""3B"" />
      <xs:enumeration value=""3C"" />
      <xs:enumeration value=""3D"" />
      <xs:enumeration value=""3E"" />
      <xs:enumeration value=""3F"" />
      <xs:enumeration value=""3G"" />
      <xs:enumeration value=""3H"" />
      <xs:enumeration value=""3I"" />
      <xs:enumeration value=""3J"" />
      <xs:enumeration value=""3K"" />
      <xs:enumeration value=""3L"" />
      <xs:enumeration value=""3M"" />
      <xs:enumeration value=""3N"" />
      <xs:enumeration value=""3O"" />
      <xs:enumeration value=""3P"" />
      <xs:enumeration value=""3Q"" />
      <xs:enumeration value=""3R"" />
      <xs:enumeration value=""3S"" />
      <xs:enumeration value=""3T"" />
      <xs:enumeration value=""3U"" />
      <xs:enumeration value=""3V"" />
      <xs:enumeration value=""3W"" />
      <xs:enumeration value=""3X"" />
      <xs:enumeration value=""3Y"" />
      <xs:enumeration value=""3Z"" />
      <xs:enumeration value=""40"" />
      <xs:enumeration value=""41"" />
      <xs:enumeration value=""42"" />
      <xs:enumeration value=""43"" />
      <xs:enumeration value=""44"" />
      <xs:enumeration value=""45"" />
      <xs:enumeration value=""46"" />
      <xs:enumeration value=""47"" />
      <xs:enumeration value=""48"" />
      <xs:enumeration value=""49"" />
      <xs:enumeration value=""4A"" />
      <xs:enumeration value=""4B"" />
      <xs:enumeration value=""4C"" />
      <xs:enumeration value=""4D"" />
      <xs:enumeration value=""4E"" />
      <xs:enumeration value=""4F"" />
      <xs:enumeration value=""4G"" />
      <xs:enumeration value=""4H"" />
      <xs:enumeration value=""4I"" />
      <xs:enumeration value=""4J"" />
      <xs:enumeration value=""4K"" />
      <xs:enumeration value=""4L"" />
      <xs:enumeration value=""4M"" />
      <xs:enumeration value=""4N"" />
      <xs:enumeration value=""4O"" />
      <xs:enumeration value=""4P"" />
      <xs:enumeration value=""4Q"" />
      <xs:enumeration value=""4R"" />
      <xs:enumeration value=""4S"" />
      <xs:enumeration value=""4T"" />
      <xs:enumeration value=""4U"" />
      <xs:enumeration value=""4V"" />
      <xs:enumeration value=""4W"" />
      <xs:enumeration value=""4X"" />
      <xs:enumeration value=""4Y"" />
      <xs:enumeration value=""4Z"" />
      <xs:enumeration value=""50"" />
      <xs:enumeration value=""51"" />
      <xs:enumeration value=""52"" />
      <xs:enumeration value=""53"" />
      <xs:enumeration value=""54"" />
      <xs:enumeration value=""55"" />
      <xs:enumeration value=""56"" />
      <xs:enumeration value=""57"" />
      <xs:enumeration value=""58"" />
      <xs:enumeration value=""59"" />
      <xs:enumeration value=""5A"" />
      <xs:enumeration value=""5B"" />
      <xs:enumeration value=""5C"" />
      <xs:enumeration value=""5D"" />
      <xs:enumeration value=""5E"" />
      <xs:enumeration value=""5F"" />
      <xs:enumeration value=""5G"" />
      <xs:enumeration value=""5H"" />
      <xs:enumeration value=""5I"" />
      <xs:enumeration value=""5J"" />
      <xs:enumeration value=""5K"" />
      <xs:enumeration value=""5L"" />
      <xs:enumeration value=""5M"" />
      <xs:enumeration value=""5N"" />
      <xs:enumeration value=""5O"" />
      <xs:enumeration value=""5P"" />
      <xs:enumeration value=""5Q"" />
      <xs:enumeration value=""5R"" />
      <xs:enumeration value=""5S"" />
      <xs:enumeration value=""5T"" />
      <xs:enumeration value=""5U"" />
      <xs:enumeration value=""5V"" />
      <xs:enumeration value=""5W"" />
      <xs:enumeration value=""5X"" />
      <xs:enumeration value=""5Y"" />
      <xs:enumeration value=""5Z"" />
      <xs:enumeration value=""60"" />
      <xs:enumeration value=""61"" />
      <xs:enumeration value=""62"" />
      <xs:enumeration value=""63"" />
      <xs:enumeration value=""64"" />
      <xs:enumeration value=""65"" />
      <xs:enumeration value=""66"" />
      <xs:enumeration value=""67"" />
      <xs:enumeration value=""68"" />
      <xs:enumeration value=""69"" />
      <xs:enumeration value=""6A"" />
      <xs:enumeration value=""6B"" />
      <xs:enumeration value=""6C"" />
      <xs:enumeration value=""6D"" />
      <xs:enumeration value=""6E"" />
      <xs:enumeration value=""6F"" />
      <xs:enumeration value=""6G"" />
      <xs:enumeration value=""6H"" />
      <xs:enumeration value=""6I"" />
      <xs:enumeration value=""6J"" />
      <xs:enumeration value=""6K"" />
      <xs:enumeration value=""6L"" />
      <xs:enumeration value=""6M"" />
      <xs:enumeration value=""6N"" />
      <xs:enumeration value=""6O"" />
      <xs:enumeration value=""6P"" />
      <xs:enumeration value=""6Q"" />
      <xs:enumeration value=""6R"" />
      <xs:enumeration value=""6S"" />
      <xs:enumeration value=""6T"" />
      <xs:enumeration value=""6U"" />
      <xs:enumeration value=""6V"" />
      <xs:enumeration value=""6W"" />
      <xs:enumeration value=""6X"" />
      <xs:enumeration value=""6Y"" />
      <xs:enumeration value=""6Z"" />
      <xs:enumeration value=""70"" />
      <xs:enumeration value=""71"" />
      <xs:enumeration value=""72"" />
      <xs:enumeration value=""73"" />
      <xs:enumeration value=""74"" />
      <xs:enumeration value=""75"" />
      <xs:enumeration value=""76"" />
      <xs:enumeration value=""77"" />
      <xs:enumeration value=""78"" />
      <xs:enumeration value=""79"" />
      <xs:enumeration value=""7A"" />
      <xs:enumeration value=""7B"" />
      <xs:enumeration value=""7C"" />
      <xs:enumeration value=""7D"" />
      <xs:enumeration value=""7E"" />
      <xs:enumeration value=""7F"" />
      <xs:enumeration value=""7G"" />
      <xs:enumeration value=""7H"" />
      <xs:enumeration value=""7I"" />
      <xs:enumeration value=""7J"" />
      <xs:enumeration value=""7K"" />
      <xs:enumeration value=""7L"" />
      <xs:enumeration value=""7M"" />
      <xs:enumeration value=""7N"" />
      <xs:enumeration value=""7O"" />
      <xs:enumeration value=""7P"" />
      <xs:enumeration value=""7Q"" />
      <xs:enumeration value=""7R"" />
      <xs:enumeration value=""7S"" />
      <xs:enumeration value=""7T"" />
      <xs:enumeration value=""7U"" />
      <xs:enumeration value=""7V"" />
      <xs:enumeration value=""7W"" />
      <xs:enumeration value=""7X"" />
      <xs:enumeration value=""7Y"" />
      <xs:enumeration value=""7Z"" />
      <xs:enumeration value=""80"" />
      <xs:enumeration value=""81"" />
      <xs:enumeration value=""82"" />
      <xs:enumeration value=""83"" />
      <xs:enumeration value=""84"" />
      <xs:enumeration value=""85"" />
      <xs:enumeration value=""86"" />
      <xs:enumeration value=""87"" />
      <xs:enumeration value=""88"" />
      <xs:enumeration value=""89"" />
      <xs:enumeration value=""8A"" />
      <xs:enumeration value=""8B"" />
      <xs:enumeration value=""8C"" />
      <xs:enumeration value=""8D"" />
      <xs:enumeration value=""8E"" />
      <xs:enumeration value=""8F"" />
      <xs:enumeration value=""8G"" />
      <xs:enumeration value=""8H"" />
      <xs:enumeration value=""8I"" />
      <xs:enumeration value=""8J"" />
      <xs:enumeration value=""8K"" />
      <xs:enumeration value=""8L"" />
      <xs:enumeration value=""8M"" />
      <xs:enumeration value=""8N"" />
      <xs:enumeration value=""8O"" />
      <xs:enumeration value=""8P"" />
      <xs:enumeration value=""8Q"" />
      <xs:enumeration value=""8R"" />
      <xs:enumeration value=""8S"" />
      <xs:enumeration value=""8T"" />
      <xs:enumeration value=""8U"" />
      <xs:enumeration value=""8V"" />
      <xs:enumeration value=""8W"" />
      <xs:enumeration value=""8X"" />
      <xs:enumeration value=""8Y"" />
      <xs:enumeration value=""8Z"" />
      <xs:enumeration value=""90"" />
      <xs:enumeration value=""91"" />
      <xs:enumeration value=""92"" />
      <xs:enumeration value=""93"" />
      <xs:enumeration value=""94"" />
      <xs:enumeration value=""95"" />
      <xs:enumeration value=""96"" />
      <xs:enumeration value=""97"" />
      <xs:enumeration value=""98"" />
      <xs:enumeration value=""99"" />
      <xs:enumeration value=""9A"" />
      <xs:enumeration value=""9B"" />
      <xs:enumeration value=""9C"" />
      <xs:enumeration value=""9D"" />
      <xs:enumeration value=""9E"" />
      <xs:enumeration value=""9F"" />
      <xs:enumeration value=""9G"" />
      <xs:enumeration value=""9H"" />
      <xs:enumeration value=""9I"" />
      <xs:enumeration value=""9J"" />
      <xs:enumeration value=""9K"" />
      <xs:enumeration value=""9L"" />
      <xs:enumeration value=""9N"" />
      <xs:enumeration value=""9O"" />
      <xs:enumeration value=""9P"" />
      <xs:enumeration value=""9Q"" />
      <xs:enumeration value=""9R"" />
      <xs:enumeration value=""9S"" />
      <xs:enumeration value=""9T"" />
      <xs:enumeration value=""9U"" />
      <xs:enumeration value=""9V"" />
      <xs:enumeration value=""9W"" />
      <xs:enumeration value=""9X"" />
      <xs:enumeration value=""9Y"" />
      <xs:enumeration value=""9Z"" />
      <xs:enumeration value=""A1"" />
      <xs:enumeration value=""A2"" />
      <xs:enumeration value=""A3"" />
      <xs:enumeration value=""A4"" />
      <xs:enumeration value=""A5"" />
      <xs:enumeration value=""A6"" />
      <xs:enumeration value=""A7"" />
      <xs:enumeration value=""A8"" />
      <xs:enumeration value=""A9"" />
      <xs:enumeration value=""AA"" />
      <xs:enumeration value=""AAA"" />
      <xs:enumeration value=""AAB"" />
      <xs:enumeration value=""AAC"" />
      <xs:enumeration value=""AAD"" />
      <xs:enumeration value=""AAE"" />
      <xs:enumeration value=""AAF"" />
      <xs:enumeration value=""AAG"" />
      <xs:enumeration value=""AAH"" />
      <xs:enumeration value=""AAI"" />
      <xs:enumeration value=""AAJ"" />
      <xs:enumeration value=""AAK"" />
      <xs:enumeration value=""AAL"" />
      <xs:enumeration value=""AAM"" />
      <xs:enumeration value=""AAN"" />
      <xs:enumeration value=""AAO"" />
      <xs:enumeration value=""AAP"" />
      <xs:enumeration value=""AAQ"" />
      <xs:enumeration value=""AAS"" />
      <xs:enumeration value=""AAT"" />
      <xs:enumeration value=""AAU"" />
      <xs:enumeration value=""AAV"" />
      <xs:enumeration value=""AB"" />
      <xs:enumeration value=""ABB"" />
      <xs:enumeration value=""ABC"" />
      <xs:enumeration value=""ABD"" />
      <xs:enumeration value=""ABE"" />
      <xs:enumeration value=""ABF"" />
      <xs:enumeration value=""ABG"" />
      <xs:enumeration value=""ABH"" />
      <xs:enumeration value=""ABI"" />
      <xs:enumeration value=""ABJ"" />
      <xs:enumeration value=""ABK"" />
      <xs:enumeration value=""ABL"" />
      <xs:enumeration value=""ABM"" />
      <xs:enumeration value=""AC"" />
      <xs:enumeration value=""AD"" />
      <xs:enumeration value=""AE"" />
      <xs:enumeration value=""AF"" />
      <xs:enumeration value=""AG"" />
      <xs:enumeration value=""AH"" />
      <xs:enumeration value=""AI"" />
      <xs:enumeration value=""AJ"" />
      <xs:enumeration value=""AK"" />
      <xs:enumeration value=""AL"" />
      <xs:enumeration value=""ALA"" />
      <xs:enumeration value=""AM"" />
      <xs:enumeration value=""AN"" />
      <xs:enumeration value=""AO"" />
      <xs:enumeration value=""AP"" />
      <xs:enumeration value=""AQ"" />
      <xs:enumeration value=""AR"" />
      <xs:enumeration value=""AS"" />
      <xs:enumeration value=""AT"" />
      <xs:enumeration value=""AU"" />
      <xs:enumeration value=""AV"" />
      <xs:enumeration value=""AW"" />
      <xs:enumeration value=""AX"" />
      <xs:enumeration value=""AY"" />
      <xs:enumeration value=""AZ"" />
      <xs:enumeration value=""B1"" />
      <xs:enumeration value=""B2"" />
      <xs:enumeration value=""B3"" />
      <xs:enumeration value=""B4"" />
      <xs:enumeration value=""B5"" />
      <xs:enumeration value=""B6"" />
      <xs:enumeration value=""B7"" />
      <xs:enumeration value=""B8"" />
      <xs:enumeration value=""B9"" />
      <xs:enumeration value=""BA"" />
      <xs:enumeration value=""BAL"" />
      <xs:enumeration value=""BB"" />
      <xs:enumeration value=""BC"" />
      <xs:enumeration value=""BD"" />
      <xs:enumeration value=""BE"" />
      <xs:enumeration value=""BF"" />
      <xs:enumeration value=""BG"" />
      <xs:enumeration value=""BH"" />
      <xs:enumeration value=""BI"" />
      <xs:enumeration value=""BJ"" />
      <xs:enumeration value=""BK"" />
      <xs:enumeration value=""BKR"" />
      <xs:enumeration value=""BL"" />
      <xs:enumeration value=""BM"" />
      <xs:enumeration value=""BN"" />
      <xs:enumeration value=""BO"" />
      <xs:enumeration value=""BP"" />
      <xs:enumeration value=""BQ"" />
      <xs:enumeration value=""BR"" />
      <xs:enumeration value=""BRN"" />
      <xs:enumeration value=""BS"" />
      <xs:enumeration value=""BT"" />
      <xs:enumeration value=""BU"" />
      <xs:enumeration value=""BUS"" />
      <xs:enumeration value=""BV"" />
      <xs:enumeration value=""BW"" />
      <xs:enumeration value=""BX"" />
      <xs:enumeration value=""BY"" />
      <xs:enumeration value=""BZ"" />
      <xs:enumeration value=""C1"" />
      <xs:enumeration value=""C2"" />
      <xs:enumeration value=""C3"" />
      <xs:enumeration value=""C4"" />
      <xs:enumeration value=""C5"" />
      <xs:enumeration value=""C6"" />
      <xs:enumeration value=""C7"" />
      <xs:enumeration value=""C8"" />
      <xs:enumeration value=""C9"" />
      <xs:enumeration value=""CA"" />
      <xs:enumeration value=""CB"" />
      <xs:enumeration value=""CC"" />
      <xs:enumeration value=""CD"" />
      <xs:enumeration value=""CE"" />
      <xs:enumeration value=""CF"" />
      <xs:enumeration value=""CG"" />
      <xs:enumeration value=""CH"" />
      <xs:enumeration value=""CI"" />
      <xs:enumeration value=""CJ"" />
      <xs:enumeration value=""CK"" />
      <xs:enumeration value=""CL"" />
      <xs:enumeration value=""CM"" />
      <xs:enumeration value=""CMW"" />
      <xs:enumeration value=""CN"" />
      <xs:enumeration value=""CO"" />
      <xs:enumeration value=""COL"" />
      <xs:enumeration value=""COR"" />
      <xs:enumeration value=""CP"" />
      <xs:enumeration value=""CQ"" />
      <xs:enumeration value=""CR"" />
      <xs:enumeration value=""CS"" />
      <xs:enumeration value=""CT"" />
      <xs:enumeration value=""CU"" />
      <xs:enumeration value=""CV"" />
      <xs:enumeration value=""CW"" />
      <xs:enumeration value=""CX"" />
      <xs:enumeration value=""CY"" />
      <xs:enumeration value=""CZ"" />
      <xs:enumeration value=""D1"" />
      <xs:enumeration value=""D2"" />
      <xs:enumeration value=""D3"" />
      <xs:enumeration value=""D4"" />
      <xs:enumeration value=""D5"" />
      <xs:enumeration value=""D6"" />
      <xs:enumeration value=""D7"" />
      <xs:enumeration value=""D8"" />
      <xs:enumeration value=""D9"" />
      <xs:enumeration value=""DA"" />
      <xs:enumeration value=""DB"" />
      <xs:enumeration value=""DC"" />
      <xs:enumeration value=""DCC"" />
      <xs:enumeration value=""DD"" />
      <xs:enumeration value=""DE"" />
      <xs:enumeration value=""DF"" />
      <xs:enumeration value=""DG"" />
      <xs:enumeration value=""DH"" />
      <xs:enumeration value=""DI"" />
      <xs:enumeration value=""DIR"" />
      <xs:enumeration value=""DJ"" />
      <xs:enumeration value=""DK"" />
      <xs:enumeration value=""DL"" />
      <xs:enumeration value=""DM"" />
      <xs:enumeration value=""DN"" />
      <xs:enumeration value=""DO"" />
      <xs:enumeration value=""DP"" />
      <xs:enumeration value=""DQ"" />
      <xs:enumeration value=""DR"" />
      <xs:enumeration value=""DS"" />
      <xs:enumeration value=""DT"" />
      <xs:enumeration value=""DU"" />
      <xs:enumeration value=""DV"" />
      <xs:enumeration value=""DW"" />
      <xs:enumeration value=""DX"" />
      <xs:enumeration value=""DY"" />
      <xs:enumeration value=""DZ"" />
      <xs:enumeration value=""E1"" />
      <xs:enumeration value=""E2"" />
      <xs:enumeration value=""E3"" />
      <xs:enumeration value=""E4"" />
      <xs:enumeration value=""E5"" />
      <xs:enumeration value=""E6"" />
      <xs:enumeration value=""E7"" />
      <xs:enumeration value=""E8"" />
      <xs:enumeration value=""E9"" />
      <xs:enumeration value=""EA"" />
      <xs:enumeration value=""EB"" />
      <xs:enumeration value=""EC"" />
      <xs:enumeration value=""ED"" />
      <xs:enumeration value=""EE"" />
      <xs:enumeration value=""EF"" />
      <xs:enumeration value=""EG"" />
      <xs:enumeration value=""EH"" />
      <xs:enumeration value=""EI"" />
      <xs:enumeration value=""EJ"" />
      <xs:enumeration value=""EK"" />
      <xs:enumeration value=""EL"" />
      <xs:enumeration value=""EM"" />
      <xs:enumeration value=""EN"" />
      <xs:enumeration value=""ENR"" />
      <xs:enumeration value=""EO"" />
      <xs:enumeration value=""EP"" />
      <xs:enumeration value=""EQ"" />
      <xs:enumeration value=""ER"" />
      <xs:enumeration value=""ES"" />
      <xs:enumeration value=""ET"" />
      <xs:enumeration value=""EU"" />
      <xs:enumeration value=""EV"" />
      <xs:enumeration value=""EW"" />
      <xs:enumeration value=""EX"" />
      <xs:enumeration value=""EXS"" />
      <xs:enumeration value=""EY"" />
      <xs:enumeration value=""EZ"" />
      <xs:enumeration value=""F1"" />
      <xs:enumeration value=""F2"" />
      <xs:enumeration value=""F3"" />
      <xs:enumeration value=""F4"" />
      <xs:enumeration value=""F5"" />
      <xs:enumeration value=""F6"" />
      <xs:enumeration value=""F7"" />
      <xs:enumeration value=""F8"" />
      <xs:enumeration value=""F9"" />
      <xs:enumeration value=""FA"" />
      <xs:enumeration value=""FB"" />
      <xs:enumeration value=""FC"" />
      <xs:enumeration value=""FD"" />
      <xs:enumeration value=""FE"" />
      <xs:enumeration value=""FF"" />
      <xs:enumeration value=""FG"" />
      <xs:enumeration value=""FH"" />
      <xs:enumeration value=""FI"" />
      <xs:enumeration value=""FJ"" />
      <xs:enumeration value=""FL"" />
      <xs:enumeration value=""FM"" />
      <xs:enumeration value=""FN"" />
      <xs:enumeration value=""FO"" />
      <xs:enumeration value=""FP"" />
      <xs:enumeration value=""FQ"" />
      <xs:enumeration value=""FR"" />
      <xs:enumeration value=""FRL"" />
      <xs:enumeration value=""FS"" />
      <xs:enumeration value=""FSR"" />
      <xs:enumeration value=""FT"" />
      <xs:enumeration value=""FU"" />
      <xs:enumeration value=""FV"" />
      <xs:enumeration value=""FW"" />
      <xs:enumeration value=""FX"" />
      <xs:enumeration value=""FY"" />
      <xs:enumeration value=""FZ"" />
      <xs:enumeration value=""G0"" />
      <xs:enumeration value=""G1"" />
      <xs:enumeration value=""G2"" />
      <xs:enumeration value=""G3"" />
      <xs:enumeration value=""G5"" />
      <xs:enumeration value=""G6"" />
      <xs:enumeration value=""G7"" />
      <xs:enumeration value=""G8"" />
      <xs:enumeration value=""G9"" />
      <xs:enumeration value=""GA"" />
      <xs:enumeration value=""GB"" />
      <xs:enumeration value=""GC"" />
      <xs:enumeration value=""GD"" />
      <xs:enumeration value=""GE"" />
      <xs:enumeration value=""GF"" />
      <xs:enumeration value=""GG"" />
      <xs:enumeration value=""GH"" />
      <xs:enumeration value=""GI"" />
      <xs:enumeration value=""GIR"" />
      <xs:enumeration value=""GJ"" />
      <xs:enumeration value=""GK"" />
      <xs:enumeration value=""GL"" />
      <xs:enumeration value=""GM"" />
      <xs:enumeration value=""GN"" />
      <xs:enumeration value=""GO"" />
      <xs:enumeration value=""GP"" />
      <xs:enumeration value=""GQ"" />
      <xs:enumeration value=""GR"" />
      <xs:enumeration value=""GS"" />
      <xs:enumeration value=""GT"" />
      <xs:enumeration value=""GU"" />
      <xs:enumeration value=""GV"" />
      <xs:enumeration value=""GW"" />
      <xs:enumeration value=""GX"" />
      <xs:enumeration value=""GY"" />
      <xs:enumeration value=""GZ"" />
      <xs:enumeration value=""H1"" />
      <xs:enumeration value=""H2"" />
      <xs:enumeration value=""H3"" />
      <xs:enumeration value=""H5"" />
      <xs:enumeration value=""H6"" />
      <xs:enumeration value=""H7"" />
      <xs:enumeration value=""H8"" />
      <xs:enumeration value=""H9"" />
      <xs:enumeration value=""HA"" />
      <xs:enumeration value=""HB"" />
      <xs:enumeration value=""HC"" />
      <xs:enumeration value=""HD"" />
      <xs:enumeration value=""HE"" />
      <xs:enumeration value=""HF"" />
      <xs:enumeration value=""HG"" />
      <xs:enumeration value=""HH"" />
      <xs:enumeration value=""HI"" />
      <xs:enumeration value=""HJ"" />
      <xs:enumeration value=""HK"" />
      <xs:enumeration value=""HL"" />
      <xs:enumeration value=""HM"" />
      <xs:enumeration value=""HMI"" />
      <xs:enumeration value=""HN"" />
      <xs:enumeration value=""HO"" />
      <xs:enumeration value=""HOM"" />
      <xs:enumeration value=""HP"" />
      <xs:enumeration value=""HQ"" />
      <xs:enumeration value=""HR"" />
      <xs:enumeration value=""HS"" />
      <xs:enumeration value=""HT"" />
      <xs:enumeration value=""HU"" />
      <xs:enumeration value=""HV"" />
      <xs:enumeration value=""HW"" />
      <xs:enumeration value=""HX"" />
      <xs:enumeration value=""HY"" />
      <xs:enumeration value=""HZ"" />
      <xs:enumeration value=""I1"" />
      <xs:enumeration value=""I3"" />
      <xs:enumeration value=""I4"" />
      <xs:enumeration value=""I9"" />
      <xs:enumeration value=""IA"" />
      <xs:enumeration value=""IAA"" />
      <xs:enumeration value=""IAC"" />
      <xs:enumeration value=""IAD"" />
      <xs:enumeration value=""IAE"" />
      <xs:enumeration value=""IAF"" />
      <xs:enumeration value=""IAG"" />
      <xs:enumeration value=""IAH"" />
      <xs:enumeration value=""IAI"" />
      <xs:enumeration value=""IAK"" />
      <xs:enumeration value=""IAL"" />
      <xs:enumeration value=""IAM"" />
      <xs:enumeration value=""IAN"" />
      <xs:enumeration value=""IAO"" />
      <xs:enumeration value=""IAP"" />
      <xs:enumeration value=""IAQ"" />
      <xs:enumeration value=""IAR"" />
      <xs:enumeration value=""IAS"" />
      <xs:enumeration value=""IAT"" />
      <xs:enumeration value=""IAU"" />
      <xs:enumeration value=""IAV"" />
      <xs:enumeration value=""IAW"" />
      <xs:enumeration value=""IAY"" />
      <xs:enumeration value=""IAZ"" />
      <xs:enumeration value=""IB"" />
      <xs:enumeration value=""IC"" />
      <xs:enumeration value=""ID"" />
      <xs:enumeration value=""IE"" />
      <xs:enumeration value=""IF"" />
      <xs:enumeration value=""II"" />
      <xs:enumeration value=""IJ"" />
      <xs:enumeration value=""IK"" />
      <xs:enumeration value=""IL"" />
      <xs:enumeration value=""IM"" />
      <xs:enumeration value=""IN"" />
      <xs:enumeration value=""INV"" />
      <xs:enumeration value=""IO"" />
      <xs:enumeration value=""IP"" />
      <xs:enumeration value=""IQ"" />
      <xs:enumeration value=""IR"" />
      <xs:enumeration value=""IS"" />
      <xs:enumeration value=""IT"" />
      <xs:enumeration value=""IU"" />
      <xs:enumeration value=""IV"" />
      <xs:enumeration value=""J1"" />
      <xs:enumeration value=""J2"" />
      <xs:enumeration value=""J3"" />
      <xs:enumeration value=""J4"" />
      <xs:enumeration value=""J5"" />
      <xs:enumeration value=""J6"" />
      <xs:enumeration value=""J7"" />
      <xs:enumeration value=""J8"" />
      <xs:enumeration value=""J9"" />
      <xs:enumeration value=""JA"" />
      <xs:enumeration value=""JB"" />
      <xs:enumeration value=""JC"" />
      <xs:enumeration value=""JD"" />
      <xs:enumeration value=""JE"" />
      <xs:enumeration value=""JF"" />
      <xs:enumeration value=""JG"" />
      <xs:enumeration value=""JH"" />
      <xs:enumeration value=""JI"" />
      <xs:enumeration value=""JJ"" />
      <xs:enumeration value=""JK"" />
      <xs:enumeration value=""JL"" />
      <xs:enumeration value=""JM"" />
      <xs:enumeration value=""JN"" />
      <xs:enumeration value=""JO"" />
      <xs:enumeration value=""JP"" />
      <xs:enumeration value=""JQ"" />
      <xs:enumeration value=""JR"" />
      <xs:enumeration value=""JS"" />
      <xs:enumeration value=""JT"" />
      <xs:enumeration value=""JU"" />
      <xs:enumeration value=""JV"" />
      <xs:enumeration value=""JW"" />
      <xs:enumeration value=""JX"" />
      <xs:enumeration value=""JY"" />
      <xs:enumeration value=""JZ"" />
      <xs:enumeration value=""K1"" />
      <xs:enumeration value=""K2"" />
      <xs:enumeration value=""K3"" />
      <xs:enumeration value=""K4"" />
      <xs:enumeration value=""K5"" />
      <xs:enumeration value=""K6"" />
      <xs:enumeration value=""K7"" />
      <xs:enumeration value=""K8"" />
      <xs:enumeration value=""K9"" />
      <xs:enumeration value=""KA"" />
      <xs:enumeration value=""KB"" />
      <xs:enumeration value=""KC"" />
      <xs:enumeration value=""KD"" />
      <xs:enumeration value=""KE"" />
      <xs:enumeration value=""KF"" />
      <xs:enumeration value=""KG"" />
      <xs:enumeration value=""KH"" />
      <xs:enumeration value=""KI"" />
      <xs:enumeration value=""KJ"" />
      <xs:enumeration value=""KK"" />
      <xs:enumeration value=""KL"" />
      <xs:enumeration value=""KM"" />
      <xs:enumeration value=""KN"" />
      <xs:enumeration value=""KO"" />
      <xs:enumeration value=""KP"" />
      <xs:enumeration value=""KQ"" />
      <xs:enumeration value=""KR"" />
      <xs:enumeration value=""KS"" />
      <xs:enumeration value=""KT"" />
      <xs:enumeration value=""KU"" />
      <xs:enumeration value=""KV"" />
      <xs:enumeration value=""KW"" />
      <xs:enumeration value=""KX"" />
      <xs:enumeration value=""KY"" />
      <xs:enumeration value=""KZ"" />
      <xs:enumeration value=""L1"" />
      <xs:enumeration value=""L2"" />
      <xs:enumeration value=""L3"" />
      <xs:enumeration value=""L5"" />
      <xs:enumeration value=""L8"" />
      <xs:enumeration value=""L9"" />
      <xs:enumeration value=""LA"" />
      <xs:enumeration value=""LB"" />
      <xs:enumeration value=""LC"" />
      <xs:enumeration value=""LD"" />
      <xs:enumeration value=""LE"" />
      <xs:enumeration value=""LF"" />
      <xs:enumeration value=""LG"" />
      <xs:enumeration value=""LGS"" />
      <xs:enumeration value=""LH"" />
      <xs:enumeration value=""LI"" />
      <xs:enumeration value=""LJ"" />
      <xs:enumeration value=""LK"" />
      <xs:enumeration value=""LL"" />
      <xs:enumeration value=""LM"" />
      <xs:enumeration value=""LN"" />
      <xs:enumeration value=""LO"" />
      <xs:enumeration value=""LP"" />
      <xs:enumeration value=""LQ"" />
      <xs:enumeration value=""LR"" />
      <xs:enumeration value=""LS"" />
      <xs:enumeration value=""LT"" />
      <xs:enumeration value=""LU"" />
      <xs:enumeration value=""LV"" />
      <xs:enumeration value=""LW"" />
      <xs:enumeration value=""LY"" />
      <xs:enumeration value=""LYM"" />
      <xs:enumeration value=""LYN"" />
      <xs:enumeration value=""LYO"" />
      <xs:enumeration value=""LYP"" />
      <xs:enumeration value=""LZ"" />
      <xs:enumeration value=""M1"" />
      <xs:enumeration value=""M2"" />
      <xs:enumeration value=""M3"" />
      <xs:enumeration value=""M4"" />
      <xs:enumeration value=""M5"" />
      <xs:enumeration value=""M6"" />
      <xs:enumeration value=""M7"" />
      <xs:enumeration value=""M8"" />
      <xs:enumeration value=""M9"" />
      <xs:enumeration value=""MA"" />
      <xs:enumeration value=""MB"" />
      <xs:enumeration value=""MC"" />
      <xs:enumeration value=""MD"" />
      <xs:enumeration value=""ME"" />
      <xs:enumeration value=""MF"" />
      <xs:enumeration value=""MG"" />
      <xs:enumeration value=""MH"" />
      <xs:enumeration value=""MI"" />
      <xs:enumeration value=""MJ"" />
      <xs:enumeration value=""MK"" />
      <xs:enumeration value=""ML"" />
      <xs:enumeration value=""MM"" />
      <xs:enumeration value=""MN"" />
      <xs:enumeration value=""MO"" />
      <xs:enumeration value=""MP"" />
      <xs:enumeration value=""MQ"" />
      <xs:enumeration value=""MR"" />
      <xs:enumeration value=""MS"" />
      <xs:enumeration value=""MSC"" />
      <xs:enumeration value=""MT"" />
      <xs:enumeration value=""MU"" />
      <xs:enumeration value=""MV"" />
      <xs:enumeration value=""MW"" />
      <xs:enumeration value=""MX"" />
      <xs:enumeration value=""MY"" />
      <xs:enumeration value=""MZ"" />
      <xs:enumeration value=""N1"" />
      <xs:enumeration value=""N2"" />
      <xs:enumeration value=""N3"" />
      <xs:enumeration value=""N4"" />
      <xs:enumeration value=""N5"" />
      <xs:enumeration value=""N6"" />
      <xs:enumeration value=""N7"" />
      <xs:enumeration value=""N8"" />
      <xs:enumeration value=""N9"" />
      <xs:enumeration value=""NB"" />
      <xs:enumeration value=""NC"" />
      <xs:enumeration value=""NCT"" />
      <xs:enumeration value=""ND"" />
      <xs:enumeration value=""NE"" />
      <xs:enumeration value=""NF"" />
      <xs:enumeration value=""NG"" />
      <xs:enumeration value=""NH"" />
      <xs:enumeration value=""NI"" />
      <xs:enumeration value=""NJ"" />
      <xs:enumeration value=""NK"" />
      <xs:enumeration value=""NL"" />
      <xs:enumeration value=""NM"" />
      <xs:enumeration value=""NN"" />
      <xs:enumeration value=""NP"" />
      <xs:enumeration value=""NPC"" />
      <xs:enumeration value=""NQ"" />
      <xs:enumeration value=""NR"" />
      <xs:enumeration value=""NS"" />
      <xs:enumeration value=""NT"" />
      <xs:enumeration value=""NU"" />
      <xs:enumeration value=""NV"" />
      <xs:enumeration value=""NW"" />
      <xs:enumeration value=""NX"" />
      <xs:enumeration value=""NY"" />
      <xs:enumeration value=""NZ"" />
      <xs:enumeration value=""O1"" />
      <xs:enumeration value=""O2"" />
      <xs:enumeration value=""O3"" />
      <xs:enumeration value=""O4"" />
      <xs:enumeration value=""O5"" />
      <xs:enumeration value=""O6"" />
      <xs:enumeration value=""O7"" />
      <xs:enumeration value=""O8"" />
      <xs:enumeration value=""OA"" />
      <xs:enumeration value=""OB"" />
      <xs:enumeration value=""OC"" />
      <xs:enumeration value=""OD"" />
      <xs:enumeration value=""OE"" />
      <xs:enumeration value=""OF"" />
      <xs:enumeration value=""OG"" />
      <xs:enumeration value=""OH"" />
      <xs:enumeration value=""OI"" />
      <xs:enumeration value=""OK"" />
      <xs:enumeration value=""OL"" />
      <xs:enumeration value=""OM"" />
      <xs:enumeration value=""ON"" />
      <xs:enumeration value=""OO"" />
      <xs:enumeration value=""OP"" />
      <xs:enumeration value=""OR"" />
      <xs:enumeration value=""ORI"" />
      <xs:enumeration value=""OS"" />
      <xs:enumeration value=""OT"" />
      <xs:enumeration value=""OU"" />
      <xs:enumeration value=""OV"" />
      <xs:enumeration value=""OW"" />
      <xs:enumeration value=""OX"" />
      <xs:enumeration value=""OY"" />
      <xs:enumeration value=""OZ"" />
      <xs:enumeration value=""P0"" />
      <xs:enumeration value=""P1"" />
      <xs:enumeration value=""P2"" />
      <xs:enumeration value=""P3"" />
      <xs:enumeration value=""P4"" />
      <xs:enumeration value=""P5"" />
      <xs:enumeration value=""P6"" />
      <xs:enumeration value=""P7"" />
      <xs:enumeration value=""P8"" />
      <xs:enumeration value=""P9"" />
      <xs:enumeration value=""PA"" />
      <xs:enumeration value=""PB"" />
      <xs:enumeration value=""PC"" />
      <xs:enumeration value=""PD"" />
      <xs:enumeration value=""PE"" />
      <xs:enumeration value=""PF"" />
      <xs:enumeration value=""PG"" />
      <xs:enumeration value=""PH"" />
      <xs:enumeration value=""PI"" />
      <xs:enumeration value=""PJ"" />
      <xs:enumeration value=""PK"" />
      <xs:enumeration value=""PL"" />
      <xs:enumeration value=""PLR"" />
      <xs:enumeration value=""PM"" />
      <xs:enumeration value=""PMF"" />
      <xs:enumeration value=""PN"" />
      <xs:enumeration value=""PO"" />
      <xs:enumeration value=""PP"" />
      <xs:enumeration value=""PPS"" />
      <xs:enumeration value=""PQ"" />
      <xs:enumeration value=""PR"" />
      <xs:enumeration value=""PRE"" />
      <xs:enumeration value=""PRP"" />
      <xs:enumeration value=""PS"" />
      <xs:enumeration value=""PT"" />
      <xs:enumeration value=""PU"" />
      <xs:enumeration value=""PUR"" />
      <xs:enumeration value=""PV"" />
      <xs:enumeration value=""PW"" />
      <xs:enumeration value=""PX"" />
      <xs:enumeration value=""PY"" />
      <xs:enumeration value=""PZ"" />
      <xs:enumeration value=""Q1"" />
      <xs:enumeration value=""Q2"" />
      <xs:enumeration value=""Q3"" />
      <xs:enumeration value=""Q4"" />
      <xs:enumeration value=""Q5"" />
      <xs:enumeration value=""Q6"" />
      <xs:enumeration value=""Q7"" />
      <xs:enumeration value=""Q8"" />
      <xs:enumeration value=""Q9"" />
      <xs:enumeration value=""QA"" />
      <xs:enumeration value=""QB"" />
      <xs:enumeration value=""QC"" />
      <xs:enumeration value=""QD"" />
      <xs:enumeration value=""QE"" />
      <xs:enumeration value=""QF"" />
      <xs:enumeration value=""QG"" />
      <xs:enumeration value=""QH"" />
      <xs:enumeration value=""QI"" />
      <xs:enumeration value=""QJ"" />
      <xs:enumeration value=""QK"" />
      <xs:enumeration value=""QL"" />
      <xs:enumeration value=""QM"" />
      <xs:enumeration value=""QN"" />
      <xs:enumeration value=""QO"" />
      <xs:enumeration value=""QP"" />
      <xs:enumeration value=""QQ"" />
      <xs:enumeration value=""QR"" />
      <xs:enumeration value=""QS"" />
      <xs:enumeration value=""QT"" />
      <xs:enumeration value=""QU"" />
      <xs:enumeration value=""QV"" />
      <xs:enumeration value=""QW"" />
      <xs:enumeration value=""QX"" />
      <xs:enumeration value=""QY"" />
      <xs:enumeration value=""QZ"" />
      <xs:enumeration value=""R0"" />
      <xs:enumeration value=""R1"" />
      <xs:enumeration value=""R2"" />
      <xs:enumeration value=""R3"" />
      <xs:enumeration value=""R4"" />
      <xs:enumeration value=""R5"" />
      <xs:enumeration value=""R6"" />
      <xs:enumeration value=""R7"" />
      <xs:enumeration value=""R8"" />
      <xs:enumeration value=""R9"" />
      <xs:enumeration value=""RA"" />
      <xs:enumeration value=""RB"" />
      <xs:enumeration value=""RC"" />
      <xs:enumeration value=""RCR"" />
      <xs:enumeration value=""RD"" />
      <xs:enumeration value=""RE"" />
      <xs:enumeration value=""REC"" />
      <xs:enumeration value=""RF"" />
      <xs:enumeration value=""RG"" />
      <xs:enumeration value=""RGA"" />
      <xs:enumeration value=""RH"" />
      <xs:enumeration value=""RI"" />
      <xs:enumeration value=""RJ"" />
      <xs:enumeration value=""RK"" />
      <xs:enumeration value=""RL"" />
      <xs:enumeration value=""RM"" />
      <xs:enumeration value=""RN"" />
      <xs:enumeration value=""RO"" />
      <xs:enumeration value=""RP"" />
      <xs:enumeration value=""RQ"" />
      <xs:enumeration value=""RR"" />
      <xs:enumeration value=""RS"" />
      <xs:enumeration value=""RT"" />
      <xs:enumeration value=""RU"" />
      <xs:enumeration value=""RV"" />
      <xs:enumeration value=""RW"" />
      <xs:enumeration value=""RX"" />
      <xs:enumeration value=""RY"" />
      <xs:enumeration value=""RZ"" />
      <xs:enumeration value=""S0"" />
      <xs:enumeration value=""S1"" />
      <xs:enumeration value=""S2"" />
      <xs:enumeration value=""S3"" />
      <xs:enumeration value=""S4"" />
      <xs:enumeration value=""S5"" />
      <xs:enumeration value=""S6"" />
      <xs:enumeration value=""S7"" />
      <xs:enumeration value=""S8"" />
      <xs:enumeration value=""S9"" />
      <xs:enumeration value=""SA"" />
      <xs:enumeration value=""SB"" />
      <xs:enumeration value=""SC"" />
      <xs:enumeration value=""SD"" />
      <xs:enumeration value=""SE"" />
      <xs:enumeration value=""SEP"" />
      <xs:enumeration value=""SF"" />
      <xs:enumeration value=""SG"" />
      <xs:enumeration value=""SH"" />
      <xs:enumeration value=""SI"" />
      <xs:enumeration value=""SJ"" />
      <xs:enumeration value=""SK"" />
      <xs:enumeration value=""SL"" />
      <xs:enumeration value=""SM"" />
      <xs:enumeration value=""SN"" />
      <xs:enumeration value=""SO"" />
      <xs:enumeration value=""SP"" />
      <xs:enumeration value=""SQ"" />
      <xs:enumeration value=""SR"" />
      <xs:enumeration value=""SS"" />
      <xs:enumeration value=""ST"" />
      <xs:enumeration value=""SU"" />
      <xs:enumeration value=""SV"" />
      <xs:enumeration value=""SW"" />
      <xs:enumeration value=""SX"" />
      <xs:enumeration value=""SY"" />
      <xs:enumeration value=""SZ"" />
      <xs:enumeration value=""T1"" />
      <xs:enumeration value=""T2"" />
      <xs:enumeration value=""T3"" />
      <xs:enumeration value=""T4"" />
      <xs:enumeration value=""T6"" />
      <xs:enumeration value=""T8"" />
      <xs:enumeration value=""T9"" />
      <xs:enumeration value=""TA"" />
      <xs:enumeration value=""TB"" />
      <xs:enumeration value=""TC"" />
      <xs:enumeration value=""TD"" />
      <xs:enumeration value=""TE"" />
      <xs:enumeration value=""TF"" />
      <xs:enumeration value=""TG"" />
      <xs:enumeration value=""TH"" />
      <xs:enumeration value=""TI"" />
      <xs:enumeration value=""TJ"" />
      <xs:enumeration value=""TK"" />
      <xs:enumeration value=""TL"" />
      <xs:enumeration value=""TM"" />
      <xs:enumeration value=""TN"" />
      <xs:enumeration value=""TO"" />
      <xs:enumeration value=""TP"" />
      <xs:enumeration value=""TPM"" />
      <xs:enumeration value=""TQ"" />
      <xs:enumeration value=""TR"" />
      <xs:enumeration value=""TS"" />
      <xs:enumeration value=""TSE"" />
      <xs:enumeration value=""TSR"" />
      <xs:enumeration value=""TT"" />
      <xs:enumeration value=""TTP"" />
      <xs:enumeration value=""TU"" />
      <xs:enumeration value=""TV"" />
      <xs:enumeration value=""TW"" />
      <xs:enumeration value=""TX"" />
      <xs:enumeration value=""TY"" />
      <xs:enumeration value=""TZ"" />
      <xs:enumeration value=""U1"" />
      <xs:enumeration value=""U2"" />
      <xs:enumeration value=""U3"" />
      <xs:enumeration value=""U4"" />
      <xs:enumeration value=""U5"" />
      <xs:enumeration value=""U6"" />
      <xs:enumeration value=""U7"" />
      <xs:enumeration value=""U8"" />
      <xs:enumeration value=""U9"" />
      <xs:enumeration value=""UA"" />
      <xs:enumeration value=""UB"" />
      <xs:enumeration value=""UC"" />
      <xs:enumeration value=""UD"" />
      <xs:enumeration value=""UE"" />
      <xs:enumeration value=""UF"" />
      <xs:enumeration value=""UG"" />
      <xs:enumeration value=""UH"" />
      <xs:enumeration value=""UI"" />
      <xs:enumeration value=""UJ"" />
      <xs:enumeration value=""UK"" />
      <xs:enumeration value=""UL"" />
      <xs:enumeration value=""UM"" />
      <xs:enumeration value=""UN"" />
      <xs:enumeration value=""UO"" />
      <xs:enumeration value=""UP"" />
      <xs:enumeration value=""UQ"" />
      <xs:enumeration value=""UR"" />
      <xs:enumeration value=""US"" />
      <xs:enumeration value=""UT"" />
      <xs:enumeration value=""UU"" />
      <xs:enumeration value=""UW"" />
      <xs:enumeration value=""UX"" />
      <xs:enumeration value=""UY"" />
      <xs:enumeration value=""UZ"" />
      <xs:enumeration value=""V1"" />
      <xs:enumeration value=""V2"" />
      <xs:enumeration value=""V3"" />
      <xs:enumeration value=""V4"" />
      <xs:enumeration value=""V5"" />
      <xs:enumeration value=""V6"" />
      <xs:enumeration value=""V8"" />
      <xs:enumeration value=""V9"" />
      <xs:enumeration value=""VA"" />
      <xs:enumeration value=""VB"" />
      <xs:enumeration value=""VC"" />
      <xs:enumeration value=""VD"" />
      <xs:enumeration value=""VE"" />
      <xs:enumeration value=""VF"" />
      <xs:enumeration value=""VG"" />
      <xs:enumeration value=""VH"" />
      <xs:enumeration value=""VI"" />
      <xs:enumeration value=""VJ"" />
      <xs:enumeration value=""VK"" />
      <xs:enumeration value=""VL"" />
      <xs:enumeration value=""VM"" />
      <xs:enumeration value=""VN"" />
      <xs:enumeration value=""VO"" />
      <xs:enumeration value=""VP"" />
      <xs:enumeration value=""VQ"" />
      <xs:enumeration value=""VR"" />
      <xs:enumeration value=""VS"" />
      <xs:enumeration value=""VT"" />
      <xs:enumeration value=""VU"" />
      <xs:enumeration value=""VV"" />
      <xs:enumeration value=""VW"" />
      <xs:enumeration value=""VX"" />
      <xs:enumeration value=""VY"" />
      <xs:enumeration value=""VZ"" />
      <xs:enumeration value=""W1"" />
      <xs:enumeration value=""W2"" />
      <xs:enumeration value=""W3"" />
      <xs:enumeration value=""W4"" />
      <xs:enumeration value=""W8"" />
      <xs:enumeration value=""W9"" />
      <xs:enumeration value=""WA"" />
      <xs:enumeration value=""WB"" />
      <xs:enumeration value=""WC"" />
      <xs:enumeration value=""WD"" />
      <xs:enumeration value=""WE"" />
      <xs:enumeration value=""WF"" />
      <xs:enumeration value=""WG"" />
      <xs:enumeration value=""WH"" />
      <xs:enumeration value=""WI"" />
      <xs:enumeration value=""WJ"" />
      <xs:enumeration value=""WL"" />
      <xs:enumeration value=""WN"" />
      <xs:enumeration value=""WO"" />
      <xs:enumeration value=""WP"" />
      <xs:enumeration value=""WR"" />
      <xs:enumeration value=""WS"" />
      <xs:enumeration value=""WT"" />
      <xs:enumeration value=""WU"" />
      <xs:enumeration value=""WV"" />
      <xs:enumeration value=""WW"" />
      <xs:enumeration value=""WX"" />
      <xs:enumeration value=""WY"" />
      <xs:enumeration value=""WZ"" />
      <xs:enumeration value=""X1"" />
      <xs:enumeration value=""X2"" />
      <xs:enumeration value=""X3"" />
      <xs:enumeration value=""X4"" />
      <xs:enumeration value=""X5"" />
      <xs:enumeration value=""X6"" />
      <xs:enumeration value=""X7"" />
      <xs:enumeration value=""X8"" />
      <xs:enumeration value=""XA"" />
      <xs:enumeration value=""XC"" />
      <xs:enumeration value=""XD"" />
      <xs:enumeration value=""XE"" />
      <xs:enumeration value=""XF"" />
      <xs:enumeration value=""XG"" />
      <xs:enumeration value=""XH"" />
      <xs:enumeration value=""XI"" />
      <xs:enumeration value=""XJ"" />
      <xs:enumeration value=""XK"" />
      <xs:enumeration value=""XL"" />
      <xs:enumeration value=""XM"" />
      <xs:enumeration value=""XN"" />
      <xs:enumeration value=""XO"" />
      <xs:enumeration value=""XP"" />
      <xs:enumeration value=""XQ"" />
      <xs:enumeration value=""XR"" />
      <xs:enumeration value=""XS"" />
      <xs:enumeration value=""XT"" />
      <xs:enumeration value=""XU"" />
      <xs:enumeration value=""XV"" />
      <xs:enumeration value=""XW"" />
      <xs:enumeration value=""XX"" />
      <xs:enumeration value=""XY"" />
      <xs:enumeration value=""XZ"" />
      <xs:enumeration value=""Y2"" />
      <xs:enumeration value=""YA"" />
      <xs:enumeration value=""YB"" />
      <xs:enumeration value=""YC"" />
      <xs:enumeration value=""YD"" />
      <xs:enumeration value=""YE"" />
      <xs:enumeration value=""YF"" />
      <xs:enumeration value=""YG"" />
      <xs:enumeration value=""YH"" />
      <xs:enumeration value=""YI"" />
      <xs:enumeration value=""YJ"" />
      <xs:enumeration value=""YK"" />
      <xs:enumeration value=""YL"" />
      <xs:enumeration value=""YM"" />
      <xs:enumeration value=""YN"" />
      <xs:enumeration value=""YO"" />
      <xs:enumeration value=""YP"" />
      <xs:enumeration value=""YQ"" />
      <xs:enumeration value=""YR"" />
      <xs:enumeration value=""YS"" />
      <xs:enumeration value=""YT"" />
      <xs:enumeration value=""YU"" />
      <xs:enumeration value=""YV"" />
      <xs:enumeration value=""YW"" />
      <xs:enumeration value=""YX"" />
      <xs:enumeration value=""YY"" />
      <xs:enumeration value=""YZ"" />
      <xs:enumeration value=""Z1"" />
      <xs:enumeration value=""Z2"" />
      <xs:enumeration value=""Z3"" />
      <xs:enumeration value=""Z4"" />
      <xs:enumeration value=""Z5"" />
      <xs:enumeration value=""Z6"" />
      <xs:enumeration value=""Z7"" />
      <xs:enumeration value=""Z8"" />
      <xs:enumeration value=""Z9"" />
      <xs:enumeration value=""ZA"" />
      <xs:enumeration value=""ZB"" />
      <xs:enumeration value=""ZC"" />
      <xs:enumeration value=""ZD"" />
      <xs:enumeration value=""ZE"" />
      <xs:enumeration value=""ZF"" />
      <xs:enumeration value=""ZG"" />
      <xs:enumeration value=""ZH"" />
      <xs:enumeration value=""ZJ"" />
      <xs:enumeration value=""ZK"" />
      <xs:enumeration value=""ZL"" />
      <xs:enumeration value=""ZM"" />
      <xs:enumeration value=""ZN"" />
      <xs:enumeration value=""ZO"" />
      <xs:enumeration value=""ZP"" />
      <xs:enumeration value=""ZQ"" />
      <xs:enumeration value=""ZR"" />
      <xs:enumeration value=""ZS"" />
      <xs:enumeration value=""ZT"" />
      <xs:enumeration value=""ZU"" />
      <xs:enumeration value=""ZV"" />
      <xs:enumeration value=""ZW"" />
      <xs:enumeration value=""ZX"" />
      <xs:enumeration value=""ZY"" />
      <xs:enumeration value=""ZZ"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""X12_ID_66"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""1"" />
      <xs:enumeration value=""10"" />
      <xs:enumeration value=""11"" />
      <xs:enumeration value=""12"" />
      <xs:enumeration value=""13"" />
      <xs:enumeration value=""14"" />
      <xs:enumeration value=""15"" />
      <xs:enumeration value=""16"" />
      <xs:enumeration value=""17"" />
      <xs:enumeration value=""18"" />
      <xs:enumeration value=""19"" />
      <xs:enumeration value=""2"" />
      <xs:enumeration value=""20"" />
      <xs:enumeration value=""21"" />
      <xs:enumeration value=""22"" />
      <xs:enumeration value=""23"" />
      <xs:enumeration value=""24"" />
      <xs:enumeration value=""25"" />
      <xs:enumeration value=""26"" />
      <xs:enumeration value=""27"" />
      <xs:enumeration value=""28"" />
      <xs:enumeration value=""29"" />
      <xs:enumeration value=""3"" />
      <xs:enumeration value=""30"" />
      <xs:enumeration value=""31"" />
      <xs:enumeration value=""32"" />
      <xs:enumeration value=""33"" />
      <xs:enumeration value=""34"" />
      <xs:enumeration value=""35"" />
      <xs:enumeration value=""36"" />
      <xs:enumeration value=""37"" />
      <xs:enumeration value=""38"" />
      <xs:enumeration value=""39"" />
      <xs:enumeration value=""4"" />
      <xs:enumeration value=""40"" />
      <xs:enumeration value=""41"" />
      <xs:enumeration value=""42"" />
      <xs:enumeration value=""43"" />
      <xs:enumeration value=""44"" />
      <xs:enumeration value=""45"" />
      <xs:enumeration value=""46"" />
      <xs:enumeration value=""47"" />
      <xs:enumeration value=""48"" />
      <xs:enumeration value=""49"" />
      <xs:enumeration value=""5"" />
      <xs:enumeration value=""50"" />
      <xs:enumeration value=""53"" />
      <xs:enumeration value=""54"" />
      <xs:enumeration value=""55"" />
      <xs:enumeration value=""56"" />
      <xs:enumeration value=""57"" />
      <xs:enumeration value=""58"" />
      <xs:enumeration value=""59"" />
      <xs:enumeration value=""6"" />
      <xs:enumeration value=""61"" />
      <xs:enumeration value=""62"" />
      <xs:enumeration value=""63"" />
      <xs:enumeration value=""64"" />
      <xs:enumeration value=""7"" />
      <xs:enumeration value=""71"" />
      <xs:enumeration value=""72"" />
      <xs:enumeration value=""73"" />
      <xs:enumeration value=""74"" />
      <xs:enumeration value=""75"" />
      <xs:enumeration value=""76"" />
      <xs:enumeration value=""77"" />
      <xs:enumeration value=""78"" />
      <xs:enumeration value=""8"" />
      <xs:enumeration value=""81"" />
      <xs:enumeration value=""82"" />
      <xs:enumeration value=""9"" />
      <xs:enumeration value=""90"" />
      <xs:enumeration value=""91"" />
      <xs:enumeration value=""92"" />
      <xs:enumeration value=""93"" />
      <xs:enumeration value=""94"" />
      <xs:enumeration value=""95"" />
      <xs:enumeration value=""96"" />
      <xs:enumeration value=""97"" />
      <xs:enumeration value=""98"" />
      <xs:enumeration value=""99"" />
      <xs:enumeration value=""A"" />
      <xs:enumeration value=""A1"" />
      <xs:enumeration value=""A2"" />
      <xs:enumeration value=""A3"" />
      <xs:enumeration value=""A4"" />
      <xs:enumeration value=""A5"" />
      <xs:enumeration value=""A6"" />
      <xs:enumeration value=""AA"" />
      <xs:enumeration value=""AB"" />
      <xs:enumeration value=""AC"" />
      <xs:enumeration value=""AD"" />
      <xs:enumeration value=""AE"" />
      <xs:enumeration value=""AL"" />
      <xs:enumeration value=""AP"" />
      <xs:enumeration value=""BC"" />
      <xs:enumeration value=""BD"" />
      <xs:enumeration value=""BE"" />
      <xs:enumeration value=""BG"" />
      <xs:enumeration value=""BP"" />
      <xs:enumeration value=""BS"" />
      <xs:enumeration value=""C"" />
      <xs:enumeration value=""C1"" />
      <xs:enumeration value=""C2"" />
      <xs:enumeration value=""C5"" />
      <xs:enumeration value=""CA"" />
      <xs:enumeration value=""CB"" />
      <xs:enumeration value=""CC"" />
      <xs:enumeration value=""CD"" />
      <xs:enumeration value=""CE"" />
      <xs:enumeration value=""CF"" />
      <xs:enumeration value=""CI"" />
      <xs:enumeration value=""CL"" />
      <xs:enumeration value=""CM"" />
      <xs:enumeration value=""CP"" />
      <xs:enumeration value=""CR"" />
      <xs:enumeration value=""CS"" />
      <xs:enumeration value=""CT"" />
      <xs:enumeration value=""D"" />
      <xs:enumeration value=""DG"" />
      <xs:enumeration value=""DL"" />
      <xs:enumeration value=""DN"" />
      <xs:enumeration value=""DP"" />
      <xs:enumeration value=""DS"" />
      <xs:enumeration value=""E"" />
      <xs:enumeration value=""EC"" />
      <xs:enumeration value=""EH"" />
      <xs:enumeration value=""EI"" />
      <xs:enumeration value=""EP"" />
      <xs:enumeration value=""EQ"" />
      <xs:enumeration value=""ER"" />
      <xs:enumeration value=""ES"" />
      <xs:enumeration value=""F"" />
      <xs:enumeration value=""FA"" />
      <xs:enumeration value=""FB"" />
      <xs:enumeration value=""FC"" />
      <xs:enumeration value=""FD"" />
      <xs:enumeration value=""FI"" />
      <xs:enumeration value=""FJ"" />
      <xs:enumeration value=""FN"" />
      <xs:enumeration value=""G"" />
      <xs:enumeration value=""GA"" />
      <xs:enumeration value=""GC"" />
      <xs:enumeration value=""HC"" />
      <xs:enumeration value=""HN"" />
      <xs:enumeration value=""I"" />
      <xs:enumeration value=""J"" />
      <xs:enumeration value=""K"" />
      <xs:enumeration value=""L"" />
      <xs:enumeration value=""LC"" />
      <xs:enumeration value=""LD"" />
      <xs:enumeration value=""LE"" />
      <xs:enumeration value=""LI"" />
      <xs:enumeration value=""LN"" />
      <xs:enumeration value=""M3"" />
      <xs:enumeration value=""M4"" />
      <xs:enumeration value=""M5"" />
      <xs:enumeration value=""M6"" />
      <xs:enumeration value=""MA"" />
      <xs:enumeration value=""MB"" />
      <xs:enumeration value=""MC"" />
      <xs:enumeration value=""MD"" />
      <xs:enumeration value=""MI"" />
      <xs:enumeration value=""MK"" />
      <xs:enumeration value=""ML"" />
      <xs:enumeration value=""MN"" />
      <xs:enumeration value=""MP"" />
      <xs:enumeration value=""MR"" />
      <xs:enumeration value=""N"" />
      <xs:enumeration value=""NA"" />
      <xs:enumeration value=""ND"" />
      <xs:enumeration value=""NI"" />
      <xs:enumeration value=""NO"" />
      <xs:enumeration value=""OC"" />
      <xs:enumeration value=""OP"" />
      <xs:enumeration value=""PA"" />
      <xs:enumeration value=""PB"" />
      <xs:enumeration value=""PC"" />
      <xs:enumeration value=""PI"" />
      <xs:enumeration value=""PP"" />
      <xs:enumeration value=""PR"" />
      <xs:enumeration value=""RA"" />
      <xs:enumeration value=""RB"" />
      <xs:enumeration value=""RC"" />
      <xs:enumeration value=""RD"" />
      <xs:enumeration value=""RE"" />
      <xs:enumeration value=""RT"" />
      <xs:enumeration value=""S"" />
      <xs:enumeration value=""SA"" />
      <xs:enumeration value=""SB"" />
      <xs:enumeration value=""SD"" />
      <xs:enumeration value=""SF"" />
      <xs:enumeration value=""SI"" />
      <xs:enumeration value=""SJ"" />
      <xs:enumeration value=""SL"" />
      <xs:enumeration value=""SP"" />
      <xs:enumeration value=""ST"" />
      <xs:enumeration value=""SV"" />
      <xs:enumeration value=""SW"" />
      <xs:enumeration value=""TA"" />
      <xs:enumeration value=""TC"" />
      <xs:enumeration value=""TZ"" />
      <xs:enumeration value=""UC"" />
      <xs:enumeration value=""UL"" />
      <xs:enumeration value=""UM"" />
      <xs:enumeration value=""UP"" />
      <xs:enumeration value=""UR"" />
      <xs:enumeration value=""US"" />
      <xs:enumeration value=""WR"" />
      <xs:enumeration value=""XV"" />
      <xs:enumeration value=""XX"" />
      <xs:enumeration value=""ZC"" />
      <xs:enumeration value=""ZN"" />
      <xs:enumeration value=""ZY"" />
      <xs:enumeration value=""ZZ"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""X12_ID_706"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""01"" />
      <xs:enumeration value=""02"" />
      <xs:enumeration value=""03"" />
      <xs:enumeration value=""04"" />
      <xs:enumeration value=""05"" />
      <xs:enumeration value=""06"" />
      <xs:enumeration value=""07"" />
      <xs:enumeration value=""08"" />
      <xs:enumeration value=""09"" />
      <xs:enumeration value=""10"" />
      <xs:enumeration value=""11"" />
      <xs:enumeration value=""12"" />
      <xs:enumeration value=""13"" />
      <xs:enumeration value=""14"" />
      <xs:enumeration value=""15"" />
      <xs:enumeration value=""16"" />
      <xs:enumeration value=""17"" />
      <xs:enumeration value=""18"" />
      <xs:enumeration value=""19"" />
      <xs:enumeration value=""20"" />
      <xs:enumeration value=""21"" />
      <xs:enumeration value=""22"" />
      <xs:enumeration value=""23"" />
      <xs:enumeration value=""24"" />
      <xs:enumeration value=""25"" />
      <xs:enumeration value=""26"" />
      <xs:enumeration value=""27"" />
      <xs:enumeration value=""29"" />
      <xs:enumeration value=""30"" />
      <xs:enumeration value=""31"" />
      <xs:enumeration value=""32"" />
      <xs:enumeration value=""33"" />
      <xs:enumeration value=""34"" />
      <xs:enumeration value=""35"" />
      <xs:enumeration value=""36"" />
      <xs:enumeration value=""37"" />
      <xs:enumeration value=""38"" />
      <xs:enumeration value=""39"" />
      <xs:enumeration value=""40"" />
      <xs:enumeration value=""41"" />
      <xs:enumeration value=""42"" />
      <xs:enumeration value=""43"" />
      <xs:enumeration value=""44"" />
      <xs:enumeration value=""45"" />
      <xs:enumeration value=""46"" />
      <xs:enumeration value=""47"" />
      <xs:enumeration value=""48"" />
      <xs:enumeration value=""49"" />
      <xs:enumeration value=""50"" />
      <xs:enumeration value=""51"" />
      <xs:enumeration value=""52"" />
      <xs:enumeration value=""53"" />
      <xs:enumeration value=""54"" />
      <xs:enumeration value=""55"" />
      <xs:enumeration value=""56"" />
      <xs:enumeration value=""57"" />
      <xs:enumeration value=""58"" />
      <xs:enumeration value=""59"" />
      <xs:enumeration value=""60"" />
      <xs:enumeration value=""61"" />
      <xs:enumeration value=""62"" />
      <xs:enumeration value=""63"" />
      <xs:enumeration value=""64"" />
      <xs:enumeration value=""65"" />
      <xs:enumeration value=""66"" />
      <xs:enumeration value=""67"" />
      <xs:enumeration value=""68"" />
      <xs:enumeration value=""69"" />
      <xs:enumeration value=""70"" />
      <xs:enumeration value=""71"" />
      <xs:enumeration value=""72"" />
      <xs:enumeration value=""73"" />
      <xs:enumeration value=""74"" />
      <xs:enumeration value=""75"" />
      <xs:enumeration value=""76"" />
      <xs:enumeration value=""77"" />
      <xs:enumeration value=""78"" />
      <xs:enumeration value=""79"" />
      <xs:enumeration value=""80"" />
      <xs:enumeration value=""81"" />
      <xs:enumeration value=""82"" />
      <xs:enumeration value=""83"" />
      <xs:enumeration value=""84"" />
      <xs:enumeration value=""85"" />
      <xs:enumeration value=""86"" />
      <xs:enumeration value=""87"" />
      <xs:enumeration value=""88"" />
      <xs:enumeration value=""89"" />
      <xs:enumeration value=""90"" />
      <xs:enumeration value=""91"" />
      <xs:enumeration value=""92"" />
      <xs:enumeration value=""93"" />
      <xs:enumeration value=""94"" />
      <xs:enumeration value=""95"" />
      <xs:enumeration value=""96"" />
      <xs:enumeration value=""97"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""X12_ID_309"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""10"" />
      <xs:enumeration value=""11"" />
      <xs:enumeration value=""12"" />
      <xs:enumeration value=""13"" />
      <xs:enumeration value=""14"" />
      <xs:enumeration value=""18"" />
      <xs:enumeration value=""19"" />
      <xs:enumeration value=""20"" />
      <xs:enumeration value=""21"" />
      <xs:enumeration value=""22"" />
      <xs:enumeration value=""27"" />
      <xs:enumeration value=""28"" />
      <xs:enumeration value=""29"" />
      <xs:enumeration value=""30"" />
      <xs:enumeration value=""31"" />
      <xs:enumeration value=""32"" />
      <xs:enumeration value=""33"" />
      <xs:enumeration value=""34"" />
      <xs:enumeration value=""35"" />
      <xs:enumeration value=""36"" />
      <xs:enumeration value=""38"" />
      <xs:enumeration value=""39"" />
      <xs:enumeration value=""40"" />
      <xs:enumeration value=""41"" />
      <xs:enumeration value=""42"" />
      <xs:enumeration value=""43"" />
      <xs:enumeration value=""44"" />
      <xs:enumeration value=""45"" />
      <xs:enumeration value=""46"" />
      <xs:enumeration value=""47"" />
      <xs:enumeration value=""48"" />
      <xs:enumeration value=""49"" />
      <xs:enumeration value=""50"" />
      <xs:enumeration value=""52"" />
      <xs:enumeration value=""53"" />
      <xs:enumeration value=""54"" />
      <xs:enumeration value=""55"" />
      <xs:enumeration value=""57"" />
      <xs:enumeration value=""58"" />
      <xs:enumeration value=""59"" />
      <xs:enumeration value=""60"" />
      <xs:enumeration value=""93"" />
      <xs:enumeration value=""94"" />
      <xs:enumeration value=""A"" />
      <xs:enumeration value=""A1"" />
      <xs:enumeration value=""AA"" />
      <xs:enumeration value=""AC"" />
      <xs:enumeration value=""AP"" />
      <xs:enumeration value=""AR"" />
      <xs:enumeration value=""B"" />
      <xs:enumeration value=""B1"" />
      <xs:enumeration value=""BE"" />
      <xs:enumeration value=""BL"" />
      <xs:enumeration value=""BS"" />
      <xs:enumeration value=""C"" />
      <xs:enumeration value=""C2"" />
      <xs:enumeration value=""CA"" />
      <xs:enumeration value=""CB"" />
      <xs:enumeration value=""CC"" />
      <xs:enumeration value=""CD"" />
      <xs:enumeration value=""CE"" />
      <xs:enumeration value=""CI"" />
      <xs:enumeration value=""CL"" />
      <xs:enumeration value=""CO"" />
      <xs:enumeration value=""CR"" />
      <xs:enumeration value=""CS"" />
      <xs:enumeration value=""CY"" />
      <xs:enumeration value=""D"" />
      <xs:enumeration value=""DC"" />
      <xs:enumeration value=""DE"" />
      <xs:enumeration value=""DL"" />
      <xs:enumeration value=""DO"" />
      <xs:enumeration value=""DP"" />
      <xs:enumeration value=""DR"" />
      <xs:enumeration value=""DT"" />
      <xs:enumeration value=""E"" />
      <xs:enumeration value=""EA"" />
      <xs:enumeration value=""EL"" />
      <xs:enumeration value=""F"" />
      <xs:enumeration value=""FA"" />
      <xs:enumeration value=""FE"" />
      <xs:enumeration value=""FF"" />
      <xs:enumeration value=""FI"" />
      <xs:enumeration value=""FR"" />
      <xs:enumeration value=""FS"" />
      <xs:enumeration value=""FT"" />
      <xs:enumeration value=""FV"" />
      <xs:enumeration value=""GL"" />
      <xs:enumeration value=""H"" />
      <xs:enumeration value=""I"" />
      <xs:enumeration value=""IA"" />
      <xs:enumeration value=""IB"" />
      <xs:enumeration value=""IM"" />
      <xs:enumeration value=""IP"" />
      <xs:enumeration value=""IS"" />
      <xs:enumeration value=""IT"" />
      <xs:enumeration value=""K"" />
      <xs:enumeration value=""KE"" />
      <xs:enumeration value=""KL"" />
      <xs:enumeration value=""KP"" />
      <xs:enumeration value=""L"" />
      <xs:enumeration value=""LO"" />
      <xs:enumeration value=""M"" />
      <xs:enumeration value=""MI"" />
      <xs:enumeration value=""MS"" />
      <xs:enumeration value=""MZ"" />
      <xs:enumeration value=""NS"" />
      <xs:enumeration value=""O"" />
      <xs:enumeration value=""OA"" />
      <xs:enumeration value=""OF"" />
      <xs:enumeration value=""OL"" />
      <xs:enumeration value=""OP"" />
      <xs:enumeration value=""OR"" />
      <xs:enumeration value=""OV"" />
      <xs:enumeration value=""P"" />
      <xs:enumeration value=""PA"" />
      <xs:enumeration value=""PB"" />
      <xs:enumeration value=""PC"" />
      <xs:enumeration value=""PD"" />
      <xs:enumeration value=""PE"" />
      <xs:enumeration value=""PF"" />
      <xs:enumeration value=""PG"" />
      <xs:enumeration value=""PH"" />
      <xs:enumeration value=""PL"" />
      <xs:enumeration value=""PO"" />
      <xs:enumeration value=""PP"" />
      <xs:enumeration value=""PQ"" />
      <xs:enumeration value=""PR"" />
      <xs:enumeration value=""PS"" />
      <xs:enumeration value=""PT"" />
      <xs:enumeration value=""PU"" />
      <xs:enumeration value=""RA"" />
      <xs:enumeration value=""RC"" />
      <xs:enumeration value=""RE"" />
      <xs:enumeration value=""RG"" />
      <xs:enumeration value=""RJ"" />
      <xs:enumeration value=""RL"" />
      <xs:enumeration value=""RS"" />
      <xs:enumeration value=""RT"" />
      <xs:enumeration value=""SA"" />
      <xs:enumeration value=""SB"" />
      <xs:enumeration value=""SC"" />
      <xs:enumeration value=""SD"" />
      <xs:enumeration value=""SE"" />
      <xs:enumeration value=""SG"" />
      <xs:enumeration value=""SH"" />
      <xs:enumeration value=""SL"" />
      <xs:enumeration value=""SN"" />
      <xs:enumeration value=""SP"" />
      <xs:enumeration value=""SS"" />
      <xs:enumeration value=""ST"" />
      <xs:enumeration value=""SW"" />
      <xs:enumeration value=""TA"" />
      <xs:enumeration value=""TC"" />
      <xs:enumeration value=""TL"" />
      <xs:enumeration value=""TM"" />
      <xs:enumeration value=""TN"" />
      <xs:enumeration value=""TP"" />
      <xs:enumeration value=""TR"" />
      <xs:enumeration value=""TX"" />
      <xs:enumeration value=""UN"" />
      <xs:enumeration value=""UR"" />
      <xs:enumeration value=""UT"" />
      <xs:enumeration value=""VA"" />
      <xs:enumeration value=""VI"" />
      <xs:enumeration value=""VS"" />
      <xs:enumeration value=""W"" />
      <xs:enumeration value=""WF"" />
      <xs:enumeration value=""WH"" />
      <xs:enumeration value=""WI"" />
      <xs:enumeration value=""ZN"" />
      <xs:enumeration value=""ZZ"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""X12_ID_366"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""1A"" />
      <xs:enumeration value=""1B"" />
      <xs:enumeration value=""1C"" />
      <xs:enumeration value=""1D"" />
      <xs:enumeration value=""1E"" />
      <xs:enumeration value=""1F"" />
      <xs:enumeration value=""1G"" />
      <xs:enumeration value=""1H"" />
      <xs:enumeration value=""3A"" />
      <xs:enumeration value=""A1"" />
      <xs:enumeration value=""A2"" />
      <xs:enumeration value=""A3"" />
      <xs:enumeration value=""A4"" />
      <xs:enumeration value=""A5"" />
      <xs:enumeration value=""AA"" />
      <xs:enumeration value=""AB"" />
      <xs:enumeration value=""AC"" />
      <xs:enumeration value=""AD"" />
      <xs:enumeration value=""AE"" />
      <xs:enumeration value=""AF"" />
      <xs:enumeration value=""AG"" />
      <xs:enumeration value=""AH"" />
      <xs:enumeration value=""AI"" />
      <xs:enumeration value=""AL"" />
      <xs:enumeration value=""AM"" />
      <xs:enumeration value=""AN"" />
      <xs:enumeration value=""AP"" />
      <xs:enumeration value=""AR"" />
      <xs:enumeration value=""AS"" />
      <xs:enumeration value=""AT"" />
      <xs:enumeration value=""AU"" />
      <xs:enumeration value=""AV"" />
      <xs:enumeration value=""BA"" />
      <xs:enumeration value=""BB"" />
      <xs:enumeration value=""BC"" />
      <xs:enumeration value=""BD"" />
      <xs:enumeration value=""BI"" />
      <xs:enumeration value=""BJ"" />
      <xs:enumeration value=""BK"" />
      <xs:enumeration value=""BL"" />
      <xs:enumeration value=""BM"" />
      <xs:enumeration value=""BP"" />
      <xs:enumeration value=""BS"" />
      <xs:enumeration value=""BU"" />
      <xs:enumeration value=""C2"" />
      <xs:enumeration value=""CA"" />
      <xs:enumeration value=""CB"" />
      <xs:enumeration value=""CC"" />
      <xs:enumeration value=""CD"" />
      <xs:enumeration value=""CE"" />
      <xs:enumeration value=""CF"" />
      <xs:enumeration value=""CG"" />
      <xs:enumeration value=""CH"" />
      <xs:enumeration value=""CI"" />
      <xs:enumeration value=""CJ"" />
      <xs:enumeration value=""CK"" />
      <xs:enumeration value=""CL"" />
      <xs:enumeration value=""CM"" />
      <xs:enumeration value=""CN"" />
      <xs:enumeration value=""CO"" />
      <xs:enumeration value=""CP"" />
      <xs:enumeration value=""CR"" />
      <xs:enumeration value=""CS"" />
      <xs:enumeration value=""CT"" />
      <xs:enumeration value=""CU"" />
      <xs:enumeration value=""CV"" />
      <xs:enumeration value=""CW"" />
      <xs:enumeration value=""CX"" />
      <xs:enumeration value=""CY"" />
      <xs:enumeration value=""CZ"" />
      <xs:enumeration value=""DA"" />
      <xs:enumeration value=""DC"" />
      <xs:enumeration value=""DD"" />
      <xs:enumeration value=""DE"" />
      <xs:enumeration value=""DF"" />
      <xs:enumeration value=""DI"" />
      <xs:enumeration value=""DM"" />
      <xs:enumeration value=""DN"" />
      <xs:enumeration value=""DV"" />
      <xs:enumeration value=""E1"" />
      <xs:enumeration value=""E2"" />
      <xs:enumeration value=""EA"" />
      <xs:enumeration value=""EB"" />
      <xs:enumeration value=""EC"" />
      <xs:enumeration value=""ED"" />
      <xs:enumeration value=""EF"" />
      <xs:enumeration value=""EG"" />
      <xs:enumeration value=""EM"" />
      <xs:enumeration value=""EN"" />
      <xs:enumeration value=""EO"" />
      <xs:enumeration value=""EP"" />
      <xs:enumeration value=""ES"" />
      <xs:enumeration value=""EV"" />
      <xs:enumeration value=""EX"" />
      <xs:enumeration value=""FA"" />
      <xs:enumeration value=""FB"" />
      <xs:enumeration value=""FC"" />
      <xs:enumeration value=""FD"" />
      <xs:enumeration value=""FF"" />
      <xs:enumeration value=""FL"" />
      <xs:enumeration value=""FM"" />
      <xs:enumeration value=""FN"" />
      <xs:enumeration value=""FO"" />
      <xs:enumeration value=""FP"" />
      <xs:enumeration value=""FQ"" />
      <xs:enumeration value=""FR"" />
      <xs:enumeration value=""GA"" />
      <xs:enumeration value=""GB"" />
      <xs:enumeration value=""GC"" />
      <xs:enumeration value=""GE"" />
      <xs:enumeration value=""GR"" />
      <xs:enumeration value=""HM"" />
      <xs:enumeration value=""HR"" />
      <xs:enumeration value=""IC"" />
      <xs:enumeration value=""IO"" />
      <xs:enumeration value=""IP"" />
      <xs:enumeration value=""IS"" />
      <xs:enumeration value=""KA"" />
      <xs:enumeration value=""KB"" />
      <xs:enumeration value=""KC"" />
      <xs:enumeration value=""KP"" />
      <xs:enumeration value=""KT"" />
      <xs:enumeration value=""LD"" />
      <xs:enumeration value=""MA"" />
      <xs:enumeration value=""MB"" />
      <xs:enumeration value=""MC"" />
      <xs:enumeration value=""MD"" />
      <xs:enumeration value=""ME"" />
      <xs:enumeration value=""MG"" />
      <xs:enumeration value=""MK"" />
      <xs:enumeration value=""ML"" />
      <xs:enumeration value=""MM"" />
      <xs:enumeration value=""NA"" />
      <xs:enumeration value=""NC"" />
      <xs:enumeration value=""NP"" />
      <xs:enumeration value=""NT"" />
      <xs:enumeration value=""OA"" />
      <xs:enumeration value=""OC"" />
      <xs:enumeration value=""OD"" />
      <xs:enumeration value=""OS"" />
      <xs:enumeration value=""OW"" />
      <xs:enumeration value=""PA"" />
      <xs:enumeration value=""PB"" />
      <xs:enumeration value=""PC"" />
      <xs:enumeration value=""PD"" />
      <xs:enumeration value=""PE"" />
      <xs:enumeration value=""PF"" />
      <xs:enumeration value=""PG"" />
      <xs:enumeration value=""PH"" />
      <xs:enumeration value=""PI"" />
      <xs:enumeration value=""PJ"" />
      <xs:enumeration value=""PK"" />
      <xs:enumeration value=""PL"" />
      <xs:enumeration value=""PM"" />
      <xs:enumeration value=""PN"" />
      <xs:enumeration value=""PO"" />
      <xs:enumeration value=""PP"" />
      <xs:enumeration value=""PQ"" />
      <xs:enumeration value=""PR"" />
      <xs:enumeration value=""PS"" />
      <xs:enumeration value=""PT"" />
      <xs:enumeration value=""PU"" />
      <xs:enumeration value=""PV"" />
      <xs:enumeration value=""PW"" />
      <xs:enumeration value=""PX"" />
      <xs:enumeration value=""PY"" />
      <xs:enumeration value=""PZ"" />
      <xs:enumeration value=""QA"" />
      <xs:enumeration value=""QC"" />
      <xs:enumeration value=""QI"" />
      <xs:enumeration value=""QM"" />
      <xs:enumeration value=""QP"" />
      <xs:enumeration value=""QR"" />
      <xs:enumeration value=""QY"" />
      <xs:enumeration value=""RA"" />
      <xs:enumeration value=""RB"" />
      <xs:enumeration value=""RC"" />
      <xs:enumeration value=""RD"" />
      <xs:enumeration value=""RE"" />
      <xs:enumeration value=""RF"" />
      <xs:enumeration value=""RG"" />
      <xs:enumeration value=""RP"" />
      <xs:enumeration value=""RQ"" />
      <xs:enumeration value=""RS"" />
      <xs:enumeration value=""RZ"" />
      <xs:enumeration value=""SA"" />
      <xs:enumeration value=""SB"" />
      <xs:enumeration value=""SC"" />
      <xs:enumeration value=""SD"" />
      <xs:enumeration value=""SE"" />
      <xs:enumeration value=""SF"" />
      <xs:enumeration value=""SG"" />
      <xs:enumeration value=""SH"" />
      <xs:enumeration value=""SI"" />
      <xs:enumeration value=""SJ"" />
      <xs:enumeration value=""SK"" />
      <xs:enumeration value=""SL"" />
      <xs:enumeration value=""SM"" />
      <xs:enumeration value=""SN"" />
      <xs:enumeration value=""SO"" />
      <xs:enumeration value=""SP"" />
      <xs:enumeration value=""SQ"" />
      <xs:enumeration value=""SR"" />
      <xs:enumeration value=""SS"" />
      <xs:enumeration value=""ST"" />
      <xs:enumeration value=""SU"" />
      <xs:enumeration value=""SV"" />
      <xs:enumeration value=""SW"" />
      <xs:enumeration value=""SY"" />
      <xs:enumeration value=""TA"" />
      <xs:enumeration value=""TB"" />
      <xs:enumeration value=""TC"" />
      <xs:enumeration value=""TD"" />
      <xs:enumeration value=""TE"" />
      <xs:enumeration value=""TH"" />
      <xs:enumeration value=""TM"" />
      <xs:enumeration value=""TN"" />
      <xs:enumeration value=""TP"" />
      <xs:enumeration value=""TR"" />
      <xs:enumeration value=""TY"" />
      <xs:enumeration value=""UG"" />
      <xs:enumeration value=""UP"" />
      <xs:enumeration value=""UQ"" />
      <xs:enumeration value=""UR"" />
      <xs:enumeration value=""VM"" />
      <xs:enumeration value=""VP"" />
      <xs:enumeration value=""WH"" />
      <xs:enumeration value=""WI"" />
      <xs:enumeration value=""WR"" />
      <xs:enumeration value=""ZZ"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""X12_ID_365"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""AA"" />
      <xs:enumeration value=""AB"" />
      <xs:enumeration value=""AC"" />
      <xs:enumeration value=""AD"" />
      <xs:enumeration value=""AP"" />
      <xs:enumeration value=""AS"" />
      <xs:enumeration value=""AU"" />
      <xs:enumeration value=""BN"" />
      <xs:enumeration value=""BT"" />
      <xs:enumeration value=""CA"" />
      <xs:enumeration value=""CP"" />
      <xs:enumeration value=""DN"" />
      <xs:enumeration value=""ED"" />
      <xs:enumeration value=""EM"" />
      <xs:enumeration value=""EX"" />
      <xs:enumeration value=""FT"" />
      <xs:enumeration value=""FU"" />
      <xs:enumeration value=""FX"" />
      <xs:enumeration value=""HF"" />
      <xs:enumeration value=""HP"" />
      <xs:enumeration value=""IT"" />
      <xs:enumeration value=""MN"" />
      <xs:enumeration value=""NP"" />
      <xs:enumeration value=""OF"" />
      <xs:enumeration value=""OT"" />
      <xs:enumeration value=""PA"" />
      <xs:enumeration value=""PC"" />
      <xs:enumeration value=""PP"" />
      <xs:enumeration value=""PS"" />
      <xs:enumeration value=""SP"" />
      <xs:enumeration value=""TE"" />
      <xs:enumeration value=""TL"" />
      <xs:enumeration value=""TM"" />
      <xs:enumeration value=""TN"" />
      <xs:enumeration value=""TX"" />
      <xs:enumeration value=""UR"" />
      <xs:enumeration value=""VM"" />
      <xs:enumeration value=""WC"" />
      <xs:enumeration value=""WF"" />
      <xs:enumeration value=""WP"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""X12_ID_128"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""01"" />
      <xs:enumeration value=""02"" />
      <xs:enumeration value=""03"" />
      <xs:enumeration value=""04"" />
      <xs:enumeration value=""05"" />
      <xs:enumeration value=""06"" />
      <xs:enumeration value=""07"" />
      <xs:enumeration value=""08"" />
      <xs:enumeration value=""09"" />
      <xs:enumeration value=""0A"" />
      <xs:enumeration value=""0B"" />
      <xs:enumeration value=""0D"" />
      <xs:enumeration value=""0E"" />
      <xs:enumeration value=""0F"" />
      <xs:enumeration value=""0G"" />
      <xs:enumeration value=""0H"" />
      <xs:enumeration value=""0I"" />
      <xs:enumeration value=""0J"" />
      <xs:enumeration value=""0K"" />
      <xs:enumeration value=""0L"" />
      <xs:enumeration value=""0M"" />
      <xs:enumeration value=""0N"" />
      <xs:enumeration value=""0P"" />
      <xs:enumeration value=""10"" />
      <xs:enumeration value=""11"" />
      <xs:enumeration value=""12"" />
      <xs:enumeration value=""13"" />
      <xs:enumeration value=""14"" />
      <xs:enumeration value=""15"" />
      <xs:enumeration value=""16"" />
      <xs:enumeration value=""17"" />
      <xs:enumeration value=""18"" />
      <xs:enumeration value=""19"" />
      <xs:enumeration value=""1A"" />
      <xs:enumeration value=""1B"" />
      <xs:enumeration value=""1C"" />
      <xs:enumeration value=""1D"" />
      <xs:enumeration value=""1E"" />
      <xs:enumeration value=""1F"" />
      <xs:enumeration value=""1G"" />
      <xs:enumeration value=""1H"" />
      <xs:enumeration value=""1I"" />
      <xs:enumeration value=""1J"" />
      <xs:enumeration value=""1K"" />
      <xs:enumeration value=""1L"" />
      <xs:enumeration value=""1M"" />
      <xs:enumeration value=""1N"" />
      <xs:enumeration value=""1O"" />
      <xs:enumeration value=""1P"" />
      <xs:enumeration value=""1Q"" />
      <xs:enumeration value=""1R"" />
      <xs:enumeration value=""1S"" />
      <xs:enumeration value=""1T"" />
      <xs:enumeration value=""1U"" />
      <xs:enumeration value=""1V"" />
      <xs:enumeration value=""1W"" />
      <xs:enumeration value=""1X"" />
      <xs:enumeration value=""1Y"" />
      <xs:enumeration value=""1Z"" />
      <xs:enumeration value=""20"" />
      <xs:enumeration value=""21"" />
      <xs:enumeration value=""22"" />
      <xs:enumeration value=""23"" />
      <xs:enumeration value=""24"" />
      <xs:enumeration value=""25"" />
      <xs:enumeration value=""26"" />
      <xs:enumeration value=""27"" />
      <xs:enumeration value=""28"" />
      <xs:enumeration value=""29"" />
      <xs:enumeration value=""2A"" />
      <xs:enumeration value=""2B"" />
      <xs:enumeration value=""2C"" />
      <xs:enumeration value=""2D"" />
      <xs:enumeration value=""2E"" />
      <xs:enumeration value=""2F"" />
      <xs:enumeration value=""2G"" />
      <xs:enumeration value=""2H"" />
      <xs:enumeration value=""2I"" />
      <xs:enumeration value=""2J"" />
      <xs:enumeration value=""2K"" />
      <xs:enumeration value=""2L"" />
      <xs:enumeration value=""2M"" />
      <xs:enumeration value=""2N"" />
      <xs:enumeration value=""2O"" />
      <xs:enumeration value=""2P"" />
      <xs:enumeration value=""2Q"" />
      <xs:enumeration value=""2R"" />
      <xs:enumeration value=""2S"" />
      <xs:enumeration value=""2T"" />
      <xs:enumeration value=""2U"" />
      <xs:enumeration value=""2V"" />
      <xs:enumeration value=""2W"" />
      <xs:enumeration value=""2X"" />
      <xs:enumeration value=""2Y"" />
      <xs:enumeration value=""2Z"" />
      <xs:enumeration value=""30"" />
      <xs:enumeration value=""31"" />
      <xs:enumeration value=""32"" />
      <xs:enumeration value=""33"" />
      <xs:enumeration value=""34"" />
      <xs:enumeration value=""35"" />
      <xs:enumeration value=""36"" />
      <xs:enumeration value=""37"" />
      <xs:enumeration value=""38"" />
      <xs:enumeration value=""39"" />
      <xs:enumeration value=""3A"" />
      <xs:enumeration value=""3B"" />
      <xs:enumeration value=""3C"" />
      <xs:enumeration value=""3D"" />
      <xs:enumeration value=""3E"" />
      <xs:enumeration value=""3F"" />
      <xs:enumeration value=""3G"" />
      <xs:enumeration value=""3H"" />
      <xs:enumeration value=""3I"" />
      <xs:enumeration value=""3J"" />
      <xs:enumeration value=""3K"" />
      <xs:enumeration value=""3L"" />
      <xs:enumeration value=""3M"" />
      <xs:enumeration value=""3N"" />
      <xs:enumeration value=""3O"" />
      <xs:enumeration value=""3P"" />
      <xs:enumeration value=""3Q"" />
      <xs:enumeration value=""3R"" />
      <xs:enumeration value=""3S"" />
      <xs:enumeration value=""3T"" />
      <xs:enumeration value=""3U"" />
      <xs:enumeration value=""3V"" />
      <xs:enumeration value=""3W"" />
      <xs:enumeration value=""3X"" />
      <xs:enumeration value=""3Y"" />
      <xs:enumeration value=""3Z"" />
      <xs:enumeration value=""40"" />
      <xs:enumeration value=""41"" />
      <xs:enumeration value=""42"" />
      <xs:enumeration value=""43"" />
      <xs:enumeration value=""44"" />
      <xs:enumeration value=""45"" />
      <xs:enumeration value=""46"" />
      <xs:enumeration value=""47"" />
      <xs:enumeration value=""48"" />
      <xs:enumeration value=""49"" />
      <xs:enumeration value=""4A"" />
      <xs:enumeration value=""4B"" />
      <xs:enumeration value=""4C"" />
      <xs:enumeration value=""4D"" />
      <xs:enumeration value=""4E"" />
      <xs:enumeration value=""4F"" />
      <xs:enumeration value=""4G"" />
      <xs:enumeration value=""4H"" />
      <xs:enumeration value=""4I"" />
      <xs:enumeration value=""4J"" />
      <xs:enumeration value=""4K"" />
      <xs:enumeration value=""4L"" />
      <xs:enumeration value=""4M"" />
      <xs:enumeration value=""4N"" />
      <xs:enumeration value=""4O"" />
      <xs:enumeration value=""4P"" />
      <xs:enumeration value=""4Q"" />
      <xs:enumeration value=""4R"" />
      <xs:enumeration value=""4S"" />
      <xs:enumeration value=""4T"" />
      <xs:enumeration value=""4U"" />
      <xs:enumeration value=""4V"" />
      <xs:enumeration value=""4W"" />
      <xs:enumeration value=""4X"" />
      <xs:enumeration value=""4Y"" />
      <xs:enumeration value=""4Z"" />
      <xs:enumeration value=""50"" />
      <xs:enumeration value=""51"" />
      <xs:enumeration value=""52"" />
      <xs:enumeration value=""53"" />
      <xs:enumeration value=""54"" />
      <xs:enumeration value=""55"" />
      <xs:enumeration value=""56"" />
      <xs:enumeration value=""57"" />
      <xs:enumeration value=""58"" />
      <xs:enumeration value=""59"" />
      <xs:enumeration value=""5A"" />
      <xs:enumeration value=""5B"" />
      <xs:enumeration value=""5C"" />
      <xs:enumeration value=""5D"" />
      <xs:enumeration value=""5E"" />
      <xs:enumeration value=""5F"" />
      <xs:enumeration value=""5G"" />
      <xs:enumeration value=""5H"" />
      <xs:enumeration value=""5I"" />
      <xs:enumeration value=""5J"" />
      <xs:enumeration value=""5K"" />
      <xs:enumeration value=""5L"" />
      <xs:enumeration value=""5M"" />
      <xs:enumeration value=""5N"" />
      <xs:enumeration value=""5O"" />
      <xs:enumeration value=""5P"" />
      <xs:enumeration value=""5Q"" />
      <xs:enumeration value=""5R"" />
      <xs:enumeration value=""5S"" />
      <xs:enumeration value=""5T"" />
      <xs:enumeration value=""5U"" />
      <xs:enumeration value=""5V"" />
      <xs:enumeration value=""5W"" />
      <xs:enumeration value=""5X"" />
      <xs:enumeration value=""5Y"" />
      <xs:enumeration value=""5Z"" />
      <xs:enumeration value=""60"" />
      <xs:enumeration value=""61"" />
      <xs:enumeration value=""63"" />
      <xs:enumeration value=""64"" />
      <xs:enumeration value=""65"" />
      <xs:enumeration value=""66"" />
      <xs:enumeration value=""67"" />
      <xs:enumeration value=""68"" />
      <xs:enumeration value=""69"" />
      <xs:enumeration value=""6A"" />
      <xs:enumeration value=""6B"" />
      <xs:enumeration value=""6C"" />
      <xs:enumeration value=""6D"" />
      <xs:enumeration value=""6E"" />
      <xs:enumeration value=""6F"" />
      <xs:enumeration value=""6G"" />
      <xs:enumeration value=""6H"" />
      <xs:enumeration value=""6I"" />
      <xs:enumeration value=""6J"" />
      <xs:enumeration value=""6K"" />
      <xs:enumeration value=""6L"" />
      <xs:enumeration value=""6M"" />
      <xs:enumeration value=""6N"" />
      <xs:enumeration value=""6O"" />
      <xs:enumeration value=""6P"" />
      <xs:enumeration value=""6Q"" />
      <xs:enumeration value=""6R"" />
      <xs:enumeration value=""6S"" />
      <xs:enumeration value=""6T"" />
      <xs:enumeration value=""6U"" />
      <xs:enumeration value=""6V"" />
      <xs:enumeration value=""6W"" />
      <xs:enumeration value=""6X"" />
      <xs:enumeration value=""6Y"" />
      <xs:enumeration value=""6Z"" />
      <xs:enumeration value=""70"" />
      <xs:enumeration value=""71"" />
      <xs:enumeration value=""72"" />
      <xs:enumeration value=""73"" />
      <xs:enumeration value=""74"" />
      <xs:enumeration value=""75"" />
      <xs:enumeration value=""76"" />
      <xs:enumeration value=""77"" />
      <xs:enumeration value=""78"" />
      <xs:enumeration value=""79"" />
      <xs:enumeration value=""7A"" />
      <xs:enumeration value=""7B"" />
      <xs:enumeration value=""7C"" />
      <xs:enumeration value=""7D"" />
      <xs:enumeration value=""7E"" />
      <xs:enumeration value=""7F"" />
      <xs:enumeration value=""7G"" />
      <xs:enumeration value=""7H"" />
      <xs:enumeration value=""7I"" />
      <xs:enumeration value=""7J"" />
      <xs:enumeration value=""7K"" />
      <xs:enumeration value=""7L"" />
      <xs:enumeration value=""7M"" />
      <xs:enumeration value=""7N"" />
      <xs:enumeration value=""7O"" />
      <xs:enumeration value=""7P"" />
      <xs:enumeration value=""7Q"" />
      <xs:enumeration value=""7R"" />
      <xs:enumeration value=""7S"" />
      <xs:enumeration value=""7T"" />
      <xs:enumeration value=""7U"" />
      <xs:enumeration value=""7W"" />
      <xs:enumeration value=""7X"" />
      <xs:enumeration value=""7Y"" />
      <xs:enumeration value=""7Z"" />
      <xs:enumeration value=""80"" />
      <xs:enumeration value=""81"" />
      <xs:enumeration value=""82"" />
      <xs:enumeration value=""83"" />
      <xs:enumeration value=""84"" />
      <xs:enumeration value=""85"" />
      <xs:enumeration value=""86"" />
      <xs:enumeration value=""87"" />
      <xs:enumeration value=""88"" />
      <xs:enumeration value=""89"" />
      <xs:enumeration value=""8A"" />
      <xs:enumeration value=""8B"" />
      <xs:enumeration value=""8C"" />
      <xs:enumeration value=""8D"" />
      <xs:enumeration value=""8E"" />
      <xs:enumeration value=""8F"" />
      <xs:enumeration value=""8G"" />
      <xs:enumeration value=""8H"" />
      <xs:enumeration value=""8I"" />
      <xs:enumeration value=""8J"" />
      <xs:enumeration value=""8K"" />
      <xs:enumeration value=""8L"" />
      <xs:enumeration value=""8M"" />
      <xs:enumeration value=""8N"" />
      <xs:enumeration value=""8O"" />
      <xs:enumeration value=""8P"" />
      <xs:enumeration value=""8Q"" />
      <xs:enumeration value=""8R"" />
      <xs:enumeration value=""8S"" />
      <xs:enumeration value=""8U"" />
      <xs:enumeration value=""8V"" />
      <xs:enumeration value=""8W"" />
      <xs:enumeration value=""8X"" />
      <xs:enumeration value=""8Y"" />
      <xs:enumeration value=""8Z"" />
      <xs:enumeration value=""90"" />
      <xs:enumeration value=""91"" />
      <xs:enumeration value=""92"" />
      <xs:enumeration value=""93"" />
      <xs:enumeration value=""94"" />
      <xs:enumeration value=""95"" />
      <xs:enumeration value=""96"" />
      <xs:enumeration value=""97"" />
      <xs:enumeration value=""98"" />
      <xs:enumeration value=""99"" />
      <xs:enumeration value=""9A"" />
      <xs:enumeration value=""9B"" />
      <xs:enumeration value=""9C"" />
      <xs:enumeration value=""9D"" />
      <xs:enumeration value=""9E"" />
      <xs:enumeration value=""9F"" />
      <xs:enumeration value=""9G"" />
      <xs:enumeration value=""9H"" />
      <xs:enumeration value=""9I"" />
      <xs:enumeration value=""9J"" />
      <xs:enumeration value=""9K"" />
      <xs:enumeration value=""9L"" />
      <xs:enumeration value=""9M"" />
      <xs:enumeration value=""9N"" />
      <xs:enumeration value=""9P"" />
      <xs:enumeration value=""9Q"" />
      <xs:enumeration value=""9R"" />
      <xs:enumeration value=""9S"" />
      <xs:enumeration value=""9T"" />
      <xs:enumeration value=""9U"" />
      <xs:enumeration value=""9V"" />
      <xs:enumeration value=""9W"" />
      <xs:enumeration value=""9X"" />
      <xs:enumeration value=""9Y"" />
      <xs:enumeration value=""9Z"" />
      <xs:enumeration value=""A0"" />
      <xs:enumeration value=""A1"" />
      <xs:enumeration value=""A2"" />
      <xs:enumeration value=""A3"" />
      <xs:enumeration value=""A4"" />
      <xs:enumeration value=""A5"" />
      <xs:enumeration value=""A6"" />
      <xs:enumeration value=""A7"" />
      <xs:enumeration value=""A8"" />
      <xs:enumeration value=""A9"" />
      <xs:enumeration value=""AA"" />
      <xs:enumeration value=""AAA"" />
      <xs:enumeration value=""AAB"" />
      <xs:enumeration value=""AAC"" />
      <xs:enumeration value=""AAD"" />
      <xs:enumeration value=""AAE"" />
      <xs:enumeration value=""AAF"" />
      <xs:enumeration value=""AAG"" />
      <xs:enumeration value=""AAH"" />
      <xs:enumeration value=""AAI"" />
      <xs:enumeration value=""AAJ"" />
      <xs:enumeration value=""AAK"" />
      <xs:enumeration value=""AAL"" />
      <xs:enumeration value=""AAM"" />
      <xs:enumeration value=""AAN"" />
      <xs:enumeration value=""AAO"" />
      <xs:enumeration value=""AAP"" />
      <xs:enumeration value=""AAQ"" />
      <xs:enumeration value=""AAR"" />
      <xs:enumeration value=""AAS"" />
      <xs:enumeration value=""AAT"" />
      <xs:enumeration value=""AAU"" />
      <xs:enumeration value=""AAV"" />
      <xs:enumeration value=""AAW"" />
      <xs:enumeration value=""AAX"" />
      <xs:enumeration value=""AAY"" />
      <xs:enumeration value=""AAZ"" />
      <xs:enumeration value=""AB"" />
      <xs:enumeration value=""ABA"" />
      <xs:enumeration value=""ABB"" />
      <xs:enumeration value=""ABC"" />
      <xs:enumeration value=""ABD"" />
      <xs:enumeration value=""ABE"" />
      <xs:enumeration value=""ABF"" />
      <xs:enumeration value=""ABG"" />
      <xs:enumeration value=""ABH"" />
      <xs:enumeration value=""ABJ"" />
      <xs:enumeration value=""ABK"" />
      <xs:enumeration value=""ABL"" />
      <xs:enumeration value=""ABM"" />
      <xs:enumeration value=""ABN"" />
      <xs:enumeration value=""ABO"" />
      <xs:enumeration value=""ABP"" />
      <xs:enumeration value=""ABQ"" />
      <xs:enumeration value=""ABR"" />
      <xs:enumeration value=""ABS"" />
      <xs:enumeration value=""ABT"" />
      <xs:enumeration value=""ABU"" />
      <xs:enumeration value=""ABV"" />
      <xs:enumeration value=""ABY"" />
      <xs:enumeration value=""AC"" />
      <xs:enumeration value=""ACA"" />
      <xs:enumeration value=""ACB"" />
      <xs:enumeration value=""ACC"" />
      <xs:enumeration value=""ACD"" />
      <xs:enumeration value=""ACE"" />
      <xs:enumeration value=""ACF"" />
      <xs:enumeration value=""ACG"" />
      <xs:enumeration value=""ACH"" />
      <xs:enumeration value=""ACI"" />
      <xs:enumeration value=""ACJ"" />
      <xs:enumeration value=""ACK"" />
      <xs:enumeration value=""ACR"" />
      <xs:enumeration value=""ACS"" />
      <xs:enumeration value=""ACT"" />
      <xs:enumeration value=""AD"" />
      <xs:enumeration value=""ADA"" />
      <xs:enumeration value=""ADB"" />
      <xs:enumeration value=""ADC"" />
      <xs:enumeration value=""ADD"" />
      <xs:enumeration value=""ADE"" />
      <xs:enumeration value=""ADF"" />
      <xs:enumeration value=""ADG"" />
      <xs:enumeration value=""ADH"" />
      <xs:enumeration value=""ADI"" />
      <xs:enumeration value=""ADM"" />
      <xs:enumeration value=""AE"" />
      <xs:enumeration value=""AEA"" />
      <xs:enumeration value=""AEB"" />
      <xs:enumeration value=""AEC"" />
      <xs:enumeration value=""AED"" />
      <xs:enumeration value=""AEE"" />
      <xs:enumeration value=""AEF"" />
      <xs:enumeration value=""AEG"" />
      <xs:enumeration value=""AEH"" />
      <xs:enumeration value=""AEI"" />
      <xs:enumeration value=""AEJ"" />
      <xs:enumeration value=""AEK"" />
      <xs:enumeration value=""AEL"" />
      <xs:enumeration value=""AEM"" />
      <xs:enumeration value=""AF"" />
      <xs:enumeration value=""AG"" />
      <xs:enumeration value=""AH"" />
      <xs:enumeration value=""AHC"" />
      <xs:enumeration value=""AI"" />
      <xs:enumeration value=""AJ"" />
      <xs:enumeration value=""AK"" />
      <xs:enumeration value=""AL"" />
      <xs:enumeration value=""ALC"" />
      <xs:enumeration value=""ALG"" />
      <xs:enumeration value=""ALH"" />
      <xs:enumeration value=""ALI"" />
      <xs:enumeration value=""ALJ"" />
      <xs:enumeration value=""ALT"" />
      <xs:enumeration value=""AM"" />
      <xs:enumeration value=""AN"" />
      <xs:enumeration value=""AO"" />
      <xs:enumeration value=""AP"" />
      <xs:enumeration value=""API"" />
      <xs:enumeration value=""AQ"" />
      <xs:enumeration value=""AR"" />
      <xs:enumeration value=""AS"" />
      <xs:enumeration value=""ASL"" />
      <xs:enumeration value=""ASP"" />
      <xs:enumeration value=""AST"" />
      <xs:enumeration value=""AT"" />
      <xs:enumeration value=""ATC"" />
      <xs:enumeration value=""AU"" />
      <xs:enumeration value=""AV"" />
      <xs:enumeration value=""AW"" />
      <xs:enumeration value=""AX"" />
      <xs:enumeration value=""AY"" />
      <xs:enumeration value=""AZ"" />
      <xs:enumeration value=""B1"" />
      <xs:enumeration value=""B2"" />
      <xs:enumeration value=""B3"" />
      <xs:enumeration value=""B4"" />
      <xs:enumeration value=""B5"" />
      <xs:enumeration value=""B6"" />
      <xs:enumeration value=""B7"" />
      <xs:enumeration value=""B8"" />
      <xs:enumeration value=""B9"" />
      <xs:enumeration value=""BA"" />
      <xs:enumeration value=""BAA"" />
      <xs:enumeration value=""BAB"" />
      <xs:enumeration value=""BAC"" />
      <xs:enumeration value=""BAD"" />
      <xs:enumeration value=""BAE"" />
      <xs:enumeration value=""BAF"" />
      <xs:enumeration value=""BAG"" />
      <xs:enumeration value=""BAH"" />
      <xs:enumeration value=""BAI"" />
      <xs:enumeration value=""BB"" />
      <xs:enumeration value=""BC"" />
      <xs:enumeration value=""BCI"" />
      <xs:enumeration value=""BD"" />
      <xs:enumeration value=""BE"" />
      <xs:enumeration value=""BF"" />
      <xs:enumeration value=""BG"" />
      <xs:enumeration value=""BH"" />
      <xs:enumeration value=""BI"" />
      <xs:enumeration value=""BJ"" />
      <xs:enumeration value=""BK"" />
      <xs:enumeration value=""BKT"" />
      <xs:enumeration value=""BL"" />
      <xs:enumeration value=""BLT"" />
      <xs:enumeration value=""BM"" />
      <xs:enumeration value=""BMM"" />
      <xs:enumeration value=""BN"" />
      <xs:enumeration value=""BO"" />
      <xs:enumeration value=""BOI"" />
      <xs:enumeration value=""BP"" />
      <xs:enumeration value=""BQ"" />
      <xs:enumeration value=""BR"" />
      <xs:enumeration value=""BS"" />
      <xs:enumeration value=""BT"" />
      <xs:enumeration value=""BU"" />
      <xs:enumeration value=""BV"" />
      <xs:enumeration value=""BW"" />
      <xs:enumeration value=""BX"" />
      <xs:enumeration value=""BY"" />
      <xs:enumeration value=""BZ"" />
      <xs:enumeration value=""C0"" />
      <xs:enumeration value=""C1"" />
      <xs:enumeration value=""C2"" />
      <xs:enumeration value=""C3"" />
      <xs:enumeration value=""C4"" />
      <xs:enumeration value=""C5"" />
      <xs:enumeration value=""C6"" />
      <xs:enumeration value=""C7"" />
      <xs:enumeration value=""C8"" />
      <xs:enumeration value=""C9"" />
      <xs:enumeration value=""CA"" />
      <xs:enumeration value=""CB"" />
      <xs:enumeration value=""CBG"" />
      <xs:enumeration value=""CC"" />
      <xs:enumeration value=""CD"" />
      <xs:enumeration value=""CDN"" />
      <xs:enumeration value=""CE"" />
      <xs:enumeration value=""CF"" />
      <xs:enumeration value=""CG"" />
      <xs:enumeration value=""CH"" />
      <xs:enumeration value=""CI"" />
      <xs:enumeration value=""CIR"" />
      <xs:enumeration value=""CIT"" />
      <xs:enumeration value=""CJ"" />
      <xs:enumeration value=""CK"" />
      <xs:enumeration value=""CL"" />
      <xs:enumeration value=""CM"" />
      <xs:enumeration value=""CMN"" />
      <xs:enumeration value=""CMP"" />
      <xs:enumeration value=""CMT"" />
      <xs:enumeration value=""CN"" />
      <xs:enumeration value=""CNO"" />
      <xs:enumeration value=""CO"" />
      <xs:enumeration value=""COL"" />
      <xs:enumeration value=""COT"" />
      <xs:enumeration value=""CP"" />
      <xs:enumeration value=""CPA"" />
      <xs:enumeration value=""CPT"" />
      <xs:enumeration value=""CQ"" />
      <xs:enumeration value=""CR"" />
      <xs:enumeration value=""CRN"" />
      <xs:enumeration value=""CRS"" />
      <xs:enumeration value=""CS"" />
      <xs:enumeration value=""CSC"" />
      <xs:enumeration value=""CSG"" />
      <xs:enumeration value=""CST"" />
      <xs:enumeration value=""CT"" />
      <xs:enumeration value=""CTS"" />
      <xs:enumeration value=""CU"" />
      <xs:enumeration value=""CV"" />
      <xs:enumeration value=""CW"" />
      <xs:enumeration value=""CX"" />
      <xs:enumeration value=""CY"" />
      <xs:enumeration value=""CYC"" />
      <xs:enumeration value=""CZ"" />
      <xs:enumeration value=""D0"" />
      <xs:enumeration value=""D1"" />
      <xs:enumeration value=""D2"" />
      <xs:enumeration value=""D3"" />
      <xs:enumeration value=""D4"" />
      <xs:enumeration value=""D5"" />
      <xs:enumeration value=""D6"" />
      <xs:enumeration value=""D7"" />
      <xs:enumeration value=""D8"" />
      <xs:enumeration value=""D9"" />
      <xs:enumeration value=""DA"" />
      <xs:enumeration value=""DB"" />
      <xs:enumeration value=""DC"" />
      <xs:enumeration value=""DD"" />
      <xs:enumeration value=""DE"" />
      <xs:enumeration value=""DF"" />
      <xs:enumeration value=""DG"" />
      <xs:enumeration value=""DH"" />
      <xs:enumeration value=""DHH"" />
      <xs:enumeration value=""DI"" />
      <xs:enumeration value=""DIS"" />
      <xs:enumeration value=""DJ"" />
      <xs:enumeration value=""DK"" />
      <xs:enumeration value=""DL"" />
      <xs:enumeration value=""DM"" />
      <xs:enumeration value=""DN"" />
      <xs:enumeration value=""DNR"" />
      <xs:enumeration value=""DNS"" />
      <xs:enumeration value=""DO"" />
      <xs:enumeration value=""DOA"" />
      <xs:enumeration value=""DOC"" />
      <xs:enumeration value=""DOE"" />
      <xs:enumeration value=""DOI"" />
      <xs:enumeration value=""DOJ"" />
      <xs:enumeration value=""DOL"" />
      <xs:enumeration value=""DON"" />
      <xs:enumeration value=""DOS"" />
      <xs:enumeration value=""DOT"" />
      <xs:enumeration value=""DP"" />
      <xs:enumeration value=""DQ"" />
      <xs:enumeration value=""DR"" />
      <xs:enumeration value=""DRN"" />
      <xs:enumeration value=""DS"" />
      <xs:enumeration value=""DSC"" />
      <xs:enumeration value=""DSI"" />
      <xs:enumeration value=""DST"" />
      <xs:enumeration value=""DT"" />
      <xs:enumeration value=""DTS"" />
      <xs:enumeration value=""DU"" />
      <xs:enumeration value=""DUN"" />
      <xs:enumeration value=""DV"" />
      <xs:enumeration value=""DW"" />
      <xs:enumeration value=""DX"" />
      <xs:enumeration value=""DY"" />
      <xs:enumeration value=""DZ"" />
      <xs:enumeration value=""E1"" />
      <xs:enumeration value=""E2"" />
      <xs:enumeration value=""E3"" />
      <xs:enumeration value=""E4"" />
      <xs:enumeration value=""E5"" />
      <xs:enumeration value=""E6"" />
      <xs:enumeration value=""E7"" />
      <xs:enumeration value=""E8"" />
      <xs:enumeration value=""E9"" />
      <xs:enumeration value=""EA"" />
      <xs:enumeration value=""EB"" />
      <xs:enumeration value=""EC"" />
      <xs:enumeration value=""ED"" />
      <xs:enumeration value=""EDA"" />
      <xs:enumeration value=""EE"" />
      <xs:enumeration value=""EF"" />
      <xs:enumeration value=""EG"" />
      <xs:enumeration value=""EH"" />
      <xs:enumeration value=""EI"" />
      <xs:enumeration value=""EJ"" />
      <xs:enumeration value=""EK"" />
      <xs:enumeration value=""EL"" />
      <xs:enumeration value=""EM"" />
      <xs:enumeration value=""EMM"" />
      <xs:enumeration value=""EN"" />
      <xs:enumeration value=""END"" />
      <xs:enumeration value=""EO"" />
      <xs:enumeration value=""EP"" />
      <xs:enumeration value=""EPA"" />
      <xs:enumeration value=""EPB"" />
      <xs:enumeration value=""EQ"" />
      <xs:enumeration value=""ER"" />
      <xs:enumeration value=""ES"" />
      <xs:enumeration value=""ESN"" />
      <xs:enumeration value=""ET"" />
      <xs:enumeration value=""EU"" />
      <xs:enumeration value=""EV"" />
      <xs:enumeration value=""EW"" />
      <xs:enumeration value=""EX"" />
      <xs:enumeration value=""EY"" />
      <xs:enumeration value=""EZ"" />
      <xs:enumeration value=""F1"" />
      <xs:enumeration value=""F2"" />
      <xs:enumeration value=""F3"" />
      <xs:enumeration value=""F4"" />
      <xs:enumeration value=""F5"" />
      <xs:enumeration value=""F6"" />
      <xs:enumeration value=""F7"" />
      <xs:enumeration value=""F8"" />
      <xs:enumeration value=""F9"" />
      <xs:enumeration value=""FA"" />
      <xs:enumeration value=""FB"" />
      <xs:enumeration value=""FC"" />
      <xs:enumeration value=""FCN"" />
      <xs:enumeration value=""FD"" />
      <xs:enumeration value=""FE"" />
      <xs:enumeration value=""FF"" />
      <xs:enumeration value=""FG"" />
      <xs:enumeration value=""FH"" />
      <xs:enumeration value=""FI"" />
      <xs:enumeration value=""FJ"" />
      <xs:enumeration value=""FK"" />
      <xs:enumeration value=""FL"" />
      <xs:enumeration value=""FLZ"" />
      <xs:enumeration value=""FM"" />
      <xs:enumeration value=""FMP"" />
      <xs:enumeration value=""FN"" />
      <xs:enumeration value=""FND"" />
      <xs:enumeration value=""FO"" />
      <xs:enumeration value=""FP"" />
      <xs:enumeration value=""FQ"" />
      <xs:enumeration value=""FR"" />
      <xs:enumeration value=""FS"" />
      <xs:enumeration value=""FSN"" />
      <xs:enumeration value=""FT"" />
      <xs:enumeration value=""FTN"" />
      <xs:enumeration value=""FU"" />
      <xs:enumeration value=""FV"" />
      <xs:enumeration value=""FW"" />
      <xs:enumeration value=""FWC"" />
      <xs:enumeration value=""FX"" />
      <xs:enumeration value=""FY"" />
      <xs:enumeration value=""FZ"" />
      <xs:enumeration value=""G1"" />
      <xs:enumeration value=""G2"" />
      <xs:enumeration value=""G3"" />
      <xs:enumeration value=""G4"" />
      <xs:enumeration value=""G5"" />
      <xs:enumeration value=""G6"" />
      <xs:enumeration value=""G7"" />
      <xs:enumeration value=""G8"" />
      <xs:enumeration value=""G9"" />
      <xs:enumeration value=""GA"" />
      <xs:enumeration value=""GB"" />
      <xs:enumeration value=""GC"" />
      <xs:enumeration value=""GD"" />
      <xs:enumeration value=""GE"" />
      <xs:enumeration value=""GF"" />
      <xs:enumeration value=""GG"" />
      <xs:enumeration value=""GH"" />
      <xs:enumeration value=""GI"" />
      <xs:enumeration value=""GJ"" />
      <xs:enumeration value=""GK"" />
      <xs:enumeration value=""GL"" />
      <xs:enumeration value=""GM"" />
      <xs:enumeration value=""GN"" />
      <xs:enumeration value=""GO"" />
      <xs:enumeration value=""GP"" />
      <xs:enumeration value=""GQ"" />
      <xs:enumeration value=""GR"" />
      <xs:enumeration value=""GS"" />
      <xs:enumeration value=""GT"" />
      <xs:enumeration value=""GU"" />
      <xs:enumeration value=""GV"" />
      <xs:enumeration value=""GW"" />
      <xs:enumeration value=""GWS"" />
      <xs:enumeration value=""GX"" />
      <xs:enumeration value=""GY"" />
      <xs:enumeration value=""GZ"" />
      <xs:enumeration value=""H1"" />
      <xs:enumeration value=""H2"" />
      <xs:enumeration value=""H3"" />
      <xs:enumeration value=""H4"" />
      <xs:enumeration value=""H5"" />
      <xs:enumeration value=""H6"" />
      <xs:enumeration value=""H7"" />
      <xs:enumeration value=""H8"" />
      <xs:enumeration value=""H9"" />
      <xs:enumeration value=""HA"" />
      <xs:enumeration value=""HB"" />
      <xs:enumeration value=""HC"" />
      <xs:enumeration value=""HD"" />
      <xs:enumeration value=""HE"" />
      <xs:enumeration value=""HF"" />
      <xs:enumeration value=""HG"" />
      <xs:enumeration value=""HH"" />
      <xs:enumeration value=""HHT"" />
      <xs:enumeration value=""HI"" />
      <xs:enumeration value=""HJ"" />
      <xs:enumeration value=""HK"" />
      <xs:enumeration value=""HL"" />
      <xs:enumeration value=""HM"" />
      <xs:enumeration value=""HMB"" />
      <xs:enumeration value=""HN"" />
      <xs:enumeration value=""HO"" />
      <xs:enumeration value=""HP"" />
      <xs:enumeration value=""HPI"" />
      <xs:enumeration value=""HQ"" />
      <xs:enumeration value=""HR"" />
      <xs:enumeration value=""HS"" />
      <xs:enumeration value=""HT"" />
      <xs:enumeration value=""HU"" />
      <xs:enumeration value=""HUD"" />
      <xs:enumeration value=""HV"" />
      <xs:enumeration value=""HW"" />
      <xs:enumeration value=""HX"" />
      <xs:enumeration value=""HY"" />
      <xs:enumeration value=""HZ"" />
      <xs:enumeration value=""I1"" />
      <xs:enumeration value=""I2"" />
      <xs:enumeration value=""I3"" />
      <xs:enumeration value=""I4"" />
      <xs:enumeration value=""I5"" />
      <xs:enumeration value=""I7"" />
      <xs:enumeration value=""I8"" />
      <xs:enumeration value=""I9"" />
      <xs:enumeration value=""IA"" />
      <xs:enumeration value=""IB"" />
      <xs:enumeration value=""IC"" />
      <xs:enumeration value=""ICD"" />
      <xs:enumeration value=""ID"" />
      <xs:enumeration value=""IE"" />
      <xs:enumeration value=""IF"" />
      <xs:enumeration value=""IFT"" />
      <xs:enumeration value=""IG"" />
      <xs:enumeration value=""IH"" />
      <xs:enumeration value=""II"" />
      <xs:enumeration value=""IID"" />
      <xs:enumeration value=""IJ"" />
      <xs:enumeration value=""IK"" />
      <xs:enumeration value=""IL"" />
      <xs:enumeration value=""IM"" />
      <xs:enumeration value=""IMP"" />
      <xs:enumeration value=""IMS"" />
      <xs:enumeration value=""IN"" />
      <xs:enumeration value=""IND"" />
      <xs:enumeration value=""IO"" />
      <xs:enumeration value=""IP"" />
      <xs:enumeration value=""IQ"" />
      <xs:enumeration value=""IR"" />
      <xs:enumeration value=""IRN"" />
      <xs:enumeration value=""IRP"" />
      <xs:enumeration value=""IS"" />
      <xs:enumeration value=""ISC"" />
      <xs:enumeration value=""ISN"" />
      <xs:enumeration value=""ISS"" />
      <xs:enumeration value=""IT"" />
      <xs:enumeration value=""IU"" />
      <xs:enumeration value=""IV"" />
      <xs:enumeration value=""IW"" />
      <xs:enumeration value=""IX"" />
      <xs:enumeration value=""IZ"" />
      <xs:enumeration value=""J0"" />
      <xs:enumeration value=""J1"" />
      <xs:enumeration value=""J2"" />
      <xs:enumeration value=""J3"" />
      <xs:enumeration value=""J4"" />
      <xs:enumeration value=""J5"" />
      <xs:enumeration value=""J6"" />
      <xs:enumeration value=""J7"" />
      <xs:enumeration value=""J8"" />
      <xs:enumeration value=""J9"" />
      <xs:enumeration value=""JA"" />
      <xs:enumeration value=""JB"" />
      <xs:enumeration value=""JC"" />
      <xs:enumeration value=""JD"" />
      <xs:enumeration value=""JE"" />
      <xs:enumeration value=""JF"" />
      <xs:enumeration value=""JH"" />
      <xs:enumeration value=""JI"" />
      <xs:enumeration value=""JK"" />
      <xs:enumeration value=""JL"" />
      <xs:enumeration value=""JM"" />
      <xs:enumeration value=""JN"" />
      <xs:enumeration value=""JO"" />
      <xs:enumeration value=""JP"" />
      <xs:enumeration value=""JQ"" />
      <xs:enumeration value=""JR"" />
      <xs:enumeration value=""JS"" />
      <xs:enumeration value=""JT"" />
      <xs:enumeration value=""JU"" />
      <xs:enumeration value=""JV"" />
      <xs:enumeration value=""JW"" />
      <xs:enumeration value=""JX"" />
      <xs:enumeration value=""JY"" />
      <xs:enumeration value=""JZ"" />
      <xs:enumeration value=""K0"" />
      <xs:enumeration value=""K1"" />
      <xs:enumeration value=""K2"" />
      <xs:enumeration value=""K3"" />
      <xs:enumeration value=""K4"" />
      <xs:enumeration value=""K5"" />
      <xs:enumeration value=""K6"" />
      <xs:enumeration value=""K7"" />
      <xs:enumeration value=""K8"" />
      <xs:enumeration value=""K9"" />
      <xs:enumeration value=""KA"" />
      <xs:enumeration value=""KB"" />
      <xs:enumeration value=""KC"" />
      <xs:enumeration value=""KD"" />
      <xs:enumeration value=""KE"" />
      <xs:enumeration value=""KG"" />
      <xs:enumeration value=""KH"" />
      <xs:enumeration value=""KI"" />
      <xs:enumeration value=""KJ"" />
      <xs:enumeration value=""KK"" />
      <xs:enumeration value=""KL"" />
      <xs:enumeration value=""KM"" />
      <xs:enumeration value=""KN"" />
      <xs:enumeration value=""KO"" />
      <xs:enumeration value=""KP"" />
      <xs:enumeration value=""KQ"" />
      <xs:enumeration value=""KR"" />
      <xs:enumeration value=""KS"" />
      <xs:enumeration value=""KT"" />
      <xs:enumeration value=""KU"" />
      <xs:enumeration value=""KV"" />
      <xs:enumeration value=""KW"" />
      <xs:enumeration value=""KX"" />
      <xs:enumeration value=""KY"" />
      <xs:enumeration value=""KZ"" />
      <xs:enumeration value=""L1"" />
      <xs:enumeration value=""L2"" />
      <xs:enumeration value=""L3"" />
      <xs:enumeration value=""L4"" />
      <xs:enumeration value=""L5"" />
      <xs:enumeration value=""L6"" />
      <xs:enumeration value=""L7"" />
      <xs:enumeration value=""L8"" />
      <xs:enumeration value=""L9"" />
      <xs:enumeration value=""LA"" />
      <xs:enumeration value=""LB"" />
      <xs:enumeration value=""LC"" />
      <xs:enumeration value=""LD"" />
      <xs:enumeration value=""LE"" />
      <xs:enumeration value=""LEN"" />
      <xs:enumeration value=""LF"" />
      <xs:enumeration value=""LG"" />
      <xs:enumeration value=""LH"" />
      <xs:enumeration value=""LI"" />
      <xs:enumeration value=""LIC"" />
      <xs:enumeration value=""LJ"" />
      <xs:enumeration value=""LK"" />
      <xs:enumeration value=""LL"" />
      <xs:enumeration value=""LM"" />
      <xs:enumeration value=""LN"" />
      <xs:enumeration value=""LO"" />
      <xs:enumeration value=""LOI"" />
      <xs:enumeration value=""LP"" />
      <xs:enumeration value=""LQ"" />
      <xs:enumeration value=""LR"" />
      <xs:enumeration value=""LS"" />
      <xs:enumeration value=""LSD"" />
      <xs:enumeration value=""LT"" />
      <xs:enumeration value=""LU"" />
      <xs:enumeration value=""LV"" />
      <xs:enumeration value=""LVO"" />
      <xs:enumeration value=""LW"" />
      <xs:enumeration value=""LX"" />
      <xs:enumeration value=""LY"" />
      <xs:enumeration value=""LZ"" />
      <xs:enumeration value=""M1"" />
      <xs:enumeration value=""M2"" />
      <xs:enumeration value=""M3"" />
      <xs:enumeration value=""M5"" />
      <xs:enumeration value=""M6"" />
      <xs:enumeration value=""M7"" />
      <xs:enumeration value=""M8"" />
      <xs:enumeration value=""M9"" />
      <xs:enumeration value=""MA"" />
      <xs:enumeration value=""MB"" />
      <xs:enumeration value=""MBX"" />
      <xs:enumeration value=""MC"" />
      <xs:enumeration value=""MCI"" />
      <xs:enumeration value=""MD"" />
      <xs:enumeration value=""MDN"" />
      <xs:enumeration value=""ME"" />
      <xs:enumeration value=""MF"" />
      <xs:enumeration value=""MG"" />
      <xs:enumeration value=""MH"" />
      <xs:enumeration value=""MI"" />
      <xs:enumeration value=""MJ"" />
      <xs:enumeration value=""MK"" />
      <xs:enumeration value=""ML"" />
      <xs:enumeration value=""MM"" />
      <xs:enumeration value=""MN"" />
      <xs:enumeration value=""MO"" />
      <xs:enumeration value=""MP"" />
      <xs:enumeration value=""MQ"" />
      <xs:enumeration value=""MR"" />
      <xs:enumeration value=""MS"" />
      <xs:enumeration value=""MSL"" />
      <xs:enumeration value=""MT"" />
      <xs:enumeration value=""MU"" />
      <xs:enumeration value=""MV"" />
      <xs:enumeration value=""MW"" />
      <xs:enumeration value=""MX"" />
      <xs:enumeration value=""MY"" />
      <xs:enumeration value=""MZ"" />
      <xs:enumeration value=""MZO"" />
      <xs:enumeration value=""N0"" />
      <xs:enumeration value=""N1"" />
      <xs:enumeration value=""N2"" />
      <xs:enumeration value=""N3"" />
      <xs:enumeration value=""N4"" />
      <xs:enumeration value=""N5"" />
      <xs:enumeration value=""N6"" />
      <xs:enumeration value=""N7"" />
      <xs:enumeration value=""N8"" />
      <xs:enumeration value=""N9"" />
      <xs:enumeration value=""NA"" />
      <xs:enumeration value=""NAS"" />
      <xs:enumeration value=""NB"" />
      <xs:enumeration value=""NC"" />
      <xs:enumeration value=""ND"" />
      <xs:enumeration value=""NDA"" />
      <xs:enumeration value=""NDB"" />
      <xs:enumeration value=""NE"" />
      <xs:enumeration value=""NF"" />
      <xs:enumeration value=""NFC"" />
      <xs:enumeration value=""NFD"" />
      <xs:enumeration value=""NFM"" />
      <xs:enumeration value=""NFN"" />
      <xs:enumeration value=""NFS"" />
      <xs:enumeration value=""NG"" />
      <xs:enumeration value=""NH"" />
      <xs:enumeration value=""NI"" />
      <xs:enumeration value=""NJ"" />
      <xs:enumeration value=""NK"" />
      <xs:enumeration value=""NL"" />
      <xs:enumeration value=""NM"" />
      <xs:enumeration value=""NN"" />
      <xs:enumeration value=""NO"" />
      <xs:enumeration value=""NP"" />
      <xs:enumeration value=""NQ"" />
      <xs:enumeration value=""NR"" />
      <xs:enumeration value=""NS"" />
      <xs:enumeration value=""NT"" />
      <xs:enumeration value=""NU"" />
      <xs:enumeration value=""NW"" />
      <xs:enumeration value=""NX"" />
      <xs:enumeration value=""NY"" />
      <xs:enumeration value=""NZ"" />
      <xs:enumeration value=""O1"" />
      <xs:enumeration value=""O2"" />
      <xs:enumeration value=""O5"" />
      <xs:enumeration value=""O7"" />
      <xs:enumeration value=""O8"" />
      <xs:enumeration value=""O9"" />
      <xs:enumeration value=""OA"" />
      <xs:enumeration value=""OB"" />
      <xs:enumeration value=""OC"" />
      <xs:enumeration value=""OD"" />
      <xs:enumeration value=""OE"" />
      <xs:enumeration value=""OF"" />
      <xs:enumeration value=""OG"" />
      <xs:enumeration value=""OH"" />
      <xs:enumeration value=""OI"" />
      <xs:enumeration value=""OJ"" />
      <xs:enumeration value=""OK"" />
      <xs:enumeration value=""OL"" />
      <xs:enumeration value=""OM"" />
      <xs:enumeration value=""ON"" />
      <xs:enumeration value=""OP"" />
      <xs:enumeration value=""OQ"" />
      <xs:enumeration value=""OR"" />
      <xs:enumeration value=""OS"" />
      <xs:enumeration value=""OT"" />
      <xs:enumeration value=""OU"" />
      <xs:enumeration value=""OV"" />
      <xs:enumeration value=""OW"" />
      <xs:enumeration value=""OX"" />
      <xs:enumeration value=""OZ"" />
      <xs:enumeration value=""P1"" />
      <xs:enumeration value=""P2"" />
      <xs:enumeration value=""P3"" />
      <xs:enumeration value=""P4"" />
      <xs:enumeration value=""P5"" />
      <xs:enumeration value=""P6"" />
      <xs:enumeration value=""P7"" />
      <xs:enumeration value=""P8"" />
      <xs:enumeration value=""P9"" />
      <xs:enumeration value=""PA"" />
      <xs:enumeration value=""PAC"" />
      <xs:enumeration value=""PAN"" />
      <xs:enumeration value=""PAP"" />
      <xs:enumeration value=""PB"" />
      <xs:enumeration value=""PC"" />
      <xs:enumeration value=""PCC"" />
      <xs:enumeration value=""PCN"" />
      <xs:enumeration value=""PD"" />
      <xs:enumeration value=""PDL"" />
      <xs:enumeration value=""PE"" />
      <xs:enumeration value=""PF"" />
      <xs:enumeration value=""PG"" />
      <xs:enumeration value=""PGC"" />
      <xs:enumeration value=""PGN"" />
      <xs:enumeration value=""PGS"" />
      <xs:enumeration value=""PH"" />
      <xs:enumeration value=""PHC"" />
      <xs:enumeration value=""PI"" />
      <xs:enumeration value=""PID"" />
      <xs:enumeration value=""PIN"" />
      <xs:enumeration value=""PJ"" />
      <xs:enumeration value=""PK"" />
      <xs:enumeration value=""PL"" />
      <xs:enumeration value=""PLA"" />
      <xs:enumeration value=""PLN"" />
      <xs:enumeration value=""PM"" />
      <xs:enumeration value=""PMN"" />
      <xs:enumeration value=""PN"" />
      <xs:enumeration value=""PNN"" />
      <xs:enumeration value=""PO"" />
      <xs:enumeration value=""POL"" />
      <xs:enumeration value=""PP"" />
      <xs:enumeration value=""PQ"" />
      <xs:enumeration value=""PR"" />
      <xs:enumeration value=""PRS"" />
      <xs:enumeration value=""PRT"" />
      <xs:enumeration value=""PS"" />
      <xs:enumeration value=""PSI"" />
      <xs:enumeration value=""PSL"" />
      <xs:enumeration value=""PSM"" />
      <xs:enumeration value=""PSN"" />
      <xs:enumeration value=""PT"" />
      <xs:enumeration value=""PTC"" />
      <xs:enumeration value=""PU"" />
      <xs:enumeration value=""PV"" />
      <xs:enumeration value=""PW"" />
      <xs:enumeration value=""PWC"" />
      <xs:enumeration value=""PWS"" />
      <xs:enumeration value=""PX"" />
      <xs:enumeration value=""PY"" />
      <xs:enumeration value=""PZ"" />
      <xs:enumeration value=""Q1"" />
      <xs:enumeration value=""Q2"" />
      <xs:enumeration value=""Q3"" />
      <xs:enumeration value=""Q4"" />
      <xs:enumeration value=""Q5"" />
      <xs:enumeration value=""Q6"" />
      <xs:enumeration value=""Q7"" />
      <xs:enumeration value=""Q8"" />
      <xs:enumeration value=""Q9"" />
      <xs:enumeration value=""QA"" />
      <xs:enumeration value=""QB"" />
      <xs:enumeration value=""QC"" />
      <xs:enumeration value=""QD"" />
      <xs:enumeration value=""QE"" />
      <xs:enumeration value=""QF"" />
      <xs:enumeration value=""QG"" />
      <xs:enumeration value=""QH"" />
      <xs:enumeration value=""QI"" />
      <xs:enumeration value=""QJ"" />
      <xs:enumeration value=""QK"" />
      <xs:enumeration value=""QL"" />
      <xs:enumeration value=""QM"" />
      <xs:enumeration value=""QN"" />
      <xs:enumeration value=""QO"" />
      <xs:enumeration value=""QP"" />
      <xs:enumeration value=""QQ"" />
      <xs:enumeration value=""QR"" />
      <xs:enumeration value=""QS"" />
      <xs:enumeration value=""QT"" />
      <xs:enumeration value=""QU"" />
      <xs:enumeration value=""QV"" />
      <xs:enumeration value=""QW"" />
      <xs:enumeration value=""QX"" />
      <xs:enumeration value=""QY"" />
      <xs:enumeration value=""QZ"" />
      <xs:enumeration value=""R0"" />
      <xs:enumeration value=""R1"" />
      <xs:enumeration value=""R2"" />
      <xs:enumeration value=""R3"" />
      <xs:enumeration value=""R4"" />
      <xs:enumeration value=""R5"" />
      <xs:enumeration value=""R6"" />
      <xs:enumeration value=""R7"" />
      <xs:enumeration value=""R8"" />
      <xs:enumeration value=""R9"" />
      <xs:enumeration value=""RA"" />
      <xs:enumeration value=""RAA"" />
      <xs:enumeration value=""RAN"" />
      <xs:enumeration value=""RB"" />
      <xs:enumeration value=""RC"" />
      <xs:enumeration value=""RD"" />
      <xs:enumeration value=""RE"" />
      <xs:enumeration value=""REC"" />
      <xs:enumeration value=""RF"" />
      <xs:enumeration value=""RG"" />
      <xs:enumeration value=""RGI"" />
      <xs:enumeration value=""RH"" />
      <xs:enumeration value=""RI"" />
      <xs:enumeration value=""RIG"" />
      <xs:enumeration value=""RJ"" />
      <xs:enumeration value=""RK"" />
      <xs:enumeration value=""RL"" />
      <xs:enumeration value=""RM"" />
      <xs:enumeration value=""RN"" />
      <xs:enumeration value=""RO"" />
      <xs:enumeration value=""RP"" />
      <xs:enumeration value=""RPP"" />
      <xs:enumeration value=""RPT"" />
      <xs:enumeration value=""RQ"" />
      <xs:enumeration value=""RR"" />
      <xs:enumeration value=""RRS"" />
      <xs:enumeration value=""RS"" />
      <xs:enumeration value=""RSN"" />
      <xs:enumeration value=""RT"" />
      <xs:enumeration value=""RU"" />
      <xs:enumeration value=""RV"" />
      <xs:enumeration value=""RW"" />
      <xs:enumeration value=""RX"" />
      <xs:enumeration value=""RY"" />
      <xs:enumeration value=""RZ"" />
      <xs:enumeration value=""S0"" />
      <xs:enumeration value=""S1"" />
      <xs:enumeration value=""S2"" />
      <xs:enumeration value=""S3"" />
      <xs:enumeration value=""S4"" />
      <xs:enumeration value=""S5"" />
      <xs:enumeration value=""S6"" />
      <xs:enumeration value=""S7"" />
      <xs:enumeration value=""S8"" />
      <xs:enumeration value=""S9"" />
      <xs:enumeration value=""SA"" />
      <xs:enumeration value=""SB"" />
      <xs:enumeration value=""SBN"" />
      <xs:enumeration value=""SC"" />
      <xs:enumeration value=""SCA"" />
      <xs:enumeration value=""SD"" />
      <xs:enumeration value=""SE"" />
      <xs:enumeration value=""SEK"" />
      <xs:enumeration value=""SES"" />
      <xs:enumeration value=""SF"" />
      <xs:enumeration value=""SG"" />
      <xs:enumeration value=""SH"" />
      <xs:enumeration value=""SHL"" />
      <xs:enumeration value=""SI"" />
      <xs:enumeration value=""SJ"" />
      <xs:enumeration value=""SK"" />
      <xs:enumeration value=""SL"" />
      <xs:enumeration value=""SM"" />
      <xs:enumeration value=""SN"" />
      <xs:enumeration value=""SNH"" />
      <xs:enumeration value=""SNV"" />
      <xs:enumeration value=""SO"" />
      <xs:enumeration value=""SP"" />
      <xs:enumeration value=""SPL"" />
      <xs:enumeration value=""SPN"" />
      <xs:enumeration value=""SQ"" />
      <xs:enumeration value=""SR"" />
      <xs:enumeration value=""SS"" />
      <xs:enumeration value=""ST"" />
      <xs:enumeration value=""STB"" />
      <xs:enumeration value=""STR"" />
      <xs:enumeration value=""SU"" />
      <xs:enumeration value=""SUB"" />
      <xs:enumeration value=""SUO"" />
      <xs:enumeration value=""SV"" />
      <xs:enumeration value=""SW"" />
      <xs:enumeration value=""SX"" />
      <xs:enumeration value=""SY"" />
      <xs:enumeration value=""SZ"" />
      <xs:enumeration value=""T0"" />
      <xs:enumeration value=""T1"" />
      <xs:enumeration value=""T2"" />
      <xs:enumeration value=""T3"" />
      <xs:enumeration value=""T4"" />
      <xs:enumeration value=""T5"" />
      <xs:enumeration value=""T6"" />
      <xs:enumeration value=""T7"" />
      <xs:enumeration value=""T8"" />
      <xs:enumeration value=""T9"" />
      <xs:enumeration value=""TA"" />
      <xs:enumeration value=""TB"" />
      <xs:enumeration value=""TC"" />
      <xs:enumeration value=""TD"" />
      <xs:enumeration value=""TDT"" />
      <xs:enumeration value=""TE"" />
      <xs:enumeration value=""TF"" />
      <xs:enumeration value=""TG"" />
      <xs:enumeration value=""TH"" />
      <xs:enumeration value=""TI"" />
      <xs:enumeration value=""TIP"" />
      <xs:enumeration value=""TJ"" />
      <xs:enumeration value=""TK"" />
      <xs:enumeration value=""TL"" />
      <xs:enumeration value=""TM"" />
      <xs:enumeration value=""TN"" />
      <xs:enumeration value=""TO"" />
      <xs:enumeration value=""TOC"" />
      <xs:enumeration value=""TP"" />
      <xs:enumeration value=""TPN"" />
      <xs:enumeration value=""TQ"" />
      <xs:enumeration value=""TR"" />
      <xs:enumeration value=""TS"" />
      <xs:enumeration value=""TSN"" />
      <xs:enumeration value=""TT"" />
      <xs:enumeration value=""TU"" />
      <xs:enumeration value=""TV"" />
      <xs:enumeration value=""TW"" />
      <xs:enumeration value=""TX"" />
      <xs:enumeration value=""TY"" />
      <xs:enumeration value=""TZ"" />
      <xs:enumeration value=""U0"" />
      <xs:enumeration value=""U1"" />
      <xs:enumeration value=""U2"" />
      <xs:enumeration value=""U3"" />
      <xs:enumeration value=""U4"" />
      <xs:enumeration value=""U5"" />
      <xs:enumeration value=""U6"" />
      <xs:enumeration value=""U8"" />
      <xs:enumeration value=""U9"" />
      <xs:enumeration value=""UA"" />
      <xs:enumeration value=""UB"" />
      <xs:enumeration value=""UC"" />
      <xs:enumeration value=""UD"" />
      <xs:enumeration value=""UE"" />
      <xs:enumeration value=""UF"" />
      <xs:enumeration value=""UG"" />
      <xs:enumeration value=""UH"" />
      <xs:enumeration value=""UI"" />
      <xs:enumeration value=""UJ"" />
      <xs:enumeration value=""UK"" />
      <xs:enumeration value=""UL"" />
      <xs:enumeration value=""UM"" />
      <xs:enumeration value=""UN"" />
      <xs:enumeration value=""UO"" />
      <xs:enumeration value=""UP"" />
      <xs:enumeration value=""UQ"" />
      <xs:enumeration value=""UR"" />
      <xs:enumeration value=""URL"" />
      <xs:enumeration value=""US"" />
      <xs:enumeration value=""UT"" />
      <xs:enumeration value=""UU"" />
      <xs:enumeration value=""UV"" />
      <xs:enumeration value=""UW"" />
      <xs:enumeration value=""UX"" />
      <xs:enumeration value=""UY"" />
      <xs:enumeration value=""UZ"" />
      <xs:enumeration value=""V0"" />
      <xs:enumeration value=""V1"" />
      <xs:enumeration value=""V2"" />
      <xs:enumeration value=""V3"" />
      <xs:enumeration value=""V4"" />
      <xs:enumeration value=""V5"" />
      <xs:enumeration value=""V6"" />
      <xs:enumeration value=""V7"" />
      <xs:enumeration value=""V8"" />
      <xs:enumeration value=""V9"" />
      <xs:enumeration value=""VA"" />
      <xs:enumeration value=""VB"" />
      <xs:enumeration value=""VC"" />
      <xs:enumeration value=""VD"" />
      <xs:enumeration value=""VE"" />
      <xs:enumeration value=""VF"" />
      <xs:enumeration value=""VG"" />
      <xs:enumeration value=""VH"" />
      <xs:enumeration value=""VI"" />
      <xs:enumeration value=""VJ"" />
      <xs:enumeration value=""VK"" />
      <xs:enumeration value=""VL"" />
      <xs:enumeration value=""VM"" />
      <xs:enumeration value=""VN"" />
      <xs:enumeration value=""VO"" />
      <xs:enumeration value=""VP"" />
      <xs:enumeration value=""VQ"" />
      <xs:enumeration value=""VR"" />
      <xs:enumeration value=""VS"" />
      <xs:enumeration value=""VT"" />
      <xs:enumeration value=""VU"" />
      <xs:enumeration value=""VV"" />
      <xs:enumeration value=""VW"" />
      <xs:enumeration value=""VX"" />
      <xs:enumeration value=""VY"" />
      <xs:enumeration value=""VZ"" />
      <xs:enumeration value=""W1"" />
      <xs:enumeration value=""W2"" />
      <xs:enumeration value=""W3"" />
      <xs:enumeration value=""W4"" />
      <xs:enumeration value=""W5"" />
      <xs:enumeration value=""W6"" />
      <xs:enumeration value=""W7"" />
      <xs:enumeration value=""W8"" />
      <xs:enumeration value=""W9"" />
      <xs:enumeration value=""WA"" />
      <xs:enumeration value=""WB"" />
      <xs:enumeration value=""WC"" />
      <xs:enumeration value=""WCS"" />
      <xs:enumeration value=""WD"" />
      <xs:enumeration value=""WDR"" />
      <xs:enumeration value=""WE"" />
      <xs:enumeration value=""WF"" />
      <xs:enumeration value=""WG"" />
      <xs:enumeration value=""WH"" />
      <xs:enumeration value=""WI"" />
      <xs:enumeration value=""WJ"" />
      <xs:enumeration value=""WK"" />
      <xs:enumeration value=""WL"" />
      <xs:enumeration value=""WM"" />
      <xs:enumeration value=""WN"" />
      <xs:enumeration value=""WO"" />
      <xs:enumeration value=""WP"" />
      <xs:enumeration value=""WQ"" />
      <xs:enumeration value=""WR"" />
      <xs:enumeration value=""WS"" />
      <xs:enumeration value=""WT"" />
      <xs:enumeration value=""WU"" />
      <xs:enumeration value=""WV"" />
      <xs:enumeration value=""WW"" />
      <xs:enumeration value=""WX"" />
      <xs:enumeration value=""WY"" />
      <xs:enumeration value=""WZ"" />
      <xs:enumeration value=""X0"" />
      <xs:enumeration value=""X1"" />
      <xs:enumeration value=""X2"" />
      <xs:enumeration value=""X3"" />
      <xs:enumeration value=""X4"" />
      <xs:enumeration value=""X5"" />
      <xs:enumeration value=""X6"" />
      <xs:enumeration value=""X7"" />
      <xs:enumeration value=""X8"" />
      <xs:enumeration value=""X9"" />
      <xs:enumeration value=""XA"" />
      <xs:enumeration value=""XB"" />
      <xs:enumeration value=""XC"" />
      <xs:enumeration value=""XD"" />
      <xs:enumeration value=""XE"" />
      <xs:enumeration value=""XF"" />
      <xs:enumeration value=""XG"" />
      <xs:enumeration value=""XH"" />
      <xs:enumeration value=""XI"" />
      <xs:enumeration value=""XJ"" />
      <xs:enumeration value=""XK"" />
      <xs:enumeration value=""XL"" />
      <xs:enumeration value=""XM"" />
      <xs:enumeration value=""XN"" />
      <xs:enumeration value=""XO"" />
      <xs:enumeration value=""XP"" />
      <xs:enumeration value=""XQ"" />
      <xs:enumeration value=""XR"" />
      <xs:enumeration value=""XS"" />
      <xs:enumeration value=""XT"" />
      <xs:enumeration value=""XU"" />
      <xs:enumeration value=""XV"" />
      <xs:enumeration value=""XW"" />
      <xs:enumeration value=""XX"" />
      <xs:enumeration value=""XY"" />
      <xs:enumeration value=""XZ"" />
      <xs:enumeration value=""Y0"" />
      <xs:enumeration value=""Y1"" />
      <xs:enumeration value=""Y2"" />
      <xs:enumeration value=""Y3"" />
      <xs:enumeration value=""Y4"" />
      <xs:enumeration value=""Y5"" />
      <xs:enumeration value=""Y6"" />
      <xs:enumeration value=""Y7"" />
      <xs:enumeration value=""Y8"" />
      <xs:enumeration value=""Y9"" />
      <xs:enumeration value=""YA"" />
      <xs:enumeration value=""YB"" />
      <xs:enumeration value=""YC"" />
      <xs:enumeration value=""YD"" />
      <xs:enumeration value=""YE"" />
      <xs:enumeration value=""YF"" />
      <xs:enumeration value=""YH"" />
      <xs:enumeration value=""YI"" />
      <xs:enumeration value=""YJ"" />
      <xs:enumeration value=""YK"" />
      <xs:enumeration value=""YL"" />
      <xs:enumeration value=""YM"" />
      <xs:enumeration value=""YN"" />
      <xs:enumeration value=""YO"" />
      <xs:enumeration value=""YP"" />
      <xs:enumeration value=""YQ"" />
      <xs:enumeration value=""YR"" />
      <xs:enumeration value=""YS"" />
      <xs:enumeration value=""YT"" />
      <xs:enumeration value=""YV"" />
      <xs:enumeration value=""YW"" />
      <xs:enumeration value=""YX"" />
      <xs:enumeration value=""YY"" />
      <xs:enumeration value=""YZ"" />
      <xs:enumeration value=""Z1"" />
      <xs:enumeration value=""Z2"" />
      <xs:enumeration value=""Z3"" />
      <xs:enumeration value=""Z4"" />
      <xs:enumeration value=""Z5"" />
      <xs:enumeration value=""Z6"" />
      <xs:enumeration value=""Z7"" />
      <xs:enumeration value=""Z8"" />
      <xs:enumeration value=""Z9"" />
      <xs:enumeration value=""ZA"" />
      <xs:enumeration value=""ZB"" />
      <xs:enumeration value=""ZC"" />
      <xs:enumeration value=""ZD"" />
      <xs:enumeration value=""ZE"" />
      <xs:enumeration value=""ZF"" />
      <xs:enumeration value=""ZG"" />
      <xs:enumeration value=""ZH"" />
      <xs:enumeration value=""ZI"" />
      <xs:enumeration value=""ZJ"" />
      <xs:enumeration value=""ZK"" />
      <xs:enumeration value=""ZL"" />
      <xs:enumeration value=""ZM"" />
      <xs:enumeration value=""ZN"" />
      <xs:enumeration value=""ZO"" />
      <xs:enumeration value=""ZP"" />
      <xs:enumeration value=""ZQ"" />
      <xs:enumeration value=""ZR"" />
      <xs:enumeration value=""ZS"" />
      <xs:enumeration value=""ZT"" />
      <xs:enumeration value=""ZU"" />
      <xs:enumeration value=""ZV"" />
      <xs:enumeration value=""ZW"" />
      <xs:enumeration value=""ZX"" />
      <xs:enumeration value=""ZY"" />
      <xs:enumeration value=""ZZ"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""X12_ID_623"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""01"" />
      <xs:enumeration value=""02"" />
      <xs:enumeration value=""03"" />
      <xs:enumeration value=""04"" />
      <xs:enumeration value=""05"" />
      <xs:enumeration value=""06"" />
      <xs:enumeration value=""07"" />
      <xs:enumeration value=""08"" />
      <xs:enumeration value=""09"" />
      <xs:enumeration value=""10"" />
      <xs:enumeration value=""11"" />
      <xs:enumeration value=""12"" />
      <xs:enumeration value=""13"" />
      <xs:enumeration value=""14"" />
      <xs:enumeration value=""15"" />
      <xs:enumeration value=""16"" />
      <xs:enumeration value=""17"" />
      <xs:enumeration value=""18"" />
      <xs:enumeration value=""19"" />
      <xs:enumeration value=""20"" />
      <xs:enumeration value=""21"" />
      <xs:enumeration value=""22"" />
      <xs:enumeration value=""23"" />
      <xs:enumeration value=""24"" />
      <xs:enumeration value=""AD"" />
      <xs:enumeration value=""AS"" />
      <xs:enumeration value=""AT"" />
      <xs:enumeration value=""CD"" />
      <xs:enumeration value=""CS"" />
      <xs:enumeration value=""CT"" />
      <xs:enumeration value=""ED"" />
      <xs:enumeration value=""ES"" />
      <xs:enumeration value=""ET"" />
      <xs:enumeration value=""GM"" />
      <xs:enumeration value=""HD"" />
      <xs:enumeration value=""HS"" />
      <xs:enumeration value=""HT"" />
      <xs:enumeration value=""LT"" />
      <xs:enumeration value=""MD"" />
      <xs:enumeration value=""MS"" />
      <xs:enumeration value=""MT"" />
      <xs:enumeration value=""ND"" />
      <xs:enumeration value=""NS"" />
      <xs:enumeration value=""NT"" />
      <xs:enumeration value=""PD"" />
      <xs:enumeration value=""PS"" />
      <xs:enumeration value=""PT"" />
      <xs:enumeration value=""TD"" />
      <xs:enumeration value=""TS"" />
      <xs:enumeration value=""TT"" />
      <xs:enumeration value=""UT"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""X12_ID_432"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""01"" />
      <xs:enumeration value=""02"" />
      <xs:enumeration value=""03"" />
      <xs:enumeration value=""04"" />
      <xs:enumeration value=""05"" />
      <xs:enumeration value=""06"" />
      <xs:enumeration value=""07"" />
      <xs:enumeration value=""08"" />
      <xs:enumeration value=""09"" />
      <xs:enumeration value=""10"" />
      <xs:enumeration value=""11"" />
      <xs:enumeration value=""12"" />
      <xs:enumeration value=""13"" />
      <xs:enumeration value=""14"" />
      <xs:enumeration value=""15"" />
      <xs:enumeration value=""16"" />
      <xs:enumeration value=""17"" />
      <xs:enumeration value=""18"" />
      <xs:enumeration value=""19"" />
      <xs:enumeration value=""20"" />
      <xs:enumeration value=""21"" />
      <xs:enumeration value=""22"" />
      <xs:enumeration value=""23"" />
      <xs:enumeration value=""24"" />
      <xs:enumeration value=""25"" />
      <xs:enumeration value=""26"" />
      <xs:enumeration value=""27"" />
      <xs:enumeration value=""28"" />
      <xs:enumeration value=""29"" />
      <xs:enumeration value=""30"" />
      <xs:enumeration value=""31"" />
      <xs:enumeration value=""32"" />
      <xs:enumeration value=""33"" />
      <xs:enumeration value=""34"" />
      <xs:enumeration value=""35"" />
      <xs:enumeration value=""36"" />
      <xs:enumeration value=""37"" />
      <xs:enumeration value=""38"" />
      <xs:enumeration value=""39"" />
      <xs:enumeration value=""40"" />
      <xs:enumeration value=""41"" />
      <xs:enumeration value=""42"" />
      <xs:enumeration value=""43"" />
      <xs:enumeration value=""44"" />
      <xs:enumeration value=""45"" />
      <xs:enumeration value=""46"" />
      <xs:enumeration value=""47"" />
      <xs:enumeration value=""48"" />
      <xs:enumeration value=""49"" />
      <xs:enumeration value=""50"" />
      <xs:enumeration value=""51"" />
      <xs:enumeration value=""52"" />
      <xs:enumeration value=""53"" />
      <xs:enumeration value=""54"" />
      <xs:enumeration value=""55"" />
      <xs:enumeration value=""56"" />
      <xs:enumeration value=""57"" />
      <xs:enumeration value=""58"" />
      <xs:enumeration value=""59"" />
      <xs:enumeration value=""60"" />
      <xs:enumeration value=""61"" />
      <xs:enumeration value=""62"" />
      <xs:enumeration value=""63"" />
      <xs:enumeration value=""64"" />
      <xs:enumeration value=""67"" />
      <xs:enumeration value=""68"" />
      <xs:enumeration value=""69"" />
      <xs:enumeration value=""70"" />
      <xs:enumeration value=""71"" />
      <xs:enumeration value=""72"" />
      <xs:enumeration value=""73"" />
      <xs:enumeration value=""74"" />
      <xs:enumeration value=""76"" />
      <xs:enumeration value=""77"" />
      <xs:enumeration value=""78"" />
      <xs:enumeration value=""79"" />
      <xs:enumeration value=""80"" />
      <xs:enumeration value=""81"" />
      <xs:enumeration value=""82"" />
      <xs:enumeration value=""83"" />
      <xs:enumeration value=""84"" />
      <xs:enumeration value=""85"" />
      <xs:enumeration value=""86"" />
      <xs:enumeration value=""87"" />
      <xs:enumeration value=""88"" />
      <xs:enumeration value=""89"" />
      <xs:enumeration value=""90"" />
      <xs:enumeration value=""91"" />
      <xs:enumeration value=""92"" />
      <xs:enumeration value=""93"" />
      <xs:enumeration value=""94"" />
      <xs:enumeration value=""95"" />
      <xs:enumeration value=""96"" />
      <xs:enumeration value=""97"" />
      <xs:enumeration value=""98"" />
      <xs:enumeration value=""99"" />
      <xs:enumeration value=""AA"" />
      <xs:enumeration value=""AB"" />
      <xs:enumeration value=""BB"" />
      <xs:enumeration value=""BC"" />
      <xs:enumeration value=""BD"" />
      <xs:enumeration value=""BE"" />
      <xs:enumeration value=""BF"" />
      <xs:enumeration value=""BG"" />
      <xs:enumeration value=""BH"" />
      <xs:enumeration value=""BI"" />
      <xs:enumeration value=""BJ"" />
      <xs:enumeration value=""BK"" />
      <xs:enumeration value=""BL"" />
      <xs:enumeration value=""BM"" />
      <xs:enumeration value=""BN"" />
      <xs:enumeration value=""BO"" />
      <xs:enumeration value=""BP"" />
      <xs:enumeration value=""BQ"" />
      <xs:enumeration value=""BR"" />
      <xs:enumeration value=""BS"" />
      <xs:enumeration value=""BT"" />
      <xs:enumeration value=""BU"" />
      <xs:enumeration value=""BV"" />
      <xs:enumeration value=""BW"" />
      <xs:enumeration value=""BX"" />
      <xs:enumeration value=""BY"" />
      <xs:enumeration value=""BZ"" />
      <xs:enumeration value=""CA"" />
      <xs:enumeration value=""CB"" />
      <xs:enumeration value=""CE"" />
      <xs:enumeration value=""CL"" />
      <xs:enumeration value=""EP"" />
      <xs:enumeration value=""KA"" />
      <xs:enumeration value=""LA"" />
      <xs:enumeration value=""LC"" />
      <xs:enumeration value=""LD"" />
      <xs:enumeration value=""LP"" />
      <xs:enumeration value=""PE"" />
      <xs:enumeration value=""SE"" />
      <xs:enumeration value=""TA"" />
      <xs:enumeration value=""TR"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""X12_ID_176"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""0"" />
      <xs:enumeration value=""1"" />
      <xs:enumeration value=""2"" />
      <xs:enumeration value=""3"" />
      <xs:enumeration value=""4"" />
      <xs:enumeration value=""5"" />
      <xs:enumeration value=""6"" />
      <xs:enumeration value=""7"" />
      <xs:enumeration value=""8"" />
      <xs:enumeration value=""9"" />
      <xs:enumeration value=""A"" />
      <xs:enumeration value=""B"" />
      <xs:enumeration value=""C"" />
      <xs:enumeration value=""CB"" />
      <xs:enumeration value=""CE"" />
      <xs:enumeration value=""D"" />
      <xs:enumeration value=""E"" />
      <xs:enumeration value=""ED"" />
      <xs:enumeration value=""EP"" />
      <xs:enumeration value=""F"" />
      <xs:enumeration value=""G"" />
      <xs:enumeration value=""H"" />
      <xs:enumeration value=""I"" />
      <xs:enumeration value=""J"" />
      <xs:enumeration value=""K"" />
      <xs:enumeration value=""L"" />
      <xs:enumeration value=""LD"" />
      <xs:enumeration value=""LP"" />
      <xs:enumeration value=""M"" />
      <xs:enumeration value=""N"" />
      <xs:enumeration value=""O"" />
      <xs:enumeration value=""P"" />
      <xs:enumeration value=""Q"" />
      <xs:enumeration value=""R"" />
      <xs:enumeration value=""S"" />
      <xs:enumeration value=""T"" />
      <xs:enumeration value=""U"" />
      <xs:enumeration value=""V"" />
      <xs:enumeration value=""W"" />
      <xs:enumeration value=""X"" />
      <xs:enumeration value=""Y"" />
      <xs:enumeration value=""Z"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""X12_ID_363"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""AAA"" />
      <xs:enumeration value=""AAB"" />
      <xs:enumeration value=""AAC"" />
      <xs:enumeration value=""AAD"" />
      <xs:enumeration value=""AAE"" />
      <xs:enumeration value=""AAF"" />
      <xs:enumeration value=""ABN"" />
      <xs:enumeration value=""ACC"" />
      <xs:enumeration value=""ACI"" />
      <xs:enumeration value=""ACN"" />
      <xs:enumeration value=""ACS"" />
      <xs:enumeration value=""ACT"" />
      <xs:enumeration value=""ADD"" />
      <xs:enumeration value=""AES"" />
      <xs:enumeration value=""AET"" />
      <xs:enumeration value=""ALG"" />
      <xs:enumeration value=""ALL"" />
      <xs:enumeration value=""ALT"" />
      <xs:enumeration value=""AMN"" />
      <xs:enumeration value=""AOO"" />
      <xs:enumeration value=""APN"" />
      <xs:enumeration value=""APS"" />
      <xs:enumeration value=""BBD"" />
      <xs:enumeration value=""BBF"" />
      <xs:enumeration value=""BBH"" />
      <xs:enumeration value=""BBN"" />
      <xs:enumeration value=""BBO"" />
      <xs:enumeration value=""BBT"" />
      <xs:enumeration value=""BFD"" />
      <xs:enumeration value=""BOL"" />
      <xs:enumeration value=""BUR"" />
      <xs:enumeration value=""CAA"" />
      <xs:enumeration value=""CAB"" />
      <xs:enumeration value=""CAC"" />
      <xs:enumeration value=""CAD"" />
      <xs:enumeration value=""CAE"" />
      <xs:enumeration value=""CAF"" />
      <xs:enumeration value=""CAG"" />
      <xs:enumeration value=""CAH"" />
      <xs:enumeration value=""CAI"" />
      <xs:enumeration value=""CAJ"" />
      <xs:enumeration value=""CAK"" />
      <xs:enumeration value=""CAL"" />
      <xs:enumeration value=""CAM"" />
      <xs:enumeration value=""CAN"" />
      <xs:enumeration value=""CAO"" />
      <xs:enumeration value=""CAP"" />
      <xs:enumeration value=""CAQ"" />
      <xs:enumeration value=""CAR"" />
      <xs:enumeration value=""CAS"" />
      <xs:enumeration value=""CAT"" />
      <xs:enumeration value=""CAU"" />
      <xs:enumeration value=""CAV"" />
      <xs:enumeration value=""CAW"" />
      <xs:enumeration value=""CAX"" />
      <xs:enumeration value=""CAZ"" />
      <xs:enumeration value=""CBA"" />
      <xs:enumeration value=""CBB"" />
      <xs:enumeration value=""CBC"" />
      <xs:enumeration value=""CBH"" />
      <xs:enumeration value=""CBI"" />
      <xs:enumeration value=""CCA"" />
      <xs:enumeration value=""CCB"" />
      <xs:enumeration value=""CCC"" />
      <xs:enumeration value=""CCD"" />
      <xs:enumeration value=""CCE"" />
      <xs:enumeration value=""CCF"" />
      <xs:enumeration value=""CCG"" />
      <xs:enumeration value=""CCN"" />
      <xs:enumeration value=""CDD"" />
      <xs:enumeration value=""CER"" />
      <xs:enumeration value=""CHG"" />
      <xs:enumeration value=""CIG"" />
      <xs:enumeration value=""CLN"" />
      <xs:enumeration value=""CLR"" />
      <xs:enumeration value=""CMP"" />
      <xs:enumeration value=""CMT"" />
      <xs:enumeration value=""COD"" />
      <xs:enumeration value=""COM"" />
      <xs:enumeration value=""CON"" />
      <xs:enumeration value=""CRA"" />
      <xs:enumeration value=""CRK"" />
      <xs:enumeration value=""CRN"" />
      <xs:enumeration value=""CUS"" />
      <xs:enumeration value=""DCP"" />
      <xs:enumeration value=""DEE"" />
      <xs:enumeration value=""DEL"" />
      <xs:enumeration value=""DEP"" />
      <xs:enumeration value=""DFR"" />
      <xs:enumeration value=""DFS"" />
      <xs:enumeration value=""DGN"" />
      <xs:enumeration value=""DME"" />
      <xs:enumeration value=""DOD"" />
      <xs:enumeration value=""DOI"" />
      <xs:enumeration value=""ECD"" />
      <xs:enumeration value=""ECM"" />
      <xs:enumeration value=""ECN"" />
      <xs:enumeration value=""ECT"" />
      <xs:enumeration value=""EED"" />
      <xs:enumeration value=""EFD"" />
      <xs:enumeration value=""ELE"" />
      <xs:enumeration value=""EMC"" />
      <xs:enumeration value=""EMD"" />
      <xs:enumeration value=""ENR"" />
      <xs:enumeration value=""ERN"" />
      <xs:enumeration value=""EVL"" />
      <xs:enumeration value=""EXE"" />
      <xs:enumeration value=""EXR"" />
      <xs:enumeration value=""EXT"" />
      <xs:enumeration value=""FEE"" />
      <xs:enumeration value=""FUT"" />
      <xs:enumeration value=""GEN"" />
      <xs:enumeration value=""GPI"" />
      <xs:enumeration value=""GSI"" />
      <xs:enumeration value=""HHI"" />
      <xs:enumeration value=""ICN"" />
      <xs:enumeration value=""IDT"" />
      <xs:enumeration value=""IID"" />
      <xs:enumeration value=""IIE"" />
      <xs:enumeration value=""IIR"" />
      <xs:enumeration value=""IMP"" />
      <xs:enumeration value=""INS"" />
      <xs:enumeration value=""INT"" />
      <xs:enumeration value=""INV"" />
      <xs:enumeration value=""IVC"" />
      <xs:enumeration value=""JVD"" />
      <xs:enumeration value=""LAB"" />
      <xs:enumeration value=""LBD"" />
      <xs:enumeration value=""LBS"" />
      <xs:enumeration value=""LEN"" />
      <xs:enumeration value=""LIN"" />
      <xs:enumeration value=""LIQ"" />
      <xs:enumeration value=""LLA"" />
      <xs:enumeration value=""LLB"" />
      <xs:enumeration value=""LLC"" />
      <xs:enumeration value=""LOC"" />
      <xs:enumeration value=""LOI"" />
      <xs:enumeration value=""LSD"" />
      <xs:enumeration value=""MCD"" />
      <xs:enumeration value=""MDO"" />
      <xs:enumeration value=""MED"" />
      <xs:enumeration value=""MFG"" />
      <xs:enumeration value=""MKN"" />
      <xs:enumeration value=""MMD"" />
      <xs:enumeration value=""MSD"" />
      <xs:enumeration value=""NCD"" />
      <xs:enumeration value=""NPD"" />
      <xs:enumeration value=""NTR"" />
      <xs:enumeration value=""OBI"" />
      <xs:enumeration value=""OBL"" />
      <xs:enumeration value=""OCA"" />
      <xs:enumeration value=""OCC"" />
      <xs:enumeration value=""OCL"" />
      <xs:enumeration value=""OCP"" />
      <xs:enumeration value=""OCR"" />
      <xs:enumeration value=""ODT"" />
      <xs:enumeration value=""OLS"" />
      <xs:enumeration value=""OPO"" />
      <xs:enumeration value=""ORA"" />
      <xs:enumeration value=""ORE"" />
      <xs:enumeration value=""ORI"" />
      <xs:enumeration value=""OTH"" />
      <xs:enumeration value=""OTN"" />
      <xs:enumeration value=""OTS"" />
      <xs:enumeration value=""PAY"" />
      <xs:enumeration value=""PCS"" />
      <xs:enumeration value=""PDS"" />
      <xs:enumeration value=""PED"" />
      <xs:enumeration value=""PEN"" />
      <xs:enumeration value=""PES"" />
      <xs:enumeration value=""PID"" />
      <xs:enumeration value=""PKG"" />
      <xs:enumeration value=""PMT"" />
      <xs:enumeration value=""POB"" />
      <xs:enumeration value=""POC"" />
      <xs:enumeration value=""POL"" />
      <xs:enumeration value=""PPC"" />
      <xs:enumeration value=""PRI"" />
      <xs:enumeration value=""PRN"" />
      <xs:enumeration value=""PRO"" />
      <xs:enumeration value=""PRR"" />
      <xs:enumeration value=""PSY"" />
      <xs:enumeration value=""PUR"" />
      <xs:enumeration value=""QUL"" />
      <xs:enumeration value=""QUT"" />
      <xs:enumeration value=""RDI"" />
      <xs:enumeration value=""REC"" />
      <xs:enumeration value=""REG"" />
      <xs:enumeration value=""REP"" />
      <xs:enumeration value=""REV"" />
      <xs:enumeration value=""RFL"" />
      <xs:enumeration value=""RHB"" />
      <xs:enumeration value=""RLA"" />
      <xs:enumeration value=""RLH"" />
      <xs:enumeration value=""RNH"" />
      <xs:enumeration value=""RNI"" />
      <xs:enumeration value=""ROU"" />
      <xs:enumeration value=""RPT"" />
      <xs:enumeration value=""RST"" />
      <xs:enumeration value=""RVC"" />
      <xs:enumeration value=""SAN"" />
      <xs:enumeration value=""SCN"" />
      <xs:enumeration value=""SDD"" />
      <xs:enumeration value=""SET"" />
      <xs:enumeration value=""SFM"" />
      <xs:enumeration value=""SMD"" />
      <xs:enumeration value=""SOB"" />
      <xs:enumeration value=""SOW"" />
      <xs:enumeration value=""SPH"" />
      <xs:enumeration value=""SPT"" />
      <xs:enumeration value=""SPV"" />
      <xs:enumeration value=""SSA"" />
      <xs:enumeration value=""SSC"" />
      <xs:enumeration value=""SSD"" />
      <xs:enumeration value=""SSE"" />
      <xs:enumeration value=""SSG"" />
      <xs:enumeration value=""SSH"" />
      <xs:enumeration value=""SSI"" />
      <xs:enumeration value=""SSS"" />
      <xs:enumeration value=""SST"" />
      <xs:enumeration value=""TAF"" />
      <xs:enumeration value=""TCF"" />
      <xs:enumeration value=""TDA"" />
      <xs:enumeration value=""TES"" />
      <xs:enumeration value=""TIL"" />
      <xs:enumeration value=""TLF"" />
      <xs:enumeration value=""TLR"" />
      <xs:enumeration value=""TPO"" />
      <xs:enumeration value=""TRA"" />
      <xs:enumeration value=""TRE"" />
      <xs:enumeration value=""TRF"" />
      <xs:enumeration value=""TRS"" />
      <xs:enumeration value=""TSD"" />
      <xs:enumeration value=""TSF"" />
      <xs:enumeration value=""TST"" />
      <xs:enumeration value=""UPI"" />
      <xs:enumeration value=""VEC"" />
      <xs:enumeration value=""VNN"" />
      <xs:enumeration value=""WHI"" />
      <xs:enumeration value=""WRP"" />
      <xs:enumeration value=""ZZZ"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""X12_ID_91"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""6"" />
      <xs:enumeration value=""7"" />
      <xs:enumeration value=""A"" />
      <xs:enumeration value=""AC"" />
      <xs:enumeration value=""AE"" />
      <xs:enumeration value=""AF"" />
      <xs:enumeration value=""AH"" />
      <xs:enumeration value=""AR"" />
      <xs:enumeration value=""B"" />
      <xs:enumeration value=""BP"" />
      <xs:enumeration value=""BU"" />
      <xs:enumeration value=""C"" />
      <xs:enumeration value=""CE"" />
      <xs:enumeration value=""D"" />
      <xs:enumeration value=""DA"" />
      <xs:enumeration value=""DW"" />
      <xs:enumeration value=""E"" />
      <xs:enumeration value=""ED"" />
      <xs:enumeration value=""F"" />
      <xs:enumeration value=""FA"" />
      <xs:enumeration value=""FL"" />
      <xs:enumeration value=""GG"" />
      <xs:enumeration value=""GR"" />
      <xs:enumeration value=""GS"" />
      <xs:enumeration value=""H"" />
      <xs:enumeration value=""HH"" />
      <xs:enumeration value=""I"" />
      <xs:enumeration value=""J"" />
      <xs:enumeration value=""K"" />
      <xs:enumeration value=""L"" />
      <xs:enumeration value=""LA"" />
      <xs:enumeration value=""LT"" />
      <xs:enumeration value=""M"" />
      <xs:enumeration value=""MB"" />
      <xs:enumeration value=""MP"" />
      <xs:enumeration value=""N"" />
      <xs:enumeration value=""O"" />
      <xs:enumeration value=""P"" />
      <xs:enumeration value=""PA"" />
      <xs:enumeration value=""PG"" />
      <xs:enumeration value=""PL"" />
      <xs:enumeration value=""PP"" />
      <xs:enumeration value=""PR"" />
      <xs:enumeration value=""PT"" />
      <xs:enumeration value=""Q"" />
      <xs:enumeration value=""R"" />
      <xs:enumeration value=""RC"" />
      <xs:enumeration value=""RR"" />
      <xs:enumeration value=""S"" />
      <xs:enumeration value=""SB"" />
      <xs:enumeration value=""SC"" />
      <xs:enumeration value=""SD"" />
      <xs:enumeration value=""SE"" />
      <xs:enumeration value=""SR"" />
      <xs:enumeration value=""SS"" />
      <xs:enumeration value=""ST"" />
      <xs:enumeration value=""T"" />
      <xs:enumeration value=""TA"" />
      <xs:enumeration value=""TC"" />
      <xs:enumeration value=""TT"" />
      <xs:enumeration value=""U"" />
      <xs:enumeration value=""VA"" />
      <xs:enumeration value=""VE"" />
      <xs:enumeration value=""VL"" />
      <xs:enumeration value=""W"" />
      <xs:enumeration value=""WP"" />
      <xs:enumeration value=""X"" />
      <xs:enumeration value=""Y"" />
      <xs:enumeration value=""Y1"" />
      <xs:enumeration value=""Y2"" />
      <xs:enumeration value=""ZZ"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""X12_ID_146"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""11"" />
      <xs:enumeration value=""BP"" />
      <xs:enumeration value=""CA"" />
      <xs:enumeration value=""CC"" />
      <xs:enumeration value=""CD"" />
      <xs:enumeration value=""CF"" />
      <xs:enumeration value=""DE"" />
      <xs:enumeration value=""DF"" />
      <xs:enumeration value=""FO"" />
      <xs:enumeration value=""HP"" />
      <xs:enumeration value=""MX"" />
      <xs:enumeration value=""NC"" />
      <xs:enumeration value=""NR"" />
      <xs:enumeration value=""PA"" />
      <xs:enumeration value=""PB"" />
      <xs:enumeration value=""PC"" />
      <xs:enumeration value=""PD"" />
      <xs:enumeration value=""PE"" />
      <xs:enumeration value=""PL"" />
      <xs:enumeration value=""PO"" />
      <xs:enumeration value=""PP"" />
      <xs:enumeration value=""PS"" />
      <xs:enumeration value=""PU"" />
      <xs:enumeration value=""RC"" />
      <xs:enumeration value=""RF"" />
      <xs:enumeration value=""RS"" />
      <xs:enumeration value=""TP"" />
      <xs:enumeration value=""WC"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""X12_ID_40"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""20"" />
      <xs:enumeration value=""2B"" />
      <xs:enumeration value=""2D"" />
      <xs:enumeration value=""2E"" />
      <xs:enumeration value=""2F"" />
      <xs:enumeration value=""2G"" />
      <xs:enumeration value=""40"" />
      <xs:enumeration value=""4B"" />
      <xs:enumeration value=""AC"" />
      <xs:enumeration value=""AF"" />
      <xs:enumeration value=""AL"" />
      <xs:enumeration value=""AP"" />
      <xs:enumeration value=""AT"" />
      <xs:enumeration value=""BC"" />
      <xs:enumeration value=""BE"" />
      <xs:enumeration value=""BF"" />
      <xs:enumeration value=""BG"" />
      <xs:enumeration value=""BH"" />
      <xs:enumeration value=""BJ"" />
      <xs:enumeration value=""BK"" />
      <xs:enumeration value=""BO"" />
      <xs:enumeration value=""BR"" />
      <xs:enumeration value=""BX"" />
      <xs:enumeration value=""CA"" />
      <xs:enumeration value=""CB"" />
      <xs:enumeration value=""CC"" />
      <xs:enumeration value=""CD"" />
      <xs:enumeration value=""CG"" />
      <xs:enumeration value=""CH"" />
      <xs:enumeration value=""CI"" />
      <xs:enumeration value=""CJ"" />
      <xs:enumeration value=""CK"" />
      <xs:enumeration value=""CL"" />
      <xs:enumeration value=""CM"" />
      <xs:enumeration value=""CN"" />
      <xs:enumeration value=""CP"" />
      <xs:enumeration value=""CQ"" />
      <xs:enumeration value=""CR"" />
      <xs:enumeration value=""CS"" />
      <xs:enumeration value=""CT"" />
      <xs:enumeration value=""CU"" />
      <xs:enumeration value=""CV"" />
      <xs:enumeration value=""CW"" />
      <xs:enumeration value=""CX"" />
      <xs:enumeration value=""CZ"" />
      <xs:enumeration value=""DD"" />
      <xs:enumeration value=""DF"" />
      <xs:enumeration value=""DT"" />
      <xs:enumeration value=""DX"" />
      <xs:enumeration value=""ET"" />
      <xs:enumeration value=""FF"" />
      <xs:enumeration value=""FH"" />
      <xs:enumeration value=""FN"" />
      <xs:enumeration value=""FP"" />
      <xs:enumeration value=""FR"" />
      <xs:enumeration value=""FS"" />
      <xs:enumeration value=""FT"" />
      <xs:enumeration value=""FX"" />
      <xs:enumeration value=""GS"" />
      <xs:enumeration value=""HB"" />
      <xs:enumeration value=""HC"" />
      <xs:enumeration value=""HO"" />
      <xs:enumeration value=""HP"" />
      <xs:enumeration value=""HT"" />
      <xs:enumeration value=""HV"" />
      <xs:enumeration value=""HY"" />
      <xs:enumeration value=""ID"" />
      <xs:enumeration value=""IX"" />
      <xs:enumeration value=""LO"" />
      <xs:enumeration value=""LS"" />
      <xs:enumeration value=""LU"" />
      <xs:enumeration value=""NX"" />
      <xs:enumeration value=""OB"" />
      <xs:enumeration value=""OT"" />
      <xs:enumeration value=""OV"" />
      <xs:enumeration value=""PL"" />
      <xs:enumeration value=""PP"" />
      <xs:enumeration value=""PT"" />
      <xs:enumeration value=""PU"" />
      <xs:enumeration value=""RA"" />
      <xs:enumeration value=""RC"" />
      <xs:enumeration value=""RD"" />
      <xs:enumeration value=""RE"" />
      <xs:enumeration value=""RF"" />
      <xs:enumeration value=""RG"" />
      <xs:enumeration value=""RI"" />
      <xs:enumeration value=""RO"" />
      <xs:enumeration value=""RR"" />
      <xs:enumeration value=""RS"" />
      <xs:enumeration value=""RT"" />
      <xs:enumeration value=""SA"" />
      <xs:enumeration value=""SC"" />
      <xs:enumeration value=""SD"" />
      <xs:enumeration value=""SK"" />
      <xs:enumeration value=""SL"" />
      <xs:enumeration value=""SR"" />
      <xs:enumeration value=""SS"" />
      <xs:enumeration value=""ST"" />
      <xs:enumeration value=""SV"" />
      <xs:enumeration value=""TA"" />
      <xs:enumeration value=""TB"" />
      <xs:enumeration value=""TC"" />
      <xs:enumeration value=""TF"" />
      <xs:enumeration value=""TG"" />
      <xs:enumeration value=""TH"" />
      <xs:enumeration value=""TI"" />
      <xs:enumeration value=""TJ"" />
      <xs:enumeration value=""TK"" />
      <xs:enumeration value=""TL"" />
      <xs:enumeration value=""TM"" />
      <xs:enumeration value=""TN"" />
      <xs:enumeration value=""TO"" />
      <xs:enumeration value=""TP"" />
      <xs:enumeration value=""TQ"" />
      <xs:enumeration value=""TR"" />
      <xs:enumeration value=""TT"" />
      <xs:enumeration value=""TU"" />
      <xs:enumeration value=""TV"" />
      <xs:enumeration value=""TW"" />
      <xs:enumeration value=""UA"" />
      <xs:enumeration value=""UB"" />
      <xs:enumeration value=""UC"" />
      <xs:enumeration value=""UD"" />
      <xs:enumeration value=""UE"" />
      <xs:enumeration value=""UL"" />
      <xs:enumeration value=""UP"" />
      <xs:enumeration value=""VA"" />
      <xs:enumeration value=""VE"" />
      <xs:enumeration value=""VL"" />
      <xs:enumeration value=""VR"" />
      <xs:enumeration value=""VS"" />
      <xs:enumeration value=""VT"" />
      <xs:enumeration value=""WR"" />
      <xs:enumeration value=""WY"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""X12_ID_368"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""AA"" />
      <xs:enumeration value=""AB"" />
      <xs:enumeration value=""AN"" />
      <xs:enumeration value=""AP"" />
      <xs:enumeration value=""AS"" />
      <xs:enumeration value=""AU"" />
      <xs:enumeration value=""AV"" />
      <xs:enumeration value=""BK"" />
      <xs:enumeration value=""BM"" />
      <xs:enumeration value=""BO"" />
      <xs:enumeration value=""BP"" />
      <xs:enumeration value=""BT"" />
      <xs:enumeration value=""BW"" />
      <xs:enumeration value=""CA"" />
      <xs:enumeration value=""CB"" />
      <xs:enumeration value=""CC"" />
      <xs:enumeration value=""CD"" />
      <xs:enumeration value=""CE"" />
      <xs:enumeration value=""CF"" />
      <xs:enumeration value=""CI"" />
      <xs:enumeration value=""CK"" />
      <xs:enumeration value=""CL"" />
      <xs:enumeration value=""CM"" />
      <xs:enumeration value=""CN"" />
      <xs:enumeration value=""CO"" />
      <xs:enumeration value=""CP"" />
      <xs:enumeration value=""CS"" />
      <xs:enumeration value=""CT"" />
      <xs:enumeration value=""CU"" />
      <xs:enumeration value=""DA"" />
      <xs:enumeration value=""DD"" />
      <xs:enumeration value=""DE"" />
      <xs:enumeration value=""DI"" />
      <xs:enumeration value=""DO"" />
      <xs:enumeration value=""DP"" />
      <xs:enumeration value=""DR"" />
      <xs:enumeration value=""DS"" />
      <xs:enumeration value=""EC"" />
      <xs:enumeration value=""ED"" />
      <xs:enumeration value=""EW"" />
      <xs:enumeration value=""EX"" />
      <xs:enumeration value=""FS"" />
      <xs:enumeration value=""HQ"" />
      <xs:enumeration value=""IC"" />
      <xs:enumeration value=""ID"" />
      <xs:enumeration value=""IN"" />
      <xs:enumeration value=""IP"" />
      <xs:enumeration value=""IS"" />
      <xs:enumeration value=""LM"" />
      <xs:enumeration value=""LS"" />
      <xs:enumeration value=""LW"" />
      <xs:enumeration value=""MC"" />
      <xs:enumeration value=""NF"" />
      <xs:enumeration value=""NN"" />
      <xs:enumeration value=""NS"" />
      <xs:enumeration value=""NY"" />
      <xs:enumeration value=""OB"" />
      <xs:enumeration value=""OF"" />
      <xs:enumeration value=""OP"" />
      <xs:enumeration value=""OR"" />
      <xs:enumeration value=""PA"" />
      <xs:enumeration value=""PC"" />
      <xs:enumeration value=""PD"" />
      <xs:enumeration value=""PH"" />
      <xs:enumeration value=""PI"" />
      <xs:enumeration value=""PK"" />
      <xs:enumeration value=""PL"" />
      <xs:enumeration value=""PN"" />
      <xs:enumeration value=""PO"" />
      <xs:enumeration value=""PP"" />
      <xs:enumeration value=""PR"" />
      <xs:enumeration value=""PS"" />
      <xs:enumeration value=""PT"" />
      <xs:enumeration value=""QN"" />
      <xs:enumeration value=""QP"" />
      <xs:enumeration value=""RC"" />
      <xs:enumeration value=""RD"" />
      <xs:enumeration value=""RI"" />
      <xs:enumeration value=""RT"" />
      <xs:enumeration value=""RW"" />
      <xs:enumeration value=""SA"" />
      <xs:enumeration value=""SB"" />
      <xs:enumeration value=""SC"" />
      <xs:enumeration value=""SD"" />
      <xs:enumeration value=""SE"" />
      <xs:enumeration value=""SF"" />
      <xs:enumeration value=""SG"" />
      <xs:enumeration value=""SH"" />
      <xs:enumeration value=""SI"" />
      <xs:enumeration value=""SJ"" />
      <xs:enumeration value=""SK"" />
      <xs:enumeration value=""SL"" />
      <xs:enumeration value=""SP"" />
      <xs:enumeration value=""SQ"" />
      <xs:enumeration value=""SS"" />
      <xs:enumeration value=""ST"" />
      <xs:enumeration value=""SU"" />
      <xs:enumeration value=""UB"" />
      <xs:enumeration value=""UN"" />
      <xs:enumeration value=""UR"" />
      <xs:enumeration value=""WS"" />
      <xs:enumeration value=""ZZ"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""X12_ID_890"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""01"" />
      <xs:enumeration value=""02"" />
      <xs:enumeration value=""03"" />
      <xs:enumeration value=""04"" />
      <xs:enumeration value=""05"" />
      <xs:enumeration value=""06"" />
      <xs:enumeration value=""07"" />
      <xs:enumeration value=""08"" />
      <xs:enumeration value=""09"" />
      <xs:enumeration value=""10"" />
      <xs:enumeration value=""11"" />
      <xs:enumeration value=""12"" />
      <xs:enumeration value=""13"" />
      <xs:enumeration value=""14"" />
      <xs:enumeration value=""15"" />
      <xs:enumeration value=""ZZ"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""X12_ID_604"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""C"" />
      <xs:enumeration value=""N"" />
      <xs:enumeration value=""W"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""X12_ID_187"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""A"" />
      <xs:enumeration value=""A1"" />
      <xs:enumeration value=""A2"" />
      <xs:enumeration value=""A3"" />
      <xs:enumeration value=""A4"" />
      <xs:enumeration value=""B"" />
      <xs:enumeration value=""C"" />
      <xs:enumeration value=""CD"" />
      <xs:enumeration value=""CE"" />
      <xs:enumeration value=""D"" />
      <xs:enumeration value=""DR"" />
      <xs:enumeration value=""E"" />
      <xs:enumeration value=""F"" />
      <xs:enumeration value=""FR"" />
      <xs:enumeration value=""G"" />
      <xs:enumeration value=""H"" />
      <xs:enumeration value=""I"" />
      <xs:enumeration value=""J"" />
      <xs:enumeration value=""K"" />
      <xs:enumeration value=""L"" />
      <xs:enumeration value=""LC"" />
      <xs:enumeration value=""M"" />
      <xs:enumeration value=""N"" />
      <xs:enumeration value=""ND"" />
      <xs:enumeration value=""NI"" />
      <xs:enumeration value=""NR"" />
      <xs:enumeration value=""NT"" />
      <xs:enumeration value=""O"" />
      <xs:enumeration value=""P"" />
      <xs:enumeration value=""PA"" />
      <xs:enumeration value=""Q"" />
      <xs:enumeration value=""R"" />
      <xs:enumeration value=""RG"" />
      <xs:enumeration value=""RN"" />
      <xs:enumeration value=""RT"" />
      <xs:enumeration value=""S"" />
      <xs:enumeration value=""SF"" />
      <xs:enumeration value=""SI"" />
      <xs:enumeration value=""SK"" />
      <xs:enumeration value=""SO"" />
      <xs:enumeration value=""T"" />
      <xs:enumeration value=""U"" />
      <xs:enumeration value=""V"" />
      <xs:enumeration value=""W"" />
      <xs:enumeration value=""WA"" />
      <xs:enumeration value=""WB"" />
      <xs:enumeration value=""WG"" />
      <xs:enumeration value=""WJ"" />
      <xs:enumeration value=""X"" />
      <xs:enumeration value=""Y"" />
      <xs:enumeration value=""Z"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""X12_ID_188"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""E"" />
      <xs:enumeration value=""G"" />
      <xs:enumeration value=""K"" />
      <xs:enumeration value=""L"" />
      <xs:enumeration value=""M"" />
      <xs:enumeration value=""O"" />
      <xs:enumeration value=""S"" />
      <xs:enumeration value=""T"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""X12_ID_400"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""01"" />
      <xs:enumeration value=""02"" />
      <xs:enumeration value=""03"" />
      <xs:enumeration value=""04"" />
      <xs:enumeration value=""05"" />
      <xs:enumeration value=""06"" />
      <xs:enumeration value=""07"" />
      <xs:enumeration value=""08"" />
      <xs:enumeration value=""09"" />
      <xs:enumeration value=""10"" />
      <xs:enumeration value=""11"" />
      <xs:enumeration value=""ZZ"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""X12_ID_399"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""1"" />
      <xs:enumeration value=""2"" />
      <xs:enumeration value=""3"" />
      <xs:enumeration value=""4"" />
      <xs:enumeration value=""5"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""X12_ID_355"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""01"" />
      <xs:enumeration value=""02"" />
      <xs:enumeration value=""03"" />
      <xs:enumeration value=""04"" />
      <xs:enumeration value=""05"" />
      <xs:enumeration value=""06"" />
      <xs:enumeration value=""07"" />
      <xs:enumeration value=""08"" />
      <xs:enumeration value=""09"" />
      <xs:enumeration value=""10"" />
      <xs:enumeration value=""11"" />
      <xs:enumeration value=""12"" />
      <xs:enumeration value=""13"" />
      <xs:enumeration value=""14"" />
      <xs:enumeration value=""15"" />
      <xs:enumeration value=""16"" />
      <xs:enumeration value=""17"" />
      <xs:enumeration value=""18"" />
      <xs:enumeration value=""19"" />
      <xs:enumeration value=""1A"" />
      <xs:enumeration value=""1B"" />
      <xs:enumeration value=""1C"" />
      <xs:enumeration value=""1D"" />
      <xs:enumeration value=""1E"" />
      <xs:enumeration value=""1F"" />
      <xs:enumeration value=""1G"" />
      <xs:enumeration value=""1H"" />
      <xs:enumeration value=""1I"" />
      <xs:enumeration value=""1J"" />
      <xs:enumeration value=""1K"" />
      <xs:enumeration value=""1L"" />
      <xs:enumeration value=""1M"" />
      <xs:enumeration value=""1N"" />
      <xs:enumeration value=""1O"" />
      <xs:enumeration value=""1P"" />
      <xs:enumeration value=""1Q"" />
      <xs:enumeration value=""1R"" />
      <xs:enumeration value=""1X"" />
      <xs:enumeration value=""20"" />
      <xs:enumeration value=""21"" />
      <xs:enumeration value=""22"" />
      <xs:enumeration value=""23"" />
      <xs:enumeration value=""24"" />
      <xs:enumeration value=""25"" />
      <xs:enumeration value=""26"" />
      <xs:enumeration value=""27"" />
      <xs:enumeration value=""28"" />
      <xs:enumeration value=""29"" />
      <xs:enumeration value=""2A"" />
      <xs:enumeration value=""2B"" />
      <xs:enumeration value=""2C"" />
      <xs:enumeration value=""2F"" />
      <xs:enumeration value=""2G"" />
      <xs:enumeration value=""2H"" />
      <xs:enumeration value=""2I"" />
      <xs:enumeration value=""2J"" />
      <xs:enumeration value=""2K"" />
      <xs:enumeration value=""2L"" />
      <xs:enumeration value=""2M"" />
      <xs:enumeration value=""2N"" />
      <xs:enumeration value=""2P"" />
      <xs:enumeration value=""2Q"" />
      <xs:enumeration value=""2R"" />
      <xs:enumeration value=""2U"" />
      <xs:enumeration value=""2V"" />
      <xs:enumeration value=""2W"" />
      <xs:enumeration value=""2X"" />
      <xs:enumeration value=""2Y"" />
      <xs:enumeration value=""2Z"" />
      <xs:enumeration value=""30"" />
      <xs:enumeration value=""31"" />
      <xs:enumeration value=""32"" />
      <xs:enumeration value=""33"" />
      <xs:enumeration value=""34"" />
      <xs:enumeration value=""35"" />
      <xs:enumeration value=""36"" />
      <xs:enumeration value=""37"" />
      <xs:enumeration value=""38"" />
      <xs:enumeration value=""39"" />
      <xs:enumeration value=""3B"" />
      <xs:enumeration value=""3C"" />
      <xs:enumeration value=""3E"" />
      <xs:enumeration value=""3F"" />
      <xs:enumeration value=""3G"" />
      <xs:enumeration value=""3H"" />
      <xs:enumeration value=""3I"" />
      <xs:enumeration value=""40"" />
      <xs:enumeration value=""41"" />
      <xs:enumeration value=""43"" />
      <xs:enumeration value=""44"" />
      <xs:enumeration value=""45"" />
      <xs:enumeration value=""46"" />
      <xs:enumeration value=""47"" />
      <xs:enumeration value=""48"" />
      <xs:enumeration value=""4A"" />
      <xs:enumeration value=""4B"" />
      <xs:enumeration value=""4C"" />
      <xs:enumeration value=""4D"" />
      <xs:enumeration value=""4E"" />
      <xs:enumeration value=""4F"" />
      <xs:enumeration value=""4G"" />
      <xs:enumeration value=""4H"" />
      <xs:enumeration value=""4I"" />
      <xs:enumeration value=""4J"" />
      <xs:enumeration value=""4K"" />
      <xs:enumeration value=""4L"" />
      <xs:enumeration value=""4M"" />
      <xs:enumeration value=""4N"" />
      <xs:enumeration value=""4O"" />
      <xs:enumeration value=""4P"" />
      <xs:enumeration value=""4Q"" />
      <xs:enumeration value=""4R"" />
      <xs:enumeration value=""4S"" />
      <xs:enumeration value=""4T"" />
      <xs:enumeration value=""4U"" />
      <xs:enumeration value=""4V"" />
      <xs:enumeration value=""4W"" />
      <xs:enumeration value=""4X"" />
      <xs:enumeration value=""50"" />
      <xs:enumeration value=""51"" />
      <xs:enumeration value=""52"" />
      <xs:enumeration value=""53"" />
      <xs:enumeration value=""54"" />
      <xs:enumeration value=""56"" />
      <xs:enumeration value=""57"" />
      <xs:enumeration value=""58"" />
      <xs:enumeration value=""59"" />
      <xs:enumeration value=""5A"" />
      <xs:enumeration value=""5B"" />
      <xs:enumeration value=""5C"" />
      <xs:enumeration value=""5E"" />
      <xs:enumeration value=""5F"" />
      <xs:enumeration value=""5G"" />
      <xs:enumeration value=""5H"" />
      <xs:enumeration value=""5I"" />
      <xs:enumeration value=""5J"" />
      <xs:enumeration value=""5K"" />
      <xs:enumeration value=""5P"" />
      <xs:enumeration value=""5Q"" />
      <xs:enumeration value=""60"" />
      <xs:enumeration value=""61"" />
      <xs:enumeration value=""62"" />
      <xs:enumeration value=""63"" />
      <xs:enumeration value=""64"" />
      <xs:enumeration value=""65"" />
      <xs:enumeration value=""66"" />
      <xs:enumeration value=""67"" />
      <xs:enumeration value=""68"" />
      <xs:enumeration value=""69"" />
      <xs:enumeration value=""70"" />
      <xs:enumeration value=""71"" />
      <xs:enumeration value=""72"" />
      <xs:enumeration value=""73"" />
      <xs:enumeration value=""74"" />
      <xs:enumeration value=""76"" />
      <xs:enumeration value=""77"" />
      <xs:enumeration value=""78"" />
      <xs:enumeration value=""79"" />
      <xs:enumeration value=""80"" />
      <xs:enumeration value=""81"" />
      <xs:enumeration value=""82"" />
      <xs:enumeration value=""83"" />
      <xs:enumeration value=""84"" />
      <xs:enumeration value=""85"" />
      <xs:enumeration value=""86"" />
      <xs:enumeration value=""87"" />
      <xs:enumeration value=""89"" />
      <xs:enumeration value=""8C"" />
      <xs:enumeration value=""8D"" />
      <xs:enumeration value=""8P"" />
      <xs:enumeration value=""8R"" />
      <xs:enumeration value=""8S"" />
      <xs:enumeration value=""8U"" />
      <xs:enumeration value=""90"" />
      <xs:enumeration value=""91"" />
      <xs:enumeration value=""92"" />
      <xs:enumeration value=""93"" />
      <xs:enumeration value=""94"" />
      <xs:enumeration value=""95"" />
      <xs:enumeration value=""96"" />
      <xs:enumeration value=""97"" />
      <xs:enumeration value=""98"" />
      <xs:enumeration value=""99"" />
      <xs:enumeration value=""A8"" />
      <xs:enumeration value=""AA"" />
      <xs:enumeration value=""AB"" />
      <xs:enumeration value=""AC"" />
      <xs:enumeration value=""AD"" />
      <xs:enumeration value=""AE"" />
      <xs:enumeration value=""AF"" />
      <xs:enumeration value=""AG"" />
      <xs:enumeration value=""AH"" />
      <xs:enumeration value=""AI"" />
      <xs:enumeration value=""AJ"" />
      <xs:enumeration value=""AK"" />
      <xs:enumeration value=""AL"" />
      <xs:enumeration value=""AM"" />
      <xs:enumeration value=""AN"" />
      <xs:enumeration value=""AO"" />
      <xs:enumeration value=""AP"" />
      <xs:enumeration value=""AQ"" />
      <xs:enumeration value=""AR"" />
      <xs:enumeration value=""AS"" />
      <xs:enumeration value=""AT"" />
      <xs:enumeration value=""AU"" />
      <xs:enumeration value=""AV"" />
      <xs:enumeration value=""AW"" />
      <xs:enumeration value=""AX"" />
      <xs:enumeration value=""AY"" />
      <xs:enumeration value=""AZ"" />
      <xs:enumeration value=""B0"" />
      <xs:enumeration value=""B1"" />
      <xs:enumeration value=""B2"" />
      <xs:enumeration value=""B3"" />
      <xs:enumeration value=""B4"" />
      <xs:enumeration value=""B5"" />
      <xs:enumeration value=""B6"" />
      <xs:enumeration value=""B7"" />
      <xs:enumeration value=""B8"" />
      <xs:enumeration value=""B9"" />
      <xs:enumeration value=""BA"" />
      <xs:enumeration value=""BB"" />
      <xs:enumeration value=""BC"" />
      <xs:enumeration value=""BD"" />
      <xs:enumeration value=""BE"" />
      <xs:enumeration value=""BF"" />
      <xs:enumeration value=""BG"" />
      <xs:enumeration value=""BH"" />
      <xs:enumeration value=""BI"" />
      <xs:enumeration value=""BJ"" />
      <xs:enumeration value=""BK"" />
      <xs:enumeration value=""BL"" />
      <xs:enumeration value=""BM"" />
      <xs:enumeration value=""BN"" />
      <xs:enumeration value=""BO"" />
      <xs:enumeration value=""BP"" />
      <xs:enumeration value=""BQ"" />
      <xs:enumeration value=""BR"" />
      <xs:enumeration value=""BS"" />
      <xs:enumeration value=""BT"" />
      <xs:enumeration value=""BU"" />
      <xs:enumeration value=""BV"" />
      <xs:enumeration value=""BW"" />
      <xs:enumeration value=""BX"" />
      <xs:enumeration value=""BY"" />
      <xs:enumeration value=""BZ"" />
      <xs:enumeration value=""C0"" />
      <xs:enumeration value=""C1"" />
      <xs:enumeration value=""C2"" />
      <xs:enumeration value=""C3"" />
      <xs:enumeration value=""C4"" />
      <xs:enumeration value=""C5"" />
      <xs:enumeration value=""C6"" />
      <xs:enumeration value=""C7"" />
      <xs:enumeration value=""C8"" />
      <xs:enumeration value=""C9"" />
      <xs:enumeration value=""CA"" />
      <xs:enumeration value=""CB"" />
      <xs:enumeration value=""CC"" />
      <xs:enumeration value=""CD"" />
      <xs:enumeration value=""CE"" />
      <xs:enumeration value=""CF"" />
      <xs:enumeration value=""CG"" />
      <xs:enumeration value=""CH"" />
      <xs:enumeration value=""CI"" />
      <xs:enumeration value=""CJ"" />
      <xs:enumeration value=""CK"" />
      <xs:enumeration value=""CL"" />
      <xs:enumeration value=""CM"" />
      <xs:enumeration value=""CN"" />
      <xs:enumeration value=""CO"" />
      <xs:enumeration value=""CP"" />
      <xs:enumeration value=""CQ"" />
      <xs:enumeration value=""CR"" />
      <xs:enumeration value=""CS"" />
      <xs:enumeration value=""CT"" />
      <xs:enumeration value=""CU"" />
      <xs:enumeration value=""CV"" />
      <xs:enumeration value=""CW"" />
      <xs:enumeration value=""CX"" />
      <xs:enumeration value=""CY"" />
      <xs:enumeration value=""CZ"" />
      <xs:enumeration value=""D2"" />
      <xs:enumeration value=""D3"" />
      <xs:enumeration value=""D5"" />
      <xs:enumeration value=""D8"" />
      <xs:enumeration value=""D9"" />
      <xs:enumeration value=""DA"" />
      <xs:enumeration value=""DB"" />
      <xs:enumeration value=""DC"" />
      <xs:enumeration value=""DD"" />
      <xs:enumeration value=""DE"" />
      <xs:enumeration value=""DF"" />
      <xs:enumeration value=""DG"" />
      <xs:enumeration value=""DH"" />
      <xs:enumeration value=""DI"" />
      <xs:enumeration value=""DJ"" />
      <xs:enumeration value=""DK"" />
      <xs:enumeration value=""DL"" />
      <xs:enumeration value=""DM"" />
      <xs:enumeration value=""DN"" />
      <xs:enumeration value=""DO"" />
      <xs:enumeration value=""DP"" />
      <xs:enumeration value=""DQ"" />
      <xs:enumeration value=""DR"" />
      <xs:enumeration value=""DS"" />
      <xs:enumeration value=""DT"" />
      <xs:enumeration value=""DU"" />
      <xs:enumeration value=""DW"" />
      <xs:enumeration value=""DX"" />
      <xs:enumeration value=""DY"" />
      <xs:enumeration value=""DZ"" />
      <xs:enumeration value=""E1"" />
      <xs:enumeration value=""E3"" />
      <xs:enumeration value=""E4"" />
      <xs:enumeration value=""E5"" />
      <xs:enumeration value=""E7"" />
      <xs:enumeration value=""E8"" />
      <xs:enumeration value=""E9"" />
      <xs:enumeration value=""EA"" />
      <xs:enumeration value=""EB"" />
      <xs:enumeration value=""EC"" />
      <xs:enumeration value=""ED"" />
      <xs:enumeration value=""EE"" />
      <xs:enumeration value=""EF"" />
      <xs:enumeration value=""EG"" />
      <xs:enumeration value=""EH"" />
      <xs:enumeration value=""EJ"" />
      <xs:enumeration value=""EM"" />
      <xs:enumeration value=""EP"" />
      <xs:enumeration value=""EQ"" />
      <xs:enumeration value=""EV"" />
      <xs:enumeration value=""EX"" />
      <xs:enumeration value=""EY"" />
      <xs:enumeration value=""EZ"" />
      <xs:enumeration value=""F1"" />
      <xs:enumeration value=""F2"" />
      <xs:enumeration value=""F3"" />
      <xs:enumeration value=""F4"" />
      <xs:enumeration value=""F5"" />
      <xs:enumeration value=""F6"" />
      <xs:enumeration value=""F9"" />
      <xs:enumeration value=""FA"" />
      <xs:enumeration value=""FB"" />
      <xs:enumeration value=""FC"" />
      <xs:enumeration value=""FD"" />
      <xs:enumeration value=""FE"" />
      <xs:enumeration value=""FF"" />
      <xs:enumeration value=""FG"" />
      <xs:enumeration value=""FH"" />
      <xs:enumeration value=""FJ"" />
      <xs:enumeration value=""FK"" />
      <xs:enumeration value=""FL"" />
      <xs:enumeration value=""FM"" />
      <xs:enumeration value=""FO"" />
      <xs:enumeration value=""FP"" />
      <xs:enumeration value=""FR"" />
      <xs:enumeration value=""FS"" />
      <xs:enumeration value=""FT"" />
      <xs:enumeration value=""FZ"" />
      <xs:enumeration value=""G2"" />
      <xs:enumeration value=""G3"" />
      <xs:enumeration value=""G4"" />
      <xs:enumeration value=""G5"" />
      <xs:enumeration value=""G7"" />
      <xs:enumeration value=""GA"" />
      <xs:enumeration value=""GB"" />
      <xs:enumeration value=""GC"" />
      <xs:enumeration value=""GD"" />
      <xs:enumeration value=""GE"" />
      <xs:enumeration value=""GF"" />
      <xs:enumeration value=""GG"" />
      <xs:enumeration value=""GH"" />
      <xs:enumeration value=""GI"" />
      <xs:enumeration value=""GJ"" />
      <xs:enumeration value=""GK"" />
      <xs:enumeration value=""GL"" />
      <xs:enumeration value=""GM"" />
      <xs:enumeration value=""GN"" />
      <xs:enumeration value=""GO"" />
      <xs:enumeration value=""GP"" />
      <xs:enumeration value=""GQ"" />
      <xs:enumeration value=""GR"" />
      <xs:enumeration value=""GS"" />
      <xs:enumeration value=""GT"" />
      <xs:enumeration value=""GU"" />
      <xs:enumeration value=""GV"" />
      <xs:enumeration value=""GW"" />
      <xs:enumeration value=""GX"" />
      <xs:enumeration value=""GY"" />
      <xs:enumeration value=""GZ"" />
      <xs:enumeration value=""H1"" />
      <xs:enumeration value=""H2"" />
      <xs:enumeration value=""H4"" />
      <xs:enumeration value=""HA"" />
      <xs:enumeration value=""HB"" />
      <xs:enumeration value=""HC"" />
      <xs:enumeration value=""HD"" />
      <xs:enumeration value=""HE"" />
      <xs:enumeration value=""HF"" />
      <xs:enumeration value=""HG"" />
      <xs:enumeration value=""HH"" />
      <xs:enumeration value=""HI"" />
      <xs:enumeration value=""HJ"" />
      <xs:enumeration value=""HK"" />
      <xs:enumeration value=""HL"" />
      <xs:enumeration value=""HM"" />
      <xs:enumeration value=""HN"" />
      <xs:enumeration value=""HO"" />
      <xs:enumeration value=""HP"" />
      <xs:enumeration value=""HQ"" />
      <xs:enumeration value=""HR"" />
      <xs:enumeration value=""HS"" />
      <xs:enumeration value=""HT"" />
      <xs:enumeration value=""HU"" />
      <xs:enumeration value=""HV"" />
      <xs:enumeration value=""HW"" />
      <xs:enumeration value=""HY"" />
      <xs:enumeration value=""HZ"" />
      <xs:enumeration value=""IA"" />
      <xs:enumeration value=""IB"" />
      <xs:enumeration value=""IC"" />
      <xs:enumeration value=""IE"" />
      <xs:enumeration value=""IF"" />
      <xs:enumeration value=""IH"" />
      <xs:enumeration value=""II"" />
      <xs:enumeration value=""IK"" />
      <xs:enumeration value=""IL"" />
      <xs:enumeration value=""IM"" />
      <xs:enumeration value=""IN"" />
      <xs:enumeration value=""IP"" />
      <xs:enumeration value=""IT"" />
      <xs:enumeration value=""IU"" />
      <xs:enumeration value=""IV"" />
      <xs:enumeration value=""IW"" />
      <xs:enumeration value=""J2"" />
      <xs:enumeration value=""JA"" />
      <xs:enumeration value=""JB"" />
      <xs:enumeration value=""JE"" />
      <xs:enumeration value=""JG"" />
      <xs:enumeration value=""JK"" />
      <xs:enumeration value=""JM"" />
      <xs:enumeration value=""JO"" />
      <xs:enumeration value=""JR"" />
      <xs:enumeration value=""JU"" />
      <xs:enumeration value=""K1"" />
      <xs:enumeration value=""K2"" />
      <xs:enumeration value=""K3"" />
      <xs:enumeration value=""K4"" />
      <xs:enumeration value=""K5"" />
      <xs:enumeration value=""K6"" />
      <xs:enumeration value=""K7"" />
      <xs:enumeration value=""K9"" />
      <xs:enumeration value=""KA"" />
      <xs:enumeration value=""KB"" />
      <xs:enumeration value=""KC"" />
      <xs:enumeration value=""KD"" />
      <xs:enumeration value=""KE"" />
      <xs:enumeration value=""KF"" />
      <xs:enumeration value=""KG"" />
      <xs:enumeration value=""KH"" />
      <xs:enumeration value=""KI"" />
      <xs:enumeration value=""KJ"" />
      <xs:enumeration value=""KK"" />
      <xs:enumeration value=""KL"" />
      <xs:enumeration value=""KM"" />
      <xs:enumeration value=""KO"" />
      <xs:enumeration value=""KP"" />
      <xs:enumeration value=""KQ"" />
      <xs:enumeration value=""KR"" />
      <xs:enumeration value=""KS"" />
      <xs:enumeration value=""KT"" />
      <xs:enumeration value=""KU"" />
      <xs:enumeration value=""KV"" />
      <xs:enumeration value=""KW"" />
      <xs:enumeration value=""KX"" />
      <xs:enumeration value=""L2"" />
      <xs:enumeration value=""LA"" />
      <xs:enumeration value=""LB"" />
      <xs:enumeration value=""LC"" />
      <xs:enumeration value=""LE"" />
      <xs:enumeration value=""LF"" />
      <xs:enumeration value=""LG"" />
      <xs:enumeration value=""LH"" />
      <xs:enumeration value=""LI"" />
      <xs:enumeration value=""LJ"" />
      <xs:enumeration value=""LK"" />
      <xs:enumeration value=""LL"" />
      <xs:enumeration value=""LM"" />
      <xs:enumeration value=""LN"" />
      <xs:enumeration value=""LO"" />
      <xs:enumeration value=""LP"" />
      <xs:enumeration value=""LQ"" />
      <xs:enumeration value=""LR"" />
      <xs:enumeration value=""LS"" />
      <xs:enumeration value=""LT"" />
      <xs:enumeration value=""LX"" />
      <xs:enumeration value=""LY"" />
      <xs:enumeration value=""M0"" />
      <xs:enumeration value=""M1"" />
      <xs:enumeration value=""M2"" />
      <xs:enumeration value=""M3"" />
      <xs:enumeration value=""M4"" />
      <xs:enumeration value=""M5"" />
      <xs:enumeration value=""M6"" />
      <xs:enumeration value=""M7"" />
      <xs:enumeration value=""M8"" />
      <xs:enumeration value=""M9"" />
      <xs:enumeration value=""MA"" />
      <xs:enumeration value=""MB"" />
      <xs:enumeration value=""MC"" />
      <xs:enumeration value=""MD"" />
      <xs:enumeration value=""ME"" />
      <xs:enumeration value=""MF"" />
      <xs:enumeration value=""MG"" />
      <xs:enumeration value=""MH"" />
      <xs:enumeration value=""MI"" />
      <xs:enumeration value=""MJ"" />
      <xs:enumeration value=""MK"" />
      <xs:enumeration value=""ML"" />
      <xs:enumeration value=""MM"" />
      <xs:enumeration value=""MN"" />
      <xs:enumeration value=""MO"" />
      <xs:enumeration value=""MP"" />
      <xs:enumeration value=""MQ"" />
      <xs:enumeration value=""MR"" />
      <xs:enumeration value=""MS"" />
      <xs:enumeration value=""MT"" />
      <xs:enumeration value=""MU"" />
      <xs:enumeration value=""MV"" />
      <xs:enumeration value=""MW"" />
      <xs:enumeration value=""MX"" />
      <xs:enumeration value=""MY"" />
      <xs:enumeration value=""MZ"" />
      <xs:enumeration value=""N1"" />
      <xs:enumeration value=""N2"" />
      <xs:enumeration value=""N3"" />
      <xs:enumeration value=""N4"" />
      <xs:enumeration value=""N6"" />
      <xs:enumeration value=""N7"" />
      <xs:enumeration value=""N9"" />
      <xs:enumeration value=""NA"" />
      <xs:enumeration value=""NB"" />
      <xs:enumeration value=""NC"" />
      <xs:enumeration value=""ND"" />
      <xs:enumeration value=""NE"" />
      <xs:enumeration value=""NF"" />
      <xs:enumeration value=""NG"" />
      <xs:enumeration value=""NH"" />
      <xs:enumeration value=""NI"" />
      <xs:enumeration value=""NJ"" />
      <xs:enumeration value=""NL"" />
      <xs:enumeration value=""NM"" />
      <xs:enumeration value=""NN"" />
      <xs:enumeration value=""NQ"" />
      <xs:enumeration value=""NR"" />
      <xs:enumeration value=""NS"" />
      <xs:enumeration value=""NT"" />
      <xs:enumeration value=""NU"" />
      <xs:enumeration value=""NV"" />
      <xs:enumeration value=""NW"" />
      <xs:enumeration value=""NX"" />
      <xs:enumeration value=""NY"" />
      <xs:enumeration value=""OA"" />
      <xs:enumeration value=""OC"" />
      <xs:enumeration value=""ON"" />
      <xs:enumeration value=""OP"" />
      <xs:enumeration value=""OT"" />
      <xs:enumeration value=""OZ"" />
      <xs:enumeration value=""P0"" />
      <xs:enumeration value=""P1"" />
      <xs:enumeration value=""P2"" />
      <xs:enumeration value=""P3"" />
      <xs:enumeration value=""P4"" />
      <xs:enumeration value=""P5"" />
      <xs:enumeration value=""P6"" />
      <xs:enumeration value=""P7"" />
      <xs:enumeration value=""P8"" />
      <xs:enumeration value=""P9"" />
      <xs:enumeration value=""PA"" />
      <xs:enumeration value=""PB"" />
      <xs:enumeration value=""PC"" />
      <xs:enumeration value=""PD"" />
      <xs:enumeration value=""PE"" />
      <xs:enumeration value=""PF"" />
      <xs:enumeration value=""PG"" />
      <xs:enumeration value=""PH"" />
      <xs:enumeration value=""PI"" />
      <xs:enumeration value=""PJ"" />
      <xs:enumeration value=""PK"" />
      <xs:enumeration value=""PL"" />
      <xs:enumeration value=""PM"" />
      <xs:enumeration value=""PN"" />
      <xs:enumeration value=""PO"" />
      <xs:enumeration value=""PP"" />
      <xs:enumeration value=""PQ"" />
      <xs:enumeration value=""PR"" />
      <xs:enumeration value=""PS"" />
      <xs:enumeration value=""PT"" />
      <xs:enumeration value=""PU"" />
      <xs:enumeration value=""PV"" />
      <xs:enumeration value=""PW"" />
      <xs:enumeration value=""PX"" />
      <xs:enumeration value=""PY"" />
      <xs:enumeration value=""PZ"" />
      <xs:enumeration value=""Q1"" />
      <xs:enumeration value=""Q2"" />
      <xs:enumeration value=""Q3"" />
      <xs:enumeration value=""Q4"" />
      <xs:enumeration value=""Q5"" />
      <xs:enumeration value=""Q6"" />
      <xs:enumeration value=""Q7"" />
      <xs:enumeration value=""QA"" />
      <xs:enumeration value=""QB"" />
      <xs:enumeration value=""QC"" />
      <xs:enumeration value=""QD"" />
      <xs:enumeration value=""QE"" />
      <xs:enumeration value=""QH"" />
      <xs:enumeration value=""QK"" />
      <xs:enumeration value=""QR"" />
      <xs:enumeration value=""QS"" />
      <xs:enumeration value=""QT"" />
      <xs:enumeration value=""QU"" />
      <xs:enumeration value=""R1"" />
      <xs:enumeration value=""R2"" />
      <xs:enumeration value=""R3"" />
      <xs:enumeration value=""R4"" />
      <xs:enumeration value=""R5"" />
      <xs:enumeration value=""R6"" />
      <xs:enumeration value=""R7"" />
      <xs:enumeration value=""R8"" />
      <xs:enumeration value=""R9"" />
      <xs:enumeration value=""RA"" />
      <xs:enumeration value=""RB"" />
      <xs:enumeration value=""RC"" />
      <xs:enumeration value=""RD"" />
      <xs:enumeration value=""RE"" />
      <xs:enumeration value=""RG"" />
      <xs:enumeration value=""RH"" />
      <xs:enumeration value=""RK"" />
      <xs:enumeration value=""RL"" />
      <xs:enumeration value=""RM"" />
      <xs:enumeration value=""RN"" />
      <xs:enumeration value=""RO"" />
      <xs:enumeration value=""RP"" />
      <xs:enumeration value=""RS"" />
      <xs:enumeration value=""RT"" />
      <xs:enumeration value=""RU"" />
      <xs:enumeration value=""S1"" />
      <xs:enumeration value=""S2"" />
      <xs:enumeration value=""S3"" />
      <xs:enumeration value=""S4"" />
      <xs:enumeration value=""S5"" />
      <xs:enumeration value=""S6"" />
      <xs:enumeration value=""S7"" />
      <xs:enumeration value=""S8"" />
      <xs:enumeration value=""S9"" />
      <xs:enumeration value=""SA"" />
      <xs:enumeration value=""SB"" />
      <xs:enumeration value=""SC"" />
      <xs:enumeration value=""SD"" />
      <xs:enumeration value=""SE"" />
      <xs:enumeration value=""SF"" />
      <xs:enumeration value=""SG"" />
      <xs:enumeration value=""SH"" />
      <xs:enumeration value=""SI"" />
      <xs:enumeration value=""SJ"" />
      <xs:enumeration value=""SK"" />
      <xs:enumeration value=""SL"" />
      <xs:enumeration value=""SM"" />
      <xs:enumeration value=""SN"" />
      <xs:enumeration value=""SO"" />
      <xs:enumeration value=""SP"" />
      <xs:enumeration value=""SQ"" />
      <xs:enumeration value=""SR"" />
      <xs:enumeration value=""SS"" />
      <xs:enumeration value=""ST"" />
      <xs:enumeration value=""SV"" />
      <xs:enumeration value=""SW"" />
      <xs:enumeration value=""SX"" />
      <xs:enumeration value=""SY"" />
      <xs:enumeration value=""SZ"" />
      <xs:enumeration value=""T0"" />
      <xs:enumeration value=""T1"" />
      <xs:enumeration value=""T2"" />
      <xs:enumeration value=""T3"" />
      <xs:enumeration value=""T4"" />
      <xs:enumeration value=""T5"" />
      <xs:enumeration value=""T6"" />
      <xs:enumeration value=""T7"" />
      <xs:enumeration value=""T8"" />
      <xs:enumeration value=""T9"" />
      <xs:enumeration value=""TA"" />
      <xs:enumeration value=""TB"" />
      <xs:enumeration value=""TC"" />
      <xs:enumeration value=""TD"" />
      <xs:enumeration value=""TE"" />
      <xs:enumeration value=""TF"" />
      <xs:enumeration value=""TG"" />
      <xs:enumeration value=""TH"" />
      <xs:enumeration value=""TI"" />
      <xs:enumeration value=""TJ"" />
      <xs:enumeration value=""TK"" />
      <xs:enumeration value=""TL"" />
      <xs:enumeration value=""TM"" />
      <xs:enumeration value=""TN"" />
      <xs:enumeration value=""TO"" />
      <xs:enumeration value=""TP"" />
      <xs:enumeration value=""TQ"" />
      <xs:enumeration value=""TR"" />
      <xs:enumeration value=""TS"" />
      <xs:enumeration value=""TT"" />
      <xs:enumeration value=""TU"" />
      <xs:enumeration value=""TV"" />
      <xs:enumeration value=""TW"" />
      <xs:enumeration value=""TX"" />
      <xs:enumeration value=""TY"" />
      <xs:enumeration value=""TZ"" />
      <xs:enumeration value=""U1"" />
      <xs:enumeration value=""U2"" />
      <xs:enumeration value=""U3"" />
      <xs:enumeration value=""U5"" />
      <xs:enumeration value=""UA"" />
      <xs:enumeration value=""UB"" />
      <xs:enumeration value=""UC"" />
      <xs:enumeration value=""UD"" />
      <xs:enumeration value=""UE"" />
      <xs:enumeration value=""UF"" />
      <xs:enumeration value=""UH"" />
      <xs:enumeration value=""UL"" />
      <xs:enumeration value=""UM"" />
      <xs:enumeration value=""UN"" />
      <xs:enumeration value=""UP"" />
      <xs:enumeration value=""UQ"" />
      <xs:enumeration value=""UR"" />
      <xs:enumeration value=""US"" />
      <xs:enumeration value=""UT"" />
      <xs:enumeration value=""UU"" />
      <xs:enumeration value=""UV"" />
      <xs:enumeration value=""UW"" />
      <xs:enumeration value=""UX"" />
      <xs:enumeration value=""UY"" />
      <xs:enumeration value=""UZ"" />
      <xs:enumeration value=""V1"" />
      <xs:enumeration value=""V2"" />
      <xs:enumeration value=""VA"" />
      <xs:enumeration value=""VC"" />
      <xs:enumeration value=""VI"" />
      <xs:enumeration value=""VP"" />
      <xs:enumeration value=""VR"" />
      <xs:enumeration value=""VS"" />
      <xs:enumeration value=""W2"" />
      <xs:enumeration value=""WA"" />
      <xs:enumeration value=""WB"" />
      <xs:enumeration value=""WD"" />
      <xs:enumeration value=""WE"" />
      <xs:enumeration value=""WG"" />
      <xs:enumeration value=""WH"" />
      <xs:enumeration value=""WI"" />
      <xs:enumeration value=""WK"" />
      <xs:enumeration value=""WM"" />
      <xs:enumeration value=""WP"" />
      <xs:enumeration value=""WR"" />
      <xs:enumeration value=""WW"" />
      <xs:enumeration value=""X1"" />
      <xs:enumeration value=""X2"" />
      <xs:enumeration value=""X3"" />
      <xs:enumeration value=""X4"" />
      <xs:enumeration value=""X5"" />
      <xs:enumeration value=""X6"" />
      <xs:enumeration value=""X7"" />
      <xs:enumeration value=""X8"" />
      <xs:enumeration value=""X9"" />
      <xs:enumeration value=""XP"" />
      <xs:enumeration value=""Y1"" />
      <xs:enumeration value=""Y2"" />
      <xs:enumeration value=""Y3"" />
      <xs:enumeration value=""Y4"" />
      <xs:enumeration value=""YD"" />
      <xs:enumeration value=""YL"" />
      <xs:enumeration value=""YR"" />
      <xs:enumeration value=""YT"" />
      <xs:enumeration value=""Z1"" />
      <xs:enumeration value=""Z2"" />
      <xs:enumeration value=""Z3"" />
      <xs:enumeration value=""Z4"" />
      <xs:enumeration value=""Z5"" />
      <xs:enumeration value=""Z6"" />
      <xs:enumeration value=""Z8"" />
      <xs:enumeration value=""ZA"" />
      <xs:enumeration value=""ZB"" />
      <xs:enumeration value=""ZC"" />
      <xs:enumeration value=""ZP"" />
      <xs:enumeration value=""ZZ"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""X12_ID_340"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""1"" />
      <xs:enumeration value=""10"" />
      <xs:enumeration value=""100"" />
      <xs:enumeration value=""101"" />
      <xs:enumeration value=""105"" />
      <xs:enumeration value=""106"" />
      <xs:enumeration value=""107"" />
      <xs:enumeration value=""11"" />
      <xs:enumeration value=""12"" />
      <xs:enumeration value=""13"" />
      <xs:enumeration value=""14"" />
      <xs:enumeration value=""15"" />
      <xs:enumeration value=""16"" />
      <xs:enumeration value=""17"" />
      <xs:enumeration value=""18"" />
      <xs:enumeration value=""19"" />
      <xs:enumeration value=""2"" />
      <xs:enumeration value=""20"" />
      <xs:enumeration value=""21"" />
      <xs:enumeration value=""22"" />
      <xs:enumeration value=""23"" />
      <xs:enumeration value=""24"" />
      <xs:enumeration value=""25"" />
      <xs:enumeration value=""26"" />
      <xs:enumeration value=""27"" />
      <xs:enumeration value=""28"" />
      <xs:enumeration value=""29"" />
      <xs:enumeration value=""3"" />
      <xs:enumeration value=""30"" />
      <xs:enumeration value=""31"" />
      <xs:enumeration value=""32"" />
      <xs:enumeration value=""33"" />
      <xs:enumeration value=""34"" />
      <xs:enumeration value=""4"" />
      <xs:enumeration value=""40"" />
      <xs:enumeration value=""41"" />
      <xs:enumeration value=""42"" />
      <xs:enumeration value=""43"" />
      <xs:enumeration value=""44"" />
      <xs:enumeration value=""45"" />
      <xs:enumeration value=""46"" />
      <xs:enumeration value=""47"" />
      <xs:enumeration value=""48"" />
      <xs:enumeration value=""490"" />
      <xs:enumeration value=""491"" />
      <xs:enumeration value=""499"" />
      <xs:enumeration value=""5"" />
      <xs:enumeration value=""50"" />
      <xs:enumeration value=""501"" />
      <xs:enumeration value=""502"" />
      <xs:enumeration value=""503"" />
      <xs:enumeration value=""504"" />
      <xs:enumeration value=""505"" />
      <xs:enumeration value=""506"" />
      <xs:enumeration value=""507"" />
      <xs:enumeration value=""508"" />
      <xs:enumeration value=""509"" />
      <xs:enumeration value=""51"" />
      <xs:enumeration value=""510"" />
      <xs:enumeration value=""511"" />
      <xs:enumeration value=""512"" />
      <xs:enumeration value=""513"" />
      <xs:enumeration value=""514"" />
      <xs:enumeration value=""515"" />
      <xs:enumeration value=""516"" />
      <xs:enumeration value=""517"" />
      <xs:enumeration value=""518"" />
      <xs:enumeration value=""519"" />
      <xs:enumeration value=""52"" />
      <xs:enumeration value=""520"" />
      <xs:enumeration value=""521"" />
      <xs:enumeration value=""522"" />
      <xs:enumeration value=""523"" />
      <xs:enumeration value=""524"" />
      <xs:enumeration value=""525"" />
      <xs:enumeration value=""526"" />
      <xs:enumeration value=""527"" />
      <xs:enumeration value=""53"" />
      <xs:enumeration value=""537"" />
      <xs:enumeration value=""54"" />
      <xs:enumeration value=""55"" />
      <xs:enumeration value=""550"" />
      <xs:enumeration value=""560"" />
      <xs:enumeration value=""561"" />
      <xs:enumeration value=""562"" />
      <xs:enumeration value=""565"" />
      <xs:enumeration value=""566"" />
      <xs:enumeration value=""57"" />
      <xs:enumeration value=""58"" />
      <xs:enumeration value=""6"" />
      <xs:enumeration value=""60"" />
      <xs:enumeration value=""61"" />
      <xs:enumeration value=""62"" />
      <xs:enumeration value=""63"" />
      <xs:enumeration value=""64"" />
      <xs:enumeration value=""65"" />
      <xs:enumeration value=""66"" />
      <xs:enumeration value=""67"" />
      <xs:enumeration value=""68"" />
      <xs:enumeration value=""70"" />
      <xs:enumeration value=""80"" />
      <xs:enumeration value=""81"" />
      <xs:enumeration value=""88"" />
      <xs:enumeration value=""90"" />
      <xs:enumeration value=""91"" />
      <xs:enumeration value=""92"" />
      <xs:enumeration value=""93"" />
      <xs:enumeration value=""94"" />
      <xs:enumeration value=""95"" />
      <xs:enumeration value=""96"" />
      <xs:enumeration value=""97"" />
      <xs:enumeration value=""990"" />
      <xs:enumeration value=""999"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""X12_ID_331"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""01"" />
      <xs:enumeration value=""02"" />
      <xs:enumeration value=""03"" />
      <xs:enumeration value=""04"" />
      <xs:enumeration value=""05"" />
      <xs:enumeration value=""06"" />
      <xs:enumeration value=""07"" />
      <xs:enumeration value=""08"" />
      <xs:enumeration value=""09"" />
      <xs:enumeration value=""10"" />
      <xs:enumeration value=""11"" />
      <xs:enumeration value=""12"" />
      <xs:enumeration value=""13"" />
      <xs:enumeration value=""15"" />
      <xs:enumeration value=""18"" />
      <xs:enumeration value=""20"" />
      <xs:enumeration value=""21"" />
      <xs:enumeration value=""25"" />
      <xs:enumeration value=""CA"" />
      <xs:enumeration value=""CC"" />
      <xs:enumeration value=""PP"" />
      <xs:enumeration value=""ZZ"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""X12_ID_559"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""10"" />
      <xs:enumeration value=""11"" />
      <xs:enumeration value=""12"" />
      <xs:enumeration value=""13"" />
      <xs:enumeration value=""14"" />
      <xs:enumeration value=""15"" />
      <xs:enumeration value=""16"" />
      <xs:enumeration value=""17"" />
      <xs:enumeration value=""18"" />
      <xs:enumeration value=""19"" />
      <xs:enumeration value=""20"" />
      <xs:enumeration value=""21"" />
      <xs:enumeration value=""22"" />
      <xs:enumeration value=""23"" />
      <xs:enumeration value=""24"" />
      <xs:enumeration value=""25"" />
      <xs:enumeration value=""26"" />
      <xs:enumeration value=""27"" />
      <xs:enumeration value=""28"" />
      <xs:enumeration value=""29"" />
      <xs:enumeration value=""30"" />
      <xs:enumeration value=""31"" />
      <xs:enumeration value=""32"" />
      <xs:enumeration value=""33"" />
      <xs:enumeration value=""34"" />
      <xs:enumeration value=""35"" />
      <xs:enumeration value=""36"" />
      <xs:enumeration value=""37"" />
      <xs:enumeration value=""38"" />
      <xs:enumeration value=""39"" />
      <xs:enumeration value=""40"" />
      <xs:enumeration value=""41"" />
      <xs:enumeration value=""42"" />
      <xs:enumeration value=""43"" />
      <xs:enumeration value=""44"" />
      <xs:enumeration value=""45"" />
      <xs:enumeration value=""46"" />
      <xs:enumeration value=""47"" />
      <xs:enumeration value=""48"" />
      <xs:enumeration value=""49"" />
      <xs:enumeration value=""50"" />
      <xs:enumeration value=""51"" />
      <xs:enumeration value=""52"" />
      <xs:enumeration value=""53"" />
      <xs:enumeration value=""54"" />
      <xs:enumeration value=""55"" />
      <xs:enumeration value=""56"" />
      <xs:enumeration value=""57"" />
      <xs:enumeration value=""58"" />
      <xs:enumeration value=""59"" />
      <xs:enumeration value=""60"" />
      <xs:enumeration value=""93"" />
      <xs:enumeration value=""94"" />
      <xs:enumeration value=""A1"" />
      <xs:enumeration value=""A2"" />
      <xs:enumeration value=""A3"" />
      <xs:enumeration value=""A4"" />
      <xs:enumeration value=""AA"" />
      <xs:enumeration value=""AB"" />
      <xs:enumeration value=""AC"" />
      <xs:enumeration value=""AD"" />
      <xs:enumeration value=""AE"" />
      <xs:enumeration value=""AG"" />
      <xs:enumeration value=""AH"" />
      <xs:enumeration value=""AI"" />
      <xs:enumeration value=""AJ"" />
      <xs:enumeration value=""AL"" />
      <xs:enumeration value=""AM"" />
      <xs:enumeration value=""AP"" />
      <xs:enumeration value=""AQ"" />
      <xs:enumeration value=""AS"" />
      <xs:enumeration value=""AT"" />
      <xs:enumeration value=""AW"" />
      <xs:enumeration value=""AX"" />
      <xs:enumeration value=""AY"" />
      <xs:enumeration value=""BE"" />
      <xs:enumeration value=""BF"" />
      <xs:enumeration value=""BI"" />
      <xs:enumeration value=""CA"" />
      <xs:enumeration value=""CB"" />
      <xs:enumeration value=""CC"" />
      <xs:enumeration value=""CE"" />
      <xs:enumeration value=""CI"" />
      <xs:enumeration value=""CL"" />
      <xs:enumeration value=""CM"" />
      <xs:enumeration value=""CO"" />
      <xs:enumeration value=""CR"" />
      <xs:enumeration value=""CS"" />
      <xs:enumeration value=""CU"" />
      <xs:enumeration value=""CX"" />
      <xs:enumeration value=""DA"" />
      <xs:enumeration value=""DD"" />
      <xs:enumeration value=""DE"" />
      <xs:enumeration value=""DF"" />
      <xs:enumeration value=""DI"" />
      <xs:enumeration value=""DL"" />
      <xs:enumeration value=""DN"" />
      <xs:enumeration value=""DO"" />
      <xs:enumeration value=""DR"" />
      <xs:enumeration value=""DS"" />
      <xs:enumeration value=""DX"" />
      <xs:enumeration value=""DY"" />
      <xs:enumeration value=""DZ"" />
      <xs:enumeration value=""EI"" />
      <xs:enumeration value=""EP"" />
      <xs:enumeration value=""ES"" />
      <xs:enumeration value=""ET"" />
      <xs:enumeration value=""EU"" />
      <xs:enumeration value=""EX"" />
      <xs:enumeration value=""FA"" />
      <xs:enumeration value=""FC"" />
      <xs:enumeration value=""FD"" />
      <xs:enumeration value=""FG"" />
      <xs:enumeration value=""FH"" />
      <xs:enumeration value=""FI"" />
      <xs:enumeration value=""GC"" />
      <xs:enumeration value=""GS"" />
      <xs:enumeration value=""GU"" />
      <xs:enumeration value=""HC"" />
      <xs:enumeration value=""HI"" />
      <xs:enumeration value=""HS"" />
      <xs:enumeration value=""HU"" />
      <xs:enumeration value=""IA"" />
      <xs:enumeration value=""IB"" />
      <xs:enumeration value=""IC"" />
      <xs:enumeration value=""IM"" />
      <xs:enumeration value=""IN"" />
      <xs:enumeration value=""IS"" />
      <xs:enumeration value=""JA"" />
      <xs:enumeration value=""LA"" />
      <xs:enumeration value=""LB"" />
      <xs:enumeration value=""LI"" />
      <xs:enumeration value=""MA"" />
      <xs:enumeration value=""MB"" />
      <xs:enumeration value=""MC"" />
      <xs:enumeration value=""ME"" />
      <xs:enumeration value=""MI"" />
      <xs:enumeration value=""MP"" />
      <xs:enumeration value=""MS"" />
      <xs:enumeration value=""MV"" />
      <xs:enumeration value=""NA"" />
      <xs:enumeration value=""NB"" />
      <xs:enumeration value=""NC"" />
      <xs:enumeration value=""NE"" />
      <xs:enumeration value=""NF"" />
      <xs:enumeration value=""NG"" />
      <xs:enumeration value=""NI"" />
      <xs:enumeration value=""NR"" />
      <xs:enumeration value=""NS"" />
      <xs:enumeration value=""NT"" />
      <xs:enumeration value=""NU"" />
      <xs:enumeration value=""NW"" />
      <xs:enumeration value=""OI"" />
      <xs:enumeration value=""OP"" />
      <xs:enumeration value=""OS"" />
      <xs:enumeration value=""PA"" />
      <xs:enumeration value=""PC"" />
      <xs:enumeration value=""SA"" />
      <xs:enumeration value=""SE"" />
      <xs:enumeration value=""SL"" />
      <xs:enumeration value=""SP"" />
      <xs:enumeration value=""ST"" />
      <xs:enumeration value=""TA"" />
      <xs:enumeration value=""TB"" />
      <xs:enumeration value=""TC"" />
      <xs:enumeration value=""TD"" />
      <xs:enumeration value=""TI"" />
      <xs:enumeration value=""TM"" />
      <xs:enumeration value=""TP"" />
      <xs:enumeration value=""TR"" />
      <xs:enumeration value=""TX"" />
      <xs:enumeration value=""UC"" />
      <xs:enumeration value=""UN"" />
      <xs:enumeration value=""VI"" />
      <xs:enumeration value=""WH"" />
      <xs:enumeration value=""ZZ"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""X12_ID_1270"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""0"" />
      <xs:enumeration value=""1"" />
      <xs:enumeration value=""10"" />
      <xs:enumeration value=""100"" />
      <xs:enumeration value=""101"" />
      <xs:enumeration value=""102"" />
      <xs:enumeration value=""103"" />
      <xs:enumeration value=""104"" />
      <xs:enumeration value=""105"" />
      <xs:enumeration value=""106"" />
      <xs:enumeration value=""107"" />
      <xs:enumeration value=""108"" />
      <xs:enumeration value=""109"" />
      <xs:enumeration value=""11"" />
      <xs:enumeration value=""12"" />
      <xs:enumeration value=""13"" />
      <xs:enumeration value=""14"" />
      <xs:enumeration value=""16"" />
      <xs:enumeration value=""17"" />
      <xs:enumeration value=""19"" />
      <xs:enumeration value=""2"" />
      <xs:enumeration value=""20"" />
      <xs:enumeration value=""21"" />
      <xs:enumeration value=""22"" />
      <xs:enumeration value=""23"" />
      <xs:enumeration value=""24"" />
      <xs:enumeration value=""25"" />
      <xs:enumeration value=""26"" />
      <xs:enumeration value=""27"" />
      <xs:enumeration value=""28"" />
      <xs:enumeration value=""29"" />
      <xs:enumeration value=""3"" />
      <xs:enumeration value=""30"" />
      <xs:enumeration value=""32"" />
      <xs:enumeration value=""33"" />
      <xs:enumeration value=""34"" />
      <xs:enumeration value=""35"" />
      <xs:enumeration value=""36"" />
      <xs:enumeration value=""37"" />
      <xs:enumeration value=""38"" />
      <xs:enumeration value=""39"" />
      <xs:enumeration value=""4"" />
      <xs:enumeration value=""40"" />
      <xs:enumeration value=""41"" />
      <xs:enumeration value=""42"" />
      <xs:enumeration value=""43"" />
      <xs:enumeration value=""44"" />
      <xs:enumeration value=""45"" />
      <xs:enumeration value=""46"" />
      <xs:enumeration value=""47"" />
      <xs:enumeration value=""48"" />
      <xs:enumeration value=""49"" />
      <xs:enumeration value=""5"" />
      <xs:enumeration value=""52"" />
      <xs:enumeration value=""53"" />
      <xs:enumeration value=""54"" />
      <xs:enumeration value=""55"" />
      <xs:enumeration value=""56"" />
      <xs:enumeration value=""57"" />
      <xs:enumeration value=""58"" />
      <xs:enumeration value=""59"" />
      <xs:enumeration value=""6"" />
      <xs:enumeration value=""60"" />
      <xs:enumeration value=""61"" />
      <xs:enumeration value=""62"" />
      <xs:enumeration value=""63"" />
      <xs:enumeration value=""66"" />
      <xs:enumeration value=""67"" />
      <xs:enumeration value=""69"" />
      <xs:enumeration value=""7"" />
      <xs:enumeration value=""71"" />
      <xs:enumeration value=""74"" />
      <xs:enumeration value=""75"" />
      <xs:enumeration value=""78"" />
      <xs:enumeration value=""79"" />
      <xs:enumeration value=""8"" />
      <xs:enumeration value=""80"" />
      <xs:enumeration value=""81"" />
      <xs:enumeration value=""82"" />
      <xs:enumeration value=""83"" />
      <xs:enumeration value=""84"" />
      <xs:enumeration value=""85"" />
      <xs:enumeration value=""87"" />
      <xs:enumeration value=""88"" />
      <xs:enumeration value=""89"" />
      <xs:enumeration value=""9"" />
      <xs:enumeration value=""90"" />
      <xs:enumeration value=""91"" />
      <xs:enumeration value=""92"" />
      <xs:enumeration value=""93"" />
      <xs:enumeration value=""94"" />
      <xs:enumeration value=""95"" />
      <xs:enumeration value=""96"" />
      <xs:enumeration value=""97"" />
      <xs:enumeration value=""98"" />
      <xs:enumeration value=""99"" />
      <xs:enumeration value=""A"" />
      <xs:enumeration value=""A1"" />
      <xs:enumeration value=""A2"" />
      <xs:enumeration value=""A3"" />
      <xs:enumeration value=""A4"" />
      <xs:enumeration value=""A5"" />
      <xs:enumeration value=""A6"" />
      <xs:enumeration value=""A7"" />
      <xs:enumeration value=""A8"" />
      <xs:enumeration value=""A9"" />
      <xs:enumeration value=""AA"" />
      <xs:enumeration value=""AAA"" />
      <xs:enumeration value=""AB"" />
      <xs:enumeration value=""ABR"" />
      <xs:enumeration value=""ABS"" />
      <xs:enumeration value=""AC"" />
      <xs:enumeration value=""AD"" />
      <xs:enumeration value=""AE"" />
      <xs:enumeration value=""AF"" />
      <xs:enumeration value=""AG"" />
      <xs:enumeration value=""AH"" />
      <xs:enumeration value=""AI"" />
      <xs:enumeration value=""AJ"" />
      <xs:enumeration value=""AK"" />
      <xs:enumeration value=""AL"" />
      <xs:enumeration value=""ALP"" />
      <xs:enumeration value=""AM"" />
      <xs:enumeration value=""AN"" />
      <xs:enumeration value=""AO"" />
      <xs:enumeration value=""AP"" />
      <xs:enumeration value=""APE"" />
      <xs:enumeration value=""AQ"" />
      <xs:enumeration value=""AR"" />
      <xs:enumeration value=""AS"" />
      <xs:enumeration value=""AT"" />
      <xs:enumeration value=""AU"" />
      <xs:enumeration value=""AW"" />
      <xs:enumeration value=""AX"" />
      <xs:enumeration value=""B"" />
      <xs:enumeration value=""BA"" />
      <xs:enumeration value=""BB"" />
      <xs:enumeration value=""BC"" />
      <xs:enumeration value=""BCC"" />
      <xs:enumeration value=""BCR"" />
      <xs:enumeration value=""BD"" />
      <xs:enumeration value=""BE"" />
      <xs:enumeration value=""BF"" />
      <xs:enumeration value=""BG"" />
      <xs:enumeration value=""BH"" />
      <xs:enumeration value=""BI"" />
      <xs:enumeration value=""BJ"" />
      <xs:enumeration value=""BK"" />
      <xs:enumeration value=""BL"" />
      <xs:enumeration value=""BM"" />
      <xs:enumeration value=""BN"" />
      <xs:enumeration value=""BO"" />
      <xs:enumeration value=""BP"" />
      <xs:enumeration value=""BPL"" />
      <xs:enumeration value=""BQ"" />
      <xs:enumeration value=""BR"" />
      <xs:enumeration value=""BRL"" />
      <xs:enumeration value=""BS"" />
      <xs:enumeration value=""BSL"" />
      <xs:enumeration value=""BU"" />
      <xs:enumeration value=""BV"" />
      <xs:enumeration value=""BY"" />
      <xs:enumeration value=""BZ"" />
      <xs:enumeration value=""C"" />
      <xs:enumeration value=""C1"" />
      <xs:enumeration value=""C2"" />
      <xs:enumeration value=""C3"" />
      <xs:enumeration value=""CA"" />
      <xs:enumeration value=""CB"" />
      <xs:enumeration value=""CC"" />
      <xs:enumeration value=""CD"" />
      <xs:enumeration value=""CE"" />
      <xs:enumeration value=""CF"" />
      <xs:enumeration value=""CG"" />
      <xs:enumeration value=""CH"" />
      <xs:enumeration value=""CI"" />
      <xs:enumeration value=""CJ"" />
      <xs:enumeration value=""CK"" />
      <xs:enumeration value=""CL"" />
      <xs:enumeration value=""CLP"" />
      <xs:enumeration value=""CM"" />
      <xs:enumeration value=""CML"" />
      <xs:enumeration value=""CN"" />
      <xs:enumeration value=""CO"" />
      <xs:enumeration value=""COG"" />
      <xs:enumeration value=""CPS"" />
      <xs:enumeration value=""CRC"" />
      <xs:enumeration value=""CS"" />
      <xs:enumeration value=""CSF"" />
      <xs:enumeration value=""CT"" />
      <xs:enumeration value=""CU"" />
      <xs:enumeration value=""CV"" />
      <xs:enumeration value=""CW"" />
      <xs:enumeration value=""CZ"" />
      <xs:enumeration value=""D"" />
      <xs:enumeration value=""D1"" />
      <xs:enumeration value=""D2"" />
      <xs:enumeration value=""D3"" />
      <xs:enumeration value=""D4"" />
      <xs:enumeration value=""D5"" />
      <xs:enumeration value=""DA"" />
      <xs:enumeration value=""DB"" />
      <xs:enumeration value=""DBS"" />
      <xs:enumeration value=""DC"" />
      <xs:enumeration value=""DD"" />
      <xs:enumeration value=""DE"" />
      <xs:enumeration value=""DF"" />
      <xs:enumeration value=""DG"" />
      <xs:enumeration value=""DGO"" />
      <xs:enumeration value=""DH"" />
      <xs:enumeration value=""DI"" />
      <xs:enumeration value=""DJ"" />
      <xs:enumeration value=""DK"" />
      <xs:enumeration value=""DL"" />
      <xs:enumeration value=""DLO"" />
      <xs:enumeration value=""DLP"" />
      <xs:enumeration value=""DM"" />
      <xs:enumeration value=""DN"" />
      <xs:enumeration value=""DO"" />
      <xs:enumeration value=""DPE"" />
      <xs:enumeration value=""DPL"" />
      <xs:enumeration value=""DQ"" />
      <xs:enumeration value=""DR"" />
      <xs:enumeration value=""DS"" />
      <xs:enumeration value=""DT"" />
      <xs:enumeration value=""DU"" />
      <xs:enumeration value=""DW"" />
      <xs:enumeration value=""DX"" />
      <xs:enumeration value=""DY"" />
      <xs:enumeration value=""DZ"" />
      <xs:enumeration value=""E"" />
      <xs:enumeration value=""EA"" />
      <xs:enumeration value=""EB"" />
      <xs:enumeration value=""EC"" />
      <xs:enumeration value=""ED"" />
      <xs:enumeration value=""EE"" />
      <xs:enumeration value=""EF"" />
      <xs:enumeration value=""EG"" />
      <xs:enumeration value=""EH"" />
      <xs:enumeration value=""EI"" />
      <xs:enumeration value=""EJ"" />
      <xs:enumeration value=""EK"" />
      <xs:enumeration value=""EL"" />
      <xs:enumeration value=""EM"" />
      <xs:enumeration value=""EN"" />
      <xs:enumeration value=""EO"" />
      <xs:enumeration value=""EQ"" />
      <xs:enumeration value=""ER"" />
      <xs:enumeration value=""ES"" />
      <xs:enumeration value=""ESL"" />
      <xs:enumeration value=""ET"" />
      <xs:enumeration value=""ETL"" />
      <xs:enumeration value=""EU"" />
      <xs:enumeration value=""EV"" />
      <xs:enumeration value=""EW"" />
      <xs:enumeration value=""EWC"" />
      <xs:enumeration value=""EWR"" />
      <xs:enumeration value=""EX"" />
      <xs:enumeration value=""EY"" />
      <xs:enumeration value=""EZ"" />
      <xs:enumeration value=""F"" />
      <xs:enumeration value=""FA"" />
      <xs:enumeration value=""FB"" />
      <xs:enumeration value=""FC"" />
      <xs:enumeration value=""FD"" />
      <xs:enumeration value=""FE"" />
      <xs:enumeration value=""FF"" />
      <xs:enumeration value=""FG"" />
      <xs:enumeration value=""FH"" />
      <xs:enumeration value=""FI"" />
      <xs:enumeration value=""FJ"" />
      <xs:enumeration value=""FK"" />
      <xs:enumeration value=""FL"" />
      <xs:enumeration value=""FM"" />
      <xs:enumeration value=""FN"" />
      <xs:enumeration value=""FO"" />
      <xs:enumeration value=""FP"" />
      <xs:enumeration value=""FQ"" />
      <xs:enumeration value=""FR"" />
      <xs:enumeration value=""FS"" />
      <xs:enumeration value=""FT"" />
      <xs:enumeration value=""FU"" />
      <xs:enumeration value=""FV"" />
      <xs:enumeration value=""FW"" />
      <xs:enumeration value=""FX"" />
      <xs:enumeration value=""FZ"" />
      <xs:enumeration value=""G"" />
      <xs:enumeration value=""G1"" />
      <xs:enumeration value=""GA"" />
      <xs:enumeration value=""GB"" />
      <xs:enumeration value=""GC"" />
      <xs:enumeration value=""GD"" />
      <xs:enumeration value=""GE"" />
      <xs:enumeration value=""GF"" />
      <xs:enumeration value=""GG"" />
      <xs:enumeration value=""GI"" />
      <xs:enumeration value=""GJ"" />
      <xs:enumeration value=""GK"" />
      <xs:enumeration value=""GQ"" />
      <xs:enumeration value=""GR"" />
      <xs:enumeration value=""GS"" />
      <xs:enumeration value=""GT"" />
      <xs:enumeration value=""GU"" />
      <xs:enumeration value=""GV"" />
      <xs:enumeration value=""GW"" />
      <xs:enumeration value=""H"" />
      <xs:enumeration value=""HA"" />
      <xs:enumeration value=""HB"" />
      <xs:enumeration value=""HD"" />
      <xs:enumeration value=""HE"" />
      <xs:enumeration value=""HI"" />
      <xs:enumeration value=""HRC"" />
      <xs:enumeration value=""HS"" />
      <xs:enumeration value=""HZR"" />
      <xs:enumeration value=""I"" />
      <xs:enumeration value=""IC"" />
      <xs:enumeration value=""ID"" />
      <xs:enumeration value=""IF"" />
      <xs:enumeration value=""IMC"" />
      <xs:enumeration value=""IMP"" />
      <xs:enumeration value=""IPA"" />
      <xs:enumeration value=""IQ"" />
      <xs:enumeration value=""IT"" />
      <xs:enumeration value=""J"" />
      <xs:enumeration value=""J0"" />
      <xs:enumeration value=""J1"" />
      <xs:enumeration value=""J2"" />
      <xs:enumeration value=""J3"" />
      <xs:enumeration value=""J4"" />
      <xs:enumeration value=""J5"" />
      <xs:enumeration value=""J6"" />
      <xs:enumeration value=""J7"" />
      <xs:enumeration value=""J8"" />
      <xs:enumeration value=""J9"" />
      <xs:enumeration value=""JA"" />
      <xs:enumeration value=""JB"" />
      <xs:enumeration value=""JC"" />
      <xs:enumeration value=""JCL"" />
      <xs:enumeration value=""JD"" />
      <xs:enumeration value=""JE"" />
      <xs:enumeration value=""JF"" />
      <xs:enumeration value=""JG"" />
      <xs:enumeration value=""JH"" />
      <xs:enumeration value=""JI"" />
      <xs:enumeration value=""JK"" />
      <xs:enumeration value=""JL"" />
      <xs:enumeration value=""JM"" />
      <xs:enumeration value=""JN"" />
      <xs:enumeration value=""JO"" />
      <xs:enumeration value=""JOL"" />
      <xs:enumeration value=""JP"" />
      <xs:enumeration value=""K"" />
      <xs:enumeration value=""KA"" />
      <xs:enumeration value=""KB"" />
      <xs:enumeration value=""KC"" />
      <xs:enumeration value=""KD"" />
      <xs:enumeration value=""KE"" />
      <xs:enumeration value=""KF"" />
      <xs:enumeration value=""KG"" />
      <xs:enumeration value=""KH"" />
      <xs:enumeration value=""KI"" />
      <xs:enumeration value=""KJ"" />
      <xs:enumeration value=""KK"" />
      <xs:enumeration value=""KL"" />
      <xs:enumeration value=""KM"" />
      <xs:enumeration value=""KO"" />
      <xs:enumeration value=""KP"" />
      <xs:enumeration value=""KQ"" />
      <xs:enumeration value=""KS"" />
      <xs:enumeration value=""KT"" />
      <xs:enumeration value=""KU"" />
      <xs:enumeration value=""KW"" />
      <xs:enumeration value=""KYL"" />
      <xs:enumeration value=""KZ"" />
      <xs:enumeration value=""L"" />
      <xs:enumeration value=""LA"" />
      <xs:enumeration value=""LB"" />
      <xs:enumeration value=""LC"" />
      <xs:enumeration value=""LD"" />
      <xs:enumeration value=""LE"" />
      <xs:enumeration value=""LF"" />
      <xs:enumeration value=""LG"" />
      <xs:enumeration value=""LH"" />
      <xs:enumeration value=""LIN"" />
      <xs:enumeration value=""LJ"" />
      <xs:enumeration value=""LK"" />
      <xs:enumeration value=""LM"" />
      <xs:enumeration value=""LN"" />
      <xs:enumeration value=""LO"" />
      <xs:enumeration value=""LOI"" />
      <xs:enumeration value=""LP"" />
      <xs:enumeration value=""LQ"" />
      <xs:enumeration value=""LR"" />
      <xs:enumeration value=""LS"" />
      <xs:enumeration value=""LSC"" />
      <xs:enumeration value=""LT"" />
      <xs:enumeration value=""LZ"" />
      <xs:enumeration value=""M"" />
      <xs:enumeration value=""MB"" />
      <xs:enumeration value=""MC"" />
      <xs:enumeration value=""MCC"" />
      <xs:enumeration value=""MCD"" />
      <xs:enumeration value=""ME"" />
      <xs:enumeration value=""MI"" />
      <xs:enumeration value=""MJ"" />
      <xs:enumeration value=""MK"" />
      <xs:enumeration value=""ML"" />
      <xs:enumeration value=""MN"" />
      <xs:enumeration value=""MOC"" />
      <xs:enumeration value=""N"" />
      <xs:enumeration value=""NA"" />
      <xs:enumeration value=""NAC"" />
      <xs:enumeration value=""NAF"" />
      <xs:enumeration value=""NAS"" />
      <xs:enumeration value=""NB"" />
      <xs:enumeration value=""NC"" />
      <xs:enumeration value=""ND"" />
      <xs:enumeration value=""NDC"" />
      <xs:enumeration value=""NE"" />
      <xs:enumeration value=""NF"" />
      <xs:enumeration value=""NH"" />
      <xs:enumeration value=""NI"" />
      <xs:enumeration value=""NJ"" />
      <xs:enumeration value=""NK"" />
      <xs:enumeration value=""NL"" />
      <xs:enumeration value=""NP"" />
      <xs:enumeration value=""NR"" />
      <xs:enumeration value=""NS"" />
      <xs:enumeration value=""NT"" />
      <xs:enumeration value=""O"" />
      <xs:enumeration value=""O1"" />
      <xs:enumeration value=""O2"" />
      <xs:enumeration value=""O3"" />
      <xs:enumeration value=""O4"" />
      <xs:enumeration value=""OC"" />
      <xs:enumeration value=""P"" />
      <xs:enumeration value=""PB"" />
      <xs:enumeration value=""PC"" />
      <xs:enumeration value=""PD"" />
      <xs:enumeration value=""PGS"" />
      <xs:enumeration value=""PI"" />
      <xs:enumeration value=""PIT"" />
      <xs:enumeration value=""PL"" />
      <xs:enumeration value=""PLC"" />
      <xs:enumeration value=""PLS"" />
      <xs:enumeration value=""PPD"" />
      <xs:enumeration value=""PPP"" />
      <xs:enumeration value=""PPS"" />
      <xs:enumeration value=""PPV"" />
      <xs:enumeration value=""PRA"" />
      <xs:enumeration value=""PRC"" />
      <xs:enumeration value=""PRR"" />
      <xs:enumeration value=""PRT"" />
      <xs:enumeration value=""PS"" />
      <xs:enumeration value=""PWA"" />
      <xs:enumeration value=""PWI"" />
      <xs:enumeration value=""PWR"" />
      <xs:enumeration value=""PWS"" />
      <xs:enumeration value=""PWT"" />
      <xs:enumeration value=""Q"" />
      <xs:enumeration value=""QA"" />
      <xs:enumeration value=""QB"" />
      <xs:enumeration value=""QC"" />
      <xs:enumeration value=""QE"" />
      <xs:enumeration value=""QF"" />
      <xs:enumeration value=""QG"" />
      <xs:enumeration value=""QH"" />
      <xs:enumeration value=""QI"" />
      <xs:enumeration value=""QJ"" />
      <xs:enumeration value=""QK"" />
      <xs:enumeration value=""QS"" />
      <xs:enumeration value=""R"" />
      <xs:enumeration value=""RA"" />
      <xs:enumeration value=""RC"" />
      <xs:enumeration value=""RCA"" />
      <xs:enumeration value=""RD"" />
      <xs:enumeration value=""RE"" />
      <xs:enumeration value=""REN"" />
      <xs:enumeration value=""RF"" />
      <xs:enumeration value=""RI"" />
      <xs:enumeration value=""RQ"" />
      <xs:enumeration value=""RR"" />
      <xs:enumeration value=""RT"" />
      <xs:enumeration value=""RTC"" />
      <xs:enumeration value=""RUM"" />
      <xs:enumeration value=""RX"" />
      <xs:enumeration value=""S"" />
      <xs:enumeration value=""SA"" />
      <xs:enumeration value=""SB"" />
      <xs:enumeration value=""SBA"" />
      <xs:enumeration value=""SC"" />
      <xs:enumeration value=""SD"" />
      <xs:enumeration value=""SE"" />
      <xs:enumeration value=""SEC"" />
      <xs:enumeration value=""SF"" />
      <xs:enumeration value=""SG"" />
      <xs:enumeration value=""SH"" />
      <xs:enumeration value=""SHL"" />
      <xs:enumeration value=""SI"" />
      <xs:enumeration value=""SJ"" />
      <xs:enumeration value=""SL"" />
      <xs:enumeration value=""SM"" />
      <xs:enumeration value=""SMI"" />
      <xs:enumeration value=""SO"" />
      <xs:enumeration value=""SP"" />
      <xs:enumeration value=""SPE"" />
      <xs:enumeration value=""SR"" />
      <xs:enumeration value=""SRL"" />
      <xs:enumeration value=""SS"" />
      <xs:enumeration value=""ST"" />
      <xs:enumeration value=""STC"" />
      <xs:enumeration value=""T"" />
      <xs:enumeration value=""T00"" />
      <xs:enumeration value=""T01"" />
      <xs:enumeration value=""T02"" />
      <xs:enumeration value=""T03"" />
      <xs:enumeration value=""T04"" />
      <xs:enumeration value=""T05"" />
      <xs:enumeration value=""T06"" />
      <xs:enumeration value=""T07"" />
      <xs:enumeration value=""T08"" />
      <xs:enumeration value=""T09"" />
      <xs:enumeration value=""T10"" />
      <xs:enumeration value=""T11"" />
      <xs:enumeration value=""T12"" />
      <xs:enumeration value=""T13"" />
      <xs:enumeration value=""T14"" />
      <xs:enumeration value=""T15"" />
      <xs:enumeration value=""T16"" />
      <xs:enumeration value=""T17"" />
      <xs:enumeration value=""T18"" />
      <xs:enumeration value=""T19"" />
      <xs:enumeration value=""T20"" />
      <xs:enumeration value=""T21"" />
      <xs:enumeration value=""TB"" />
      <xs:enumeration value=""TC"" />
      <xs:enumeration value=""TCL"" />
      <xs:enumeration value=""TD"" />
      <xs:enumeration value=""TE"" />
      <xs:enumeration value=""TF"" />
      <xs:enumeration value=""TG"" />
      <xs:enumeration value=""TOL"" />
      <xs:enumeration value=""TR"" />
      <xs:enumeration value=""TTL"" />
      <xs:enumeration value=""TX"" />
      <xs:enumeration value=""TY"" />
      <xs:enumeration value=""U"" />
      <xs:enumeration value=""UP"" />
      <xs:enumeration value=""UR"" />
      <xs:enumeration value=""US"" />
      <xs:enumeration value=""UU"" />
      <xs:enumeration value=""V"" />
      <xs:enumeration value=""W"" />
      <xs:enumeration value=""WDL"" />
      <xs:enumeration value=""X"" />
      <xs:enumeration value=""Y"" />
      <xs:enumeration value=""Z"" />
      <xs:enumeration value=""ZZ"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""X12_ID_88"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""AA"" />
      <xs:enumeration value=""AI"" />
      <xs:enumeration value=""CA"" />
      <xs:enumeration value=""CP"" />
      <xs:enumeration value=""DZ"" />
      <xs:enumeration value=""GM"" />
      <xs:enumeration value=""L"" />
      <xs:enumeration value=""MC"" />
      <xs:enumeration value=""PB"" />
      <xs:enumeration value=""R"" />
      <xs:enumeration value=""S"" />
      <xs:enumeration value=""SI"" />
      <xs:enumeration value=""SM"" />
      <xs:enumeration value=""SR"" />
      <xs:enumeration value=""SS"" />
      <xs:enumeration value=""UC"" />
      <xs:enumeration value=""UP"" />
      <xs:enumeration value=""W"" />
      <xs:enumeration value=""X"" />
      <xs:enumeration value=""ZZ"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""X12_ID_883"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""1"" />
      <xs:enumeration value=""2"" />
      <xs:enumeration value=""3"" />
      <xs:enumeration value=""4"" />
      <xs:enumeration value=""5"" />
      <xs:enumeration value=""6"" />
      <xs:enumeration value=""7"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""X12_ID_235"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""A1"" />
      <xs:enumeration value=""A2"" />
      <xs:enumeration value=""A3"" />
      <xs:enumeration value=""A4"" />
      <xs:enumeration value=""A5"" />
      <xs:enumeration value=""A6"" />
      <xs:enumeration value=""A7"" />
      <xs:enumeration value=""A8"" />
      <xs:enumeration value=""A9"" />
      <xs:enumeration value=""AA"" />
      <xs:enumeration value=""AB"" />
      <xs:enumeration value=""AC"" />
      <xs:enumeration value=""AD"" />
      <xs:enumeration value=""AE"" />
      <xs:enumeration value=""AF"" />
      <xs:enumeration value=""AG"" />
      <xs:enumeration value=""AH"" />
      <xs:enumeration value=""AI"" />
      <xs:enumeration value=""AJ"" />
      <xs:enumeration value=""AK"" />
      <xs:enumeration value=""AL"" />
      <xs:enumeration value=""AM"" />
      <xs:enumeration value=""AN"" />
      <xs:enumeration value=""AO"" />
      <xs:enumeration value=""AP"" />
      <xs:enumeration value=""AQ"" />
      <xs:enumeration value=""AR"" />
      <xs:enumeration value=""AS"" />
      <xs:enumeration value=""AT"" />
      <xs:enumeration value=""AU"" />
      <xs:enumeration value=""AV"" />
      <xs:enumeration value=""AW"" />
      <xs:enumeration value=""AX"" />
      <xs:enumeration value=""AY"" />
      <xs:enumeration value=""AZ"" />
      <xs:enumeration value=""B1"" />
      <xs:enumeration value=""B2"" />
      <xs:enumeration value=""B3"" />
      <xs:enumeration value=""B4"" />
      <xs:enumeration value=""B5"" />
      <xs:enumeration value=""B6"" />
      <xs:enumeration value=""B7"" />
      <xs:enumeration value=""B8"" />
      <xs:enumeration value=""B9"" />
      <xs:enumeration value=""BA"" />
      <xs:enumeration value=""BB"" />
      <xs:enumeration value=""BC"" />
      <xs:enumeration value=""BD"" />
      <xs:enumeration value=""BE"" />
      <xs:enumeration value=""BF"" />
      <xs:enumeration value=""BG"" />
      <xs:enumeration value=""BH"" />
      <xs:enumeration value=""BI"" />
      <xs:enumeration value=""BJ"" />
      <xs:enumeration value=""BK"" />
      <xs:enumeration value=""BL"" />
      <xs:enumeration value=""BM"" />
      <xs:enumeration value=""BN"" />
      <xs:enumeration value=""BO"" />
      <xs:enumeration value=""BP"" />
      <xs:enumeration value=""BQ"" />
      <xs:enumeration value=""BR"" />
      <xs:enumeration value=""BS"" />
      <xs:enumeration value=""BT"" />
      <xs:enumeration value=""BU"" />
      <xs:enumeration value=""BV"" />
      <xs:enumeration value=""BW"" />
      <xs:enumeration value=""BX"" />
      <xs:enumeration value=""BY"" />
      <xs:enumeration value=""BZ"" />
      <xs:enumeration value=""C1"" />
      <xs:enumeration value=""C2"" />
      <xs:enumeration value=""C3"" />
      <xs:enumeration value=""C4"" />
      <xs:enumeration value=""C5"" />
      <xs:enumeration value=""C6"" />
      <xs:enumeration value=""C7"" />
      <xs:enumeration value=""C8"" />
      <xs:enumeration value=""C9"" />
      <xs:enumeration value=""CA"" />
      <xs:enumeration value=""CB"" />
      <xs:enumeration value=""CC"" />
      <xs:enumeration value=""CD"" />
      <xs:enumeration value=""CE"" />
      <xs:enumeration value=""CF"" />
      <xs:enumeration value=""CG"" />
      <xs:enumeration value=""CH"" />
      <xs:enumeration value=""CI"" />
      <xs:enumeration value=""CJ"" />
      <xs:enumeration value=""CK"" />
      <xs:enumeration value=""CL"" />
      <xs:enumeration value=""CM"" />
      <xs:enumeration value=""CN"" />
      <xs:enumeration value=""CO"" />
      <xs:enumeration value=""CP"" />
      <xs:enumeration value=""CQ"" />
      <xs:enumeration value=""CR"" />
      <xs:enumeration value=""CS"" />
      <xs:enumeration value=""CT"" />
      <xs:enumeration value=""CU"" />
      <xs:enumeration value=""CV"" />
      <xs:enumeration value=""CW"" />
      <xs:enumeration value=""CX"" />
      <xs:enumeration value=""CY"" />
      <xs:enumeration value=""CZ"" />
      <xs:enumeration value=""D1"" />
      <xs:enumeration value=""D2"" />
      <xs:enumeration value=""D3"" />
      <xs:enumeration value=""D4"" />
      <xs:enumeration value=""D5"" />
      <xs:enumeration value=""DD"" />
      <xs:enumeration value=""DE"" />
      <xs:enumeration value=""DF"" />
      <xs:enumeration value=""DG"" />
      <xs:enumeration value=""DI"" />
      <xs:enumeration value=""DL"" />
      <xs:enumeration value=""DM"" />
      <xs:enumeration value=""DN"" />
      <xs:enumeration value=""DO"" />
      <xs:enumeration value=""DP"" />
      <xs:enumeration value=""DQ"" />
      <xs:enumeration value=""DR"" />
      <xs:enumeration value=""DS"" />
      <xs:enumeration value=""DT"" />
      <xs:enumeration value=""DU"" />
      <xs:enumeration value=""DV"" />
      <xs:enumeration value=""DW"" />
      <xs:enumeration value=""DX"" />
      <xs:enumeration value=""DY"" />
      <xs:enumeration value=""DZ"" />
      <xs:enumeration value=""E1"" />
      <xs:enumeration value=""E2"" />
      <xs:enumeration value=""E3"" />
      <xs:enumeration value=""E4"" />
      <xs:enumeration value=""E5"" />
      <xs:enumeration value=""E6"" />
      <xs:enumeration value=""EA"" />
      <xs:enumeration value=""EB"" />
      <xs:enumeration value=""EC"" />
      <xs:enumeration value=""ED"" />
      <xs:enumeration value=""EE"" />
      <xs:enumeration value=""EF"" />
      <xs:enumeration value=""EG"" />
      <xs:enumeration value=""EH"" />
      <xs:enumeration value=""EI"" />
      <xs:enumeration value=""EJ"" />
      <xs:enumeration value=""EK"" />
      <xs:enumeration value=""EL"" />
      <xs:enumeration value=""EM"" />
      <xs:enumeration value=""EN"" />
      <xs:enumeration value=""EP"" />
      <xs:enumeration value=""EQ"" />
      <xs:enumeration value=""ER"" />
      <xs:enumeration value=""ES"" />
      <xs:enumeration value=""EU"" />
      <xs:enumeration value=""EX"" />
      <xs:enumeration value=""EZ"" />
      <xs:enumeration value=""F1"" />
      <xs:enumeration value=""F2"" />
      <xs:enumeration value=""F3"" />
      <xs:enumeration value=""F4"" />
      <xs:enumeration value=""F5"" />
      <xs:enumeration value=""F6"" />
      <xs:enumeration value=""F7"" />
      <xs:enumeration value=""F8"" />
      <xs:enumeration value=""F9"" />
      <xs:enumeration value=""FA"" />
      <xs:enumeration value=""FB"" />
      <xs:enumeration value=""FC"" />
      <xs:enumeration value=""FD"" />
      <xs:enumeration value=""FE"" />
      <xs:enumeration value=""FF"" />
      <xs:enumeration value=""FG"" />
      <xs:enumeration value=""FI"" />
      <xs:enumeration value=""FL"" />
      <xs:enumeration value=""FM"" />
      <xs:enumeration value=""FN"" />
      <xs:enumeration value=""FP"" />
      <xs:enumeration value=""FS"" />
      <xs:enumeration value=""FT"" />
      <xs:enumeration value=""FW"" />
      <xs:enumeration value=""GA"" />
      <xs:enumeration value=""GC"" />
      <xs:enumeration value=""GD"" />
      <xs:enumeration value=""GE"" />
      <xs:enumeration value=""GI"" />
      <xs:enumeration value=""GK"" />
      <xs:enumeration value=""GN"" />
      <xs:enumeration value=""GQ"" />
      <xs:enumeration value=""GR"" />
      <xs:enumeration value=""GS"" />
      <xs:enumeration value=""GU"" />
      <xs:enumeration value=""HC"" />
      <xs:enumeration value=""HD"" />
      <xs:enumeration value=""HI"" />
      <xs:enumeration value=""HN"" />
      <xs:enumeration value=""IA"" />
      <xs:enumeration value=""IB"" />
      <xs:enumeration value=""IC"" />
      <xs:enumeration value=""ID"" />
      <xs:enumeration value=""IE"" />
      <xs:enumeration value=""IF"" />
      <xs:enumeration value=""IG"" />
      <xs:enumeration value=""IM"" />
      <xs:enumeration value=""IN"" />
      <xs:enumeration value=""IP"" />
      <xs:enumeration value=""IQ"" />
      <xs:enumeration value=""IR"" />
      <xs:enumeration value=""IS"" />
      <xs:enumeration value=""IT"" />
      <xs:enumeration value=""IV"" />
      <xs:enumeration value=""IW"" />
      <xs:enumeration value=""IZ"" />
      <xs:enumeration value=""JA"" />
      <xs:enumeration value=""JB"" />
      <xs:enumeration value=""JC"" />
      <xs:enumeration value=""JD"" />
      <xs:enumeration value=""JN"" />
      <xs:enumeration value=""JP"" />
      <xs:enumeration value=""JS"" />
      <xs:enumeration value=""KA"" />
      <xs:enumeration value=""KB"" />
      <xs:enumeration value=""KD"" />
      <xs:enumeration value=""KE"" />
      <xs:enumeration value=""KF"" />
      <xs:enumeration value=""KG"" />
      <xs:enumeration value=""KI"" />
      <xs:enumeration value=""KJ"" />
      <xs:enumeration value=""KK"" />
      <xs:enumeration value=""KL"" />
      <xs:enumeration value=""KM"" />
      <xs:enumeration value=""KN"" />
      <xs:enumeration value=""KP"" />
      <xs:enumeration value=""L1"" />
      <xs:enumeration value=""L2"" />
      <xs:enumeration value=""L3"" />
      <xs:enumeration value=""L4"" />
      <xs:enumeration value=""L5"" />
      <xs:enumeration value=""LA"" />
      <xs:enumeration value=""LB"" />
      <xs:enumeration value=""LC"" />
      <xs:enumeration value=""LD"" />
      <xs:enumeration value=""LG"" />
      <xs:enumeration value=""LP"" />
      <xs:enumeration value=""LR"" />
      <xs:enumeration value=""LS"" />
      <xs:enumeration value=""LT"" />
      <xs:enumeration value=""LU"" />
      <xs:enumeration value=""MA"" />
      <xs:enumeration value=""MB"" />
      <xs:enumeration value=""MC"" />
      <xs:enumeration value=""MD"" />
      <xs:enumeration value=""ME"" />
      <xs:enumeration value=""MF"" />
      <xs:enumeration value=""MG"" />
      <xs:enumeration value=""MH"" />
      <xs:enumeration value=""MI"" />
      <xs:enumeration value=""MJ"" />
      <xs:enumeration value=""MK"" />
      <xs:enumeration value=""MM"" />
      <xs:enumeration value=""MN"" />
      <xs:enumeration value=""MO"" />
      <xs:enumeration value=""MP"" />
      <xs:enumeration value=""MQ"" />
      <xs:enumeration value=""MR"" />
      <xs:enumeration value=""MS"" />
      <xs:enumeration value=""MT"" />
      <xs:enumeration value=""MU"" />
      <xs:enumeration value=""MV"" />
      <xs:enumeration value=""MW"" />
      <xs:enumeration value=""MX"" />
      <xs:enumeration value=""N1"" />
      <xs:enumeration value=""N2"" />
      <xs:enumeration value=""N3"" />
      <xs:enumeration value=""N4"" />
      <xs:enumeration value=""N5"" />
      <xs:enumeration value=""N6"" />
      <xs:enumeration value=""NC"" />
      <xs:enumeration value=""ND"" />
      <xs:enumeration value=""NE"" />
      <xs:enumeration value=""NH"" />
      <xs:enumeration value=""NM"" />
      <xs:enumeration value=""NR"" />
      <xs:enumeration value=""NU"" />
      <xs:enumeration value=""NW"" />
      <xs:enumeration value=""NZ"" />
      <xs:enumeration value=""OA"" />
      <xs:enumeration value=""OB"" />
      <xs:enumeration value=""OC"" />
      <xs:enumeration value=""OD"" />
      <xs:enumeration value=""OE"" />
      <xs:enumeration value=""OF"" />
      <xs:enumeration value=""OG"" />
      <xs:enumeration value=""OH"" />
      <xs:enumeration value=""OI"" />
      <xs:enumeration value=""OL"" />
      <xs:enumeration value=""ON"" />
      <xs:enumeration value=""OO"" />
      <xs:enumeration value=""OP"" />
      <xs:enumeration value=""OR"" />
      <xs:enumeration value=""OT"" />
      <xs:enumeration value=""P1"" />
      <xs:enumeration value=""P2"" />
      <xs:enumeration value=""P3"" />
      <xs:enumeration value=""P4"" />
      <xs:enumeration value=""P5"" />
      <xs:enumeration value=""P7"" />
      <xs:enumeration value=""P8"" />
      <xs:enumeration value=""P9"" />
      <xs:enumeration value=""PA"" />
      <xs:enumeration value=""PB"" />
      <xs:enumeration value=""PC"" />
      <xs:enumeration value=""PD"" />
      <xs:enumeration value=""PE"" />
      <xs:enumeration value=""PF"" />
      <xs:enumeration value=""PG"" />
      <xs:enumeration value=""PH"" />
      <xs:enumeration value=""PI"" />
      <xs:enumeration value=""PJ"" />
      <xs:enumeration value=""PK"" />
      <xs:enumeration value=""PL"" />
      <xs:enumeration value=""PM"" />
      <xs:enumeration value=""PN"" />
      <xs:enumeration value=""PO"" />
      <xs:enumeration value=""PP"" />
      <xs:enumeration value=""PQ"" />
      <xs:enumeration value=""PR"" />
      <xs:enumeration value=""PS"" />
      <xs:enumeration value=""PT"" />
      <xs:enumeration value=""PU"" />
      <xs:enumeration value=""PV"" />
      <xs:enumeration value=""PW"" />
      <xs:enumeration value=""PX"" />
      <xs:enumeration value=""PY"" />
      <xs:enumeration value=""PZ"" />
      <xs:enumeration value=""R1"" />
      <xs:enumeration value=""R2"" />
      <xs:enumeration value=""RA"" />
      <xs:enumeration value=""RB"" />
      <xs:enumeration value=""RC"" />
      <xs:enumeration value=""RD"" />
      <xs:enumeration value=""RE"" />
      <xs:enumeration value=""RF"" />
      <xs:enumeration value=""RG"" />
      <xs:enumeration value=""RH"" />
      <xs:enumeration value=""RI"" />
      <xs:enumeration value=""RJ"" />
      <xs:enumeration value=""RK"" />
      <xs:enumeration value=""RL"" />
      <xs:enumeration value=""RM"" />
      <xs:enumeration value=""RN"" />
      <xs:enumeration value=""RO"" />
      <xs:enumeration value=""RP"" />
      <xs:enumeration value=""RR"" />
      <xs:enumeration value=""RS"" />
      <xs:enumeration value=""RT"" />
      <xs:enumeration value=""RU"" />
      <xs:enumeration value=""RV"" />
      <xs:enumeration value=""RW"" />
      <xs:enumeration value=""RY"" />
      <xs:enumeration value=""RZ"" />
      <xs:enumeration value=""S2"" />
      <xs:enumeration value=""S3"" />
      <xs:enumeration value=""S4"" />
      <xs:enumeration value=""S5"" />
      <xs:enumeration value=""S6"" />
      <xs:enumeration value=""S7"" />
      <xs:enumeration value=""S8"" />
      <xs:enumeration value=""SA"" />
      <xs:enumeration value=""SB"" />
      <xs:enumeration value=""SC"" />
      <xs:enumeration value=""SD"" />
      <xs:enumeration value=""SE"" />
      <xs:enumeration value=""SF"" />
      <xs:enumeration value=""SG"" />
      <xs:enumeration value=""SH"" />
      <xs:enumeration value=""SI"" />
      <xs:enumeration value=""SJ"" />
      <xs:enumeration value=""SK"" />
      <xs:enumeration value=""SL"" />
      <xs:enumeration value=""SM"" />
      <xs:enumeration value=""SN"" />
      <xs:enumeration value=""SO"" />
      <xs:enumeration value=""SP"" />
      <xs:enumeration value=""SQ"" />
      <xs:enumeration value=""SR"" />
      <xs:enumeration value=""SS"" />
      <xs:enumeration value=""ST"" />
      <xs:enumeration value=""SU"" />
      <xs:enumeration value=""SV"" />
      <xs:enumeration value=""SW"" />
      <xs:enumeration value=""SX"" />
      <xs:enumeration value=""SY"" />
      <xs:enumeration value=""SZ"" />
      <xs:enumeration value=""T2"" />
      <xs:enumeration value=""T3"" />
      <xs:enumeration value=""TA"" />
      <xs:enumeration value=""TB"" />
      <xs:enumeration value=""TC"" />
      <xs:enumeration value=""TD"" />
      <xs:enumeration value=""TE"" />
      <xs:enumeration value=""TF"" />
      <xs:enumeration value=""TG"" />
      <xs:enumeration value=""TH"" />
      <xs:enumeration value=""TI"" />
      <xs:enumeration value=""TJ"" />
      <xs:enumeration value=""TM"" />
      <xs:enumeration value=""TN"" />
      <xs:enumeration value=""TP"" />
      <xs:enumeration value=""TR"" />
      <xs:enumeration value=""TS"" />
      <xs:enumeration value=""TT"" />
      <xs:enumeration value=""TU"" />
      <xs:enumeration value=""TV"" />
      <xs:enumeration value=""TW"" />
      <xs:enumeration value=""TX"" />
      <xs:enumeration value=""TY"" />
      <xs:enumeration value=""TZ"" />
      <xs:enumeration value=""U2"" />
      <xs:enumeration value=""U3"" />
      <xs:enumeration value=""U5"" />
      <xs:enumeration value=""U6"" />
      <xs:enumeration value=""UA"" />
      <xs:enumeration value=""UB"" />
      <xs:enumeration value=""UC"" />
      <xs:enumeration value=""UD"" />
      <xs:enumeration value=""UE"" />
      <xs:enumeration value=""UF"" />
      <xs:enumeration value=""UG"" />
      <xs:enumeration value=""UH"" />
      <xs:enumeration value=""UI"" />
      <xs:enumeration value=""UJ"" />
      <xs:enumeration value=""UK"" />
      <xs:enumeration value=""UL"" />
      <xs:enumeration value=""UM"" />
      <xs:enumeration value=""UN"" />
      <xs:enumeration value=""UO"" />
      <xs:enumeration value=""UP"" />
      <xs:enumeration value=""UQ"" />
      <xs:enumeration value=""UR"" />
      <xs:enumeration value=""US"" />
      <xs:enumeration value=""UT"" />
      <xs:enumeration value=""UV"" />
      <xs:enumeration value=""UX"" />
      <xs:enumeration value=""VA"" />
      <xs:enumeration value=""VB"" />
      <xs:enumeration value=""VC"" />
      <xs:enumeration value=""VE"" />
      <xs:enumeration value=""VI"" />
      <xs:enumeration value=""VM"" />
      <xs:enumeration value=""VN"" />
      <xs:enumeration value=""VO"" />
      <xs:enumeration value=""VP"" />
      <xs:enumeration value=""VS"" />
      <xs:enumeration value=""VT"" />
      <xs:enumeration value=""VU"" />
      <xs:enumeration value=""VV"" />
      <xs:enumeration value=""VX"" />
      <xs:enumeration value=""W1"" />
      <xs:enumeration value=""W2"" />
      <xs:enumeration value=""W5"" />
      <xs:enumeration value=""W6"" />
      <xs:enumeration value=""W7"" />
      <xs:enumeration value=""WA"" />
      <xs:enumeration value=""WC"" />
      <xs:enumeration value=""WL"" />
      <xs:enumeration value=""WR"" />
      <xs:enumeration value=""WS"" />
      <xs:enumeration value=""XA"" />
      <xs:enumeration value=""XC"" />
      <xs:enumeration value=""XP"" />
      <xs:enumeration value=""XQ"" />
      <xs:enumeration value=""XZ"" />
      <xs:enumeration value=""YP"" />
      <xs:enumeration value=""ZB"" />
      <xs:enumeration value=""ZR"" />
      <xs:enumeration value=""ZZ"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""X12_ID_892"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""01"" />
      <xs:enumeration value=""02"" />
      <xs:enumeration value=""03"" />
      <xs:enumeration value=""04"" />
      <xs:enumeration value=""05"" />
      <xs:enumeration value=""06"" />
      <xs:enumeration value=""07"" />
      <xs:enumeration value=""08"" />
      <xs:enumeration value=""09"" />
      <xs:enumeration value=""10"" />
      <xs:enumeration value=""11"" />
      <xs:enumeration value=""12"" />
      <xs:enumeration value=""13"" />
      <xs:enumeration value=""14"" />
      <xs:enumeration value=""15"" />
      <xs:enumeration value=""16"" />
      <xs:enumeration value=""17"" />
      <xs:enumeration value=""20"" />
      <xs:enumeration value=""21"" />
      <xs:enumeration value=""22"" />
      <xs:enumeration value=""23"" />
      <xs:enumeration value=""24"" />
      <xs:enumeration value=""25"" />
      <xs:enumeration value=""26"" />
      <xs:enumeration value=""ZZ"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""X12_ID_893"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""1"" />
      <xs:enumeration value=""2"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""X12_ID_673"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""01"" />
      <xs:enumeration value=""02"" />
      <xs:enumeration value=""03"" />
      <xs:enumeration value=""04"" />
      <xs:enumeration value=""05"" />
      <xs:enumeration value=""06"" />
      <xs:enumeration value=""07"" />
      <xs:enumeration value=""08"" />
      <xs:enumeration value=""09"" />
      <xs:enumeration value=""10"" />
      <xs:enumeration value=""11"" />
      <xs:enumeration value=""12"" />
      <xs:enumeration value=""13"" />
      <xs:enumeration value=""14"" />
      <xs:enumeration value=""15"" />
      <xs:enumeration value=""16"" />
      <xs:enumeration value=""17"" />
      <xs:enumeration value=""18"" />
      <xs:enumeration value=""19"" />
      <xs:enumeration value=""1A"" />
      <xs:enumeration value=""1B"" />
      <xs:enumeration value=""1C"" />
      <xs:enumeration value=""1D"" />
      <xs:enumeration value=""1E"" />
      <xs:enumeration value=""1F"" />
      <xs:enumeration value=""1G"" />
      <xs:enumeration value=""1H"" />
      <xs:enumeration value=""1I"" />
      <xs:enumeration value=""1J"" />
      <xs:enumeration value=""1K"" />
      <xs:enumeration value=""1L"" />
      <xs:enumeration value=""1M"" />
      <xs:enumeration value=""1N"" />
      <xs:enumeration value=""1O"" />
      <xs:enumeration value=""1P"" />
      <xs:enumeration value=""1Q"" />
      <xs:enumeration value=""1R"" />
      <xs:enumeration value=""1S"" />
      <xs:enumeration value=""1T"" />
      <xs:enumeration value=""1U"" />
      <xs:enumeration value=""1V"" />
      <xs:enumeration value=""1W"" />
      <xs:enumeration value=""1X"" />
      <xs:enumeration value=""1Y"" />
      <xs:enumeration value=""1Z"" />
      <xs:enumeration value=""20"" />
      <xs:enumeration value=""21"" />
      <xs:enumeration value=""22"" />
      <xs:enumeration value=""23"" />
      <xs:enumeration value=""24"" />
      <xs:enumeration value=""25"" />
      <xs:enumeration value=""26"" />
      <xs:enumeration value=""27"" />
      <xs:enumeration value=""28"" />
      <xs:enumeration value=""29"" />
      <xs:enumeration value=""2A"" />
      <xs:enumeration value=""2B"" />
      <xs:enumeration value=""2C"" />
      <xs:enumeration value=""2D"" />
      <xs:enumeration value=""2E"" />
      <xs:enumeration value=""2F"" />
      <xs:enumeration value=""2G"" />
      <xs:enumeration value=""2H"" />
      <xs:enumeration value=""2I"" />
      <xs:enumeration value=""2J"" />
      <xs:enumeration value=""2K"" />
      <xs:enumeration value=""2L"" />
      <xs:enumeration value=""2M"" />
      <xs:enumeration value=""2N"" />
      <xs:enumeration value=""2O"" />
      <xs:enumeration value=""2P"" />
      <xs:enumeration value=""2Q"" />
      <xs:enumeration value=""2R"" />
      <xs:enumeration value=""2S"" />
      <xs:enumeration value=""2T"" />
      <xs:enumeration value=""2U"" />
      <xs:enumeration value=""2V"" />
      <xs:enumeration value=""2W"" />
      <xs:enumeration value=""2X"" />
      <xs:enumeration value=""2Y"" />
      <xs:enumeration value=""2Z"" />
      <xs:enumeration value=""30"" />
      <xs:enumeration value=""31"" />
      <xs:enumeration value=""32"" />
      <xs:enumeration value=""33"" />
      <xs:enumeration value=""34"" />
      <xs:enumeration value=""35"" />
      <xs:enumeration value=""36"" />
      <xs:enumeration value=""37"" />
      <xs:enumeration value=""38"" />
      <xs:enumeration value=""39"" />
      <xs:enumeration value=""3A"" />
      <xs:enumeration value=""3B"" />
      <xs:enumeration value=""3C"" />
      <xs:enumeration value=""3D"" />
      <xs:enumeration value=""3E"" />
      <xs:enumeration value=""3F"" />
      <xs:enumeration value=""3G"" />
      <xs:enumeration value=""3H"" />
      <xs:enumeration value=""3I"" />
      <xs:enumeration value=""3J"" />
      <xs:enumeration value=""3K"" />
      <xs:enumeration value=""3L"" />
      <xs:enumeration value=""3M"" />
      <xs:enumeration value=""3N"" />
      <xs:enumeration value=""3P"" />
      <xs:enumeration value=""3Q"" />
      <xs:enumeration value=""3R"" />
      <xs:enumeration value=""3S"" />
      <xs:enumeration value=""3T"" />
      <xs:enumeration value=""3U"" />
      <xs:enumeration value=""3V"" />
      <xs:enumeration value=""3W"" />
      <xs:enumeration value=""3X"" />
      <xs:enumeration value=""3Y"" />
      <xs:enumeration value=""40"" />
      <xs:enumeration value=""41"" />
      <xs:enumeration value=""42"" />
      <xs:enumeration value=""43"" />
      <xs:enumeration value=""45"" />
      <xs:enumeration value=""46"" />
      <xs:enumeration value=""47"" />
      <xs:enumeration value=""48"" />
      <xs:enumeration value=""49"" />
      <xs:enumeration value=""4A"" />
      <xs:enumeration value=""4B"" />
      <xs:enumeration value=""4C"" />
      <xs:enumeration value=""4D"" />
      <xs:enumeration value=""4E"" />
      <xs:enumeration value=""4F"" />
      <xs:enumeration value=""4G"" />
      <xs:enumeration value=""4H"" />
      <xs:enumeration value=""4I"" />
      <xs:enumeration value=""4J"" />
      <xs:enumeration value=""4K"" />
      <xs:enumeration value=""4L"" />
      <xs:enumeration value=""4M"" />
      <xs:enumeration value=""4N"" />
      <xs:enumeration value=""4O"" />
      <xs:enumeration value=""4P"" />
      <xs:enumeration value=""4Q"" />
      <xs:enumeration value=""4R"" />
      <xs:enumeration value=""4S"" />
      <xs:enumeration value=""4T"" />
      <xs:enumeration value=""4U"" />
      <xs:enumeration value=""50"" />
      <xs:enumeration value=""51"" />
      <xs:enumeration value=""52"" />
      <xs:enumeration value=""53"" />
      <xs:enumeration value=""54"" />
      <xs:enumeration value=""55"" />
      <xs:enumeration value=""56"" />
      <xs:enumeration value=""57"" />
      <xs:enumeration value=""58"" />
      <xs:enumeration value=""5A"" />
      <xs:enumeration value=""5B"" />
      <xs:enumeration value=""5C"" />
      <xs:enumeration value=""5D"" />
      <xs:enumeration value=""5E"" />
      <xs:enumeration value=""5F"" />
      <xs:enumeration value=""5G"" />
      <xs:enumeration value=""5H"" />
      <xs:enumeration value=""5I"" />
      <xs:enumeration value=""5J"" />
      <xs:enumeration value=""5K"" />
      <xs:enumeration value=""5L"" />
      <xs:enumeration value=""5M"" />
      <xs:enumeration value=""5N"" />
      <xs:enumeration value=""5O"" />
      <xs:enumeration value=""5P"" />
      <xs:enumeration value=""5Q"" />
      <xs:enumeration value=""5R"" />
      <xs:enumeration value=""5S"" />
      <xs:enumeration value=""5T"" />
      <xs:enumeration value=""5U"" />
      <xs:enumeration value=""5V"" />
      <xs:enumeration value=""5W"" />
      <xs:enumeration value=""5X"" />
      <xs:enumeration value=""5Y"" />
      <xs:enumeration value=""5Z"" />
      <xs:enumeration value=""60"" />
      <xs:enumeration value=""61"" />
      <xs:enumeration value=""62"" />
      <xs:enumeration value=""63"" />
      <xs:enumeration value=""64"" />
      <xs:enumeration value=""65"" />
      <xs:enumeration value=""66"" />
      <xs:enumeration value=""67"" />
      <xs:enumeration value=""68"" />
      <xs:enumeration value=""69"" />
      <xs:enumeration value=""6A"" />
      <xs:enumeration value=""6B"" />
      <xs:enumeration value=""6C"" />
      <xs:enumeration value=""6D"" />
      <xs:enumeration value=""6E"" />
      <xs:enumeration value=""6F"" />
      <xs:enumeration value=""6G"" />
      <xs:enumeration value=""6H"" />
      <xs:enumeration value=""6I"" />
      <xs:enumeration value=""6J"" />
      <xs:enumeration value=""6K"" />
      <xs:enumeration value=""6L"" />
      <xs:enumeration value=""6M"" />
      <xs:enumeration value=""6N"" />
      <xs:enumeration value=""6O"" />
      <xs:enumeration value=""6P"" />
      <xs:enumeration value=""6Q"" />
      <xs:enumeration value=""6R"" />
      <xs:enumeration value=""6S"" />
      <xs:enumeration value=""6T"" />
      <xs:enumeration value=""6U"" />
      <xs:enumeration value=""6V"" />
      <xs:enumeration value=""6W"" />
      <xs:enumeration value=""6X"" />
      <xs:enumeration value=""6Z"" />
      <xs:enumeration value=""70"" />
      <xs:enumeration value=""72"" />
      <xs:enumeration value=""73"" />
      <xs:enumeration value=""74"" />
      <xs:enumeration value=""75"" />
      <xs:enumeration value=""76"" />
      <xs:enumeration value=""77"" />
      <xs:enumeration value=""78"" />
      <xs:enumeration value=""79"" />
      <xs:enumeration value=""7A"" />
      <xs:enumeration value=""7B"" />
      <xs:enumeration value=""7C"" />
      <xs:enumeration value=""7D"" />
      <xs:enumeration value=""7E"" />
      <xs:enumeration value=""7F"" />
      <xs:enumeration value=""7G"" />
      <xs:enumeration value=""7H"" />
      <xs:enumeration value=""7I"" />
      <xs:enumeration value=""7J"" />
      <xs:enumeration value=""7K"" />
      <xs:enumeration value=""7L"" />
      <xs:enumeration value=""7M"" />
      <xs:enumeration value=""7N"" />
      <xs:enumeration value=""7O"" />
      <xs:enumeration value=""7P"" />
      <xs:enumeration value=""7Q"" />
      <xs:enumeration value=""7R"" />
      <xs:enumeration value=""7S"" />
      <xs:enumeration value=""7T"" />
      <xs:enumeration value=""7U"" />
      <xs:enumeration value=""7V"" />
      <xs:enumeration value=""7W"" />
      <xs:enumeration value=""7X"" />
      <xs:enumeration value=""7Y"" />
      <xs:enumeration value=""7Z"" />
      <xs:enumeration value=""80"" />
      <xs:enumeration value=""81"" />
      <xs:enumeration value=""82"" />
      <xs:enumeration value=""83"" />
      <xs:enumeration value=""84"" />
      <xs:enumeration value=""85"" />
      <xs:enumeration value=""86"" />
      <xs:enumeration value=""87"" />
      <xs:enumeration value=""88"" />
      <xs:enumeration value=""89"" />
      <xs:enumeration value=""8A"" />
      <xs:enumeration value=""8B"" />
      <xs:enumeration value=""8C"" />
      <xs:enumeration value=""8D"" />
      <xs:enumeration value=""8E"" />
      <xs:enumeration value=""8F"" />
      <xs:enumeration value=""8G"" />
      <xs:enumeration value=""8H"" />
      <xs:enumeration value=""8I"" />
      <xs:enumeration value=""8J"" />
      <xs:enumeration value=""8K"" />
      <xs:enumeration value=""8L"" />
      <xs:enumeration value=""8M"" />
      <xs:enumeration value=""8N"" />
      <xs:enumeration value=""8O"" />
      <xs:enumeration value=""8P"" />
      <xs:enumeration value=""8Q"" />
      <xs:enumeration value=""8R"" />
      <xs:enumeration value=""8S"" />
      <xs:enumeration value=""90"" />
      <xs:enumeration value=""91"" />
      <xs:enumeration value=""92"" />
      <xs:enumeration value=""93"" />
      <xs:enumeration value=""94"" />
      <xs:enumeration value=""95"" />
      <xs:enumeration value=""96"" />
      <xs:enumeration value=""97"" />
      <xs:enumeration value=""98"" />
      <xs:enumeration value=""99"" />
      <xs:enumeration value=""9A"" />
      <xs:enumeration value=""9C"" />
      <xs:enumeration value=""9D"" />
      <xs:enumeration value=""9E"" />
      <xs:enumeration value=""9F"" />
      <xs:enumeration value=""9H"" />
      <xs:enumeration value=""9J"" />
      <xs:enumeration value=""9K"" />
      <xs:enumeration value=""9L"" />
      <xs:enumeration value=""9M"" />
      <xs:enumeration value=""9N"" />
      <xs:enumeration value=""A1"" />
      <xs:enumeration value=""A2"" />
      <xs:enumeration value=""A3"" />
      <xs:enumeration value=""A4"" />
      <xs:enumeration value=""A5"" />
      <xs:enumeration value=""A6"" />
      <xs:enumeration value=""A7"" />
      <xs:enumeration value=""A8"" />
      <xs:enumeration value=""A9"" />
      <xs:enumeration value=""AA"" />
      <xs:enumeration value=""AB"" />
      <xs:enumeration value=""AC"" />
      <xs:enumeration value=""AD"" />
      <xs:enumeration value=""AE"" />
      <xs:enumeration value=""AF"" />
      <xs:enumeration value=""AG"" />
      <xs:enumeration value=""AH"" />
      <xs:enumeration value=""AI"" />
      <xs:enumeration value=""AJ"" />
      <xs:enumeration value=""AK"" />
      <xs:enumeration value=""AL"" />
      <xs:enumeration value=""AN"" />
      <xs:enumeration value=""AO"" />
      <xs:enumeration value=""AP"" />
      <xs:enumeration value=""AQ"" />
      <xs:enumeration value=""AR"" />
      <xs:enumeration value=""AS"" />
      <xs:enumeration value=""AT"" />
      <xs:enumeration value=""AU"" />
      <xs:enumeration value=""AV"" />
      <xs:enumeration value=""AW"" />
      <xs:enumeration value=""AX"" />
      <xs:enumeration value=""AY"" />
      <xs:enumeration value=""AZ"" />
      <xs:enumeration value=""B1"" />
      <xs:enumeration value=""B2"" />
      <xs:enumeration value=""B3"" />
      <xs:enumeration value=""B4"" />
      <xs:enumeration value=""B5"" />
      <xs:enumeration value=""B6"" />
      <xs:enumeration value=""B7"" />
      <xs:enumeration value=""B8"" />
      <xs:enumeration value=""BA"" />
      <xs:enumeration value=""BB"" />
      <xs:enumeration value=""BC"" />
      <xs:enumeration value=""BD"" />
      <xs:enumeration value=""BE"" />
      <xs:enumeration value=""BF"" />
      <xs:enumeration value=""BG"" />
      <xs:enumeration value=""BH"" />
      <xs:enumeration value=""BI"" />
      <xs:enumeration value=""BJ"" />
      <xs:enumeration value=""BK"" />
      <xs:enumeration value=""BQ"" />
      <xs:enumeration value=""BR"" />
      <xs:enumeration value=""BW"" />
      <xs:enumeration value=""C0"" />
      <xs:enumeration value=""CA"" />
      <xs:enumeration value=""CB"" />
      <xs:enumeration value=""CC"" />
      <xs:enumeration value=""CD"" />
      <xs:enumeration value=""CE"" />
      <xs:enumeration value=""CF"" />
      <xs:enumeration value=""CG"" />
      <xs:enumeration value=""CH"" />
      <xs:enumeration value=""CI"" />
      <xs:enumeration value=""CL"" />
      <xs:enumeration value=""CN"" />
      <xs:enumeration value=""CO"" />
      <xs:enumeration value=""CP"" />
      <xs:enumeration value=""CR"" />
      <xs:enumeration value=""CS"" />
      <xs:enumeration value=""CW"" />
      <xs:enumeration value=""CY"" />
      <xs:enumeration value=""CZ"" />
      <xs:enumeration value=""D1"" />
      <xs:enumeration value=""D3"" />
      <xs:enumeration value=""DA"" />
      <xs:enumeration value=""DB"" />
      <xs:enumeration value=""DC"" />
      <xs:enumeration value=""DD"" />
      <xs:enumeration value=""DE"" />
      <xs:enumeration value=""DF"" />
      <xs:enumeration value=""DG"" />
      <xs:enumeration value=""DI"" />
      <xs:enumeration value=""DN"" />
      <xs:enumeration value=""DO"" />
      <xs:enumeration value=""DP"" />
      <xs:enumeration value=""DR"" />
      <xs:enumeration value=""DS"" />
      <xs:enumeration value=""DT"" />
      <xs:enumeration value=""DY"" />
      <xs:enumeration value=""E1"" />
      <xs:enumeration value=""E2"" />
      <xs:enumeration value=""E3"" />
      <xs:enumeration value=""E4"" />
      <xs:enumeration value=""E5"" />
      <xs:enumeration value=""EA"" />
      <xs:enumeration value=""EB"" />
      <xs:enumeration value=""EC"" />
      <xs:enumeration value=""ED"" />
      <xs:enumeration value=""EE"" />
      <xs:enumeration value=""EM"" />
      <xs:enumeration value=""EP"" />
      <xs:enumeration value=""EQ"" />
      <xs:enumeration value=""ER"" />
      <xs:enumeration value=""ES"" />
      <xs:enumeration value=""ET"" />
      <xs:enumeration value=""EW"" />
      <xs:enumeration value=""F1"" />
      <xs:enumeration value=""FA"" />
      <xs:enumeration value=""FB"" />
      <xs:enumeration value=""FC"" />
      <xs:enumeration value=""FD"" />
      <xs:enumeration value=""FE"" />
      <xs:enumeration value=""FF"" />
      <xs:enumeration value=""FG"" />
      <xs:enumeration value=""FH"" />
      <xs:enumeration value=""FI"" />
      <xs:enumeration value=""FJ"" />
      <xs:enumeration value=""FK"" />
      <xs:enumeration value=""FL"" />
      <xs:enumeration value=""FM"" />
      <xs:enumeration value=""FR"" />
      <xs:enumeration value=""FS"" />
      <xs:enumeration value=""FT"" />
      <xs:enumeration value=""GA"" />
      <xs:enumeration value=""GB"" />
      <xs:enumeration value=""GC"" />
      <xs:enumeration value=""GE"" />
      <xs:enumeration value=""GF"" />
      <xs:enumeration value=""GI"" />
      <xs:enumeration value=""GL"" />
      <xs:enumeration value=""GP"" />
      <xs:enumeration value=""GQ"" />
      <xs:enumeration value=""GR"" />
      <xs:enumeration value=""GS"" />
      <xs:enumeration value=""GT"" />
      <xs:enumeration value=""GU"" />
      <xs:enumeration value=""GV"" />
      <xs:enumeration value=""GW"" />
      <xs:enumeration value=""GX"" />
      <xs:enumeration value=""GZ"" />
      <xs:enumeration value=""HA"" />
      <xs:enumeration value=""HB"" />
      <xs:enumeration value=""HC"" />
      <xs:enumeration value=""HD"" />
      <xs:enumeration value=""HE"" />
      <xs:enumeration value=""HF"" />
      <xs:enumeration value=""HG"" />
      <xs:enumeration value=""HH"" />
      <xs:enumeration value=""HI"" />
      <xs:enumeration value=""HJ"" />
      <xs:enumeration value=""HK"" />
      <xs:enumeration value=""HL"" />
      <xs:enumeration value=""HM"" />
      <xs:enumeration value=""HN"" />
      <xs:enumeration value=""HO"" />
      <xs:enumeration value=""HP"" />
      <xs:enumeration value=""HR"" />
      <xs:enumeration value=""HS"" />
      <xs:enumeration value=""II"" />
      <xs:enumeration value=""IN"" />
      <xs:enumeration value=""IP"" />
      <xs:enumeration value=""IQ"" />
      <xs:enumeration value=""IS"" />
      <xs:enumeration value=""IT"" />
      <xs:enumeration value=""JA"" />
      <xs:enumeration value=""JB"" />
      <xs:enumeration value=""JC"" />
      <xs:enumeration value=""JD"" />
      <xs:enumeration value=""JE"" />
      <xs:enumeration value=""JF"" />
      <xs:enumeration value=""JG"" />
      <xs:enumeration value=""JH"" />
      <xs:enumeration value=""JI"" />
      <xs:enumeration value=""JJ"" />
      <xs:enumeration value=""JK"" />
      <xs:enumeration value=""JL"" />
      <xs:enumeration value=""JM"" />
      <xs:enumeration value=""JN"" />
      <xs:enumeration value=""JO"" />
      <xs:enumeration value=""JP"" />
      <xs:enumeration value=""JQ"" />
      <xs:enumeration value=""JR"" />
      <xs:enumeration value=""JS"" />
      <xs:enumeration value=""JT"" />
      <xs:enumeration value=""K6"" />
      <xs:enumeration value=""KA"" />
      <xs:enumeration value=""KB"" />
      <xs:enumeration value=""KC"" />
      <xs:enumeration value=""KD"" />
      <xs:enumeration value=""KE"" />
      <xs:enumeration value=""KF"" />
      <xs:enumeration value=""KG"" />
      <xs:enumeration value=""KH"" />
      <xs:enumeration value=""KI"" />
      <xs:enumeration value=""KJ"" />
      <xs:enumeration value=""KK"" />
      <xs:enumeration value=""KL"" />
      <xs:enumeration value=""KM"" />
      <xs:enumeration value=""KN"" />
      <xs:enumeration value=""KO"" />
      <xs:enumeration value=""KP"" />
      <xs:enumeration value=""KQ"" />
      <xs:enumeration value=""KR"" />
      <xs:enumeration value=""KS"" />
      <xs:enumeration value=""KU"" />
      <xs:enumeration value=""KV"" />
      <xs:enumeration value=""KW"" />
      <xs:enumeration value=""KX"" />
      <xs:enumeration value=""KY"" />
      <xs:enumeration value=""KZ"" />
      <xs:enumeration value=""L2"" />
      <xs:enumeration value=""L3"" />
      <xs:enumeration value=""L4"" />
      <xs:enumeration value=""L5"" />
      <xs:enumeration value=""L6"" />
      <xs:enumeration value=""L7"" />
      <xs:enumeration value=""LA"" />
      <xs:enumeration value=""LB"" />
      <xs:enumeration value=""LC"" />
      <xs:enumeration value=""LE"" />
      <xs:enumeration value=""LG"" />
      <xs:enumeration value=""LH"" />
      <xs:enumeration value=""LI"" />
      <xs:enumeration value=""LK"" />
      <xs:enumeration value=""LL"" />
      <xs:enumeration value=""LM"" />
      <xs:enumeration value=""LN"" />
      <xs:enumeration value=""LO"" />
      <xs:enumeration value=""LP"" />
      <xs:enumeration value=""LQ"" />
      <xs:enumeration value=""LR"" />
      <xs:enumeration value=""LS"" />
      <xs:enumeration value=""LT"" />
      <xs:enumeration value=""LV"" />
      <xs:enumeration value=""LW"" />
      <xs:enumeration value=""LX"" />
      <xs:enumeration value=""LY"" />
      <xs:enumeration value=""M1"" />
      <xs:enumeration value=""M2"" />
      <xs:enumeration value=""MA"" />
      <xs:enumeration value=""MD"" />
      <xs:enumeration value=""ME"" />
      <xs:enumeration value=""MF"" />
      <xs:enumeration value=""MI"" />
      <xs:enumeration value=""MM"" />
      <xs:enumeration value=""MN"" />
      <xs:enumeration value=""MO"" />
      <xs:enumeration value=""MQ"" />
      <xs:enumeration value=""MX"" />
      <xs:enumeration value=""N1"" />
      <xs:enumeration value=""N2"" />
      <xs:enumeration value=""N3"" />
      <xs:enumeration value=""N4"" />
      <xs:enumeration value=""N5"" />
      <xs:enumeration value=""N6"" />
      <xs:enumeration value=""NA"" />
      <xs:enumeration value=""NB"" />
      <xs:enumeration value=""NC"" />
      <xs:enumeration value=""ND"" />
      <xs:enumeration value=""NE"" />
      <xs:enumeration value=""NF"" />
      <xs:enumeration value=""NG"" />
      <xs:enumeration value=""NL"" />
      <xs:enumeration value=""NN"" />
      <xs:enumeration value=""NO"" />
      <xs:enumeration value=""NP"" />
      <xs:enumeration value=""NQ"" />
      <xs:enumeration value=""NR"" />
      <xs:enumeration value=""NS"" />
      <xs:enumeration value=""NT"" />
      <xs:enumeration value=""NU"" />
      <xs:enumeration value=""NV"" />
      <xs:enumeration value=""NW"" />
      <xs:enumeration value=""OC"" />
      <xs:enumeration value=""OD"" />
      <xs:enumeration value=""OF"" />
      <xs:enumeration value=""OG"" />
      <xs:enumeration value=""OH"" />
      <xs:enumeration value=""OI"" />
      <xs:enumeration value=""OL"" />
      <xs:enumeration value=""ON"" />
      <xs:enumeration value=""OO"" />
      <xs:enumeration value=""OR"" />
      <xs:enumeration value=""OT"" />
      <xs:enumeration value=""OU"" />
      <xs:enumeration value=""OV"" />
      <xs:enumeration value=""OW"" />
      <xs:enumeration value=""P1"" />
      <xs:enumeration value=""P3"" />
      <xs:enumeration value=""P4"" />
      <xs:enumeration value=""P5"" />
      <xs:enumeration value=""P6"" />
      <xs:enumeration value=""P7"" />
      <xs:enumeration value=""P8"" />
      <xs:enumeration value=""P9"" />
      <xs:enumeration value=""PA"" />
      <xs:enumeration value=""PB"" />
      <xs:enumeration value=""PC"" />
      <xs:enumeration value=""PD"" />
      <xs:enumeration value=""PE"" />
      <xs:enumeration value=""PF"" />
      <xs:enumeration value=""PG"" />
      <xs:enumeration value=""PK"" />
      <xs:enumeration value=""PL"" />
      <xs:enumeration value=""PO"" />
      <xs:enumeration value=""PP"" />
      <xs:enumeration value=""PQ"" />
      <xs:enumeration value=""PR"" />
      <xs:enumeration value=""PS"" />
      <xs:enumeration value=""PT"" />
      <xs:enumeration value=""PW"" />
      <xs:enumeration value=""PX"" />
      <xs:enumeration value=""Q1"" />
      <xs:enumeration value=""Q2"" />
      <xs:enumeration value=""Q3"" />
      <xs:enumeration value=""Q4"" />
      <xs:enumeration value=""QA"" />
      <xs:enumeration value=""QB"" />
      <xs:enumeration value=""QC"" />
      <xs:enumeration value=""QD"" />
      <xs:enumeration value=""QE"" />
      <xs:enumeration value=""QF"" />
      <xs:enumeration value=""QH"" />
      <xs:enumeration value=""QI"" />
      <xs:enumeration value=""QJ"" />
      <xs:enumeration value=""QL"" />
      <xs:enumeration value=""QM"" />
      <xs:enumeration value=""QN"" />
      <xs:enumeration value=""QO"" />
      <xs:enumeration value=""QP"" />
      <xs:enumeration value=""QQ"" />
      <xs:enumeration value=""QR"" />
      <xs:enumeration value=""QS"" />
      <xs:enumeration value=""QU"" />
      <xs:enumeration value=""QV"" />
      <xs:enumeration value=""QW"" />
      <xs:enumeration value=""QX"" />
      <xs:enumeration value=""R3"" />
      <xs:enumeration value=""R5"" />
      <xs:enumeration value=""R6"" />
      <xs:enumeration value=""R9"" />
      <xs:enumeration value=""RA"" />
      <xs:enumeration value=""RB"" />
      <xs:enumeration value=""RC"" />
      <xs:enumeration value=""RD"" />
      <xs:enumeration value=""RE"" />
      <xs:enumeration value=""RF"" />
      <xs:enumeration value=""RG"" />
      <xs:enumeration value=""RH"" />
      <xs:enumeration value=""RJ"" />
      <xs:enumeration value=""RL"" />
      <xs:enumeration value=""RM"" />
      <xs:enumeration value=""RN"" />
      <xs:enumeration value=""RQ"" />
      <xs:enumeration value=""RS"" />
      <xs:enumeration value=""RT"" />
      <xs:enumeration value=""RW"" />
      <xs:enumeration value=""RY"" />
      <xs:enumeration value=""S1"" />
      <xs:enumeration value=""S2"" />
      <xs:enumeration value=""S3"" />
      <xs:enumeration value=""S4"" />
      <xs:enumeration value=""S5"" />
      <xs:enumeration value=""S6"" />
      <xs:enumeration value=""S7"" />
      <xs:enumeration value=""S8"" />
      <xs:enumeration value=""S9"" />
      <xs:enumeration value=""SA"" />
      <xs:enumeration value=""SB"" />
      <xs:enumeration value=""SC"" />
      <xs:enumeration value=""SD"" />
      <xs:enumeration value=""SE"" />
      <xs:enumeration value=""SF"" />
      <xs:enumeration value=""SG"" />
      <xs:enumeration value=""SH"" />
      <xs:enumeration value=""SI"" />
      <xs:enumeration value=""SJ"" />
      <xs:enumeration value=""SK"" />
      <xs:enumeration value=""SL"" />
      <xs:enumeration value=""SM"" />
      <xs:enumeration value=""SN"" />
      <xs:enumeration value=""SO"" />
      <xs:enumeration value=""SP"" />
      <xs:enumeration value=""SQ"" />
      <xs:enumeration value=""SR"" />
      <xs:enumeration value=""SS"" />
      <xs:enumeration value=""ST"" />
      <xs:enumeration value=""SU"" />
      <xs:enumeration value=""SV"" />
      <xs:enumeration value=""SW"" />
      <xs:enumeration value=""SX"" />
      <xs:enumeration value=""SY"" />
      <xs:enumeration value=""T1"" />
      <xs:enumeration value=""T2"" />
      <xs:enumeration value=""T3"" />
      <xs:enumeration value=""T4"" />
      <xs:enumeration value=""T5"" />
      <xs:enumeration value=""T6"" />
      <xs:enumeration value=""T7"" />
      <xs:enumeration value=""TA"" />
      <xs:enumeration value=""TB"" />
      <xs:enumeration value=""TC"" />
      <xs:enumeration value=""TD"" />
      <xs:enumeration value=""TE"" />
      <xs:enumeration value=""TG"" />
      <xs:enumeration value=""TH"" />
      <xs:enumeration value=""TI"" />
      <xs:enumeration value=""TJ"" />
      <xs:enumeration value=""TK"" />
      <xs:enumeration value=""TM"" />
      <xs:enumeration value=""TN"" />
      <xs:enumeration value=""TO"" />
      <xs:enumeration value=""TP"" />
      <xs:enumeration value=""TR"" />
      <xs:enumeration value=""TS"" />
      <xs:enumeration value=""TT"" />
      <xs:enumeration value=""TU"" />
      <xs:enumeration value=""TV"" />
      <xs:enumeration value=""TW"" />
      <xs:enumeration value=""TX"" />
      <xs:enumeration value=""TY"" />
      <xs:enumeration value=""UA"" />
      <xs:enumeration value=""UG"" />
      <xs:enumeration value=""UL"" />
      <xs:enumeration value=""UO"" />
      <xs:enumeration value=""US"" />
      <xs:enumeration value=""UU"" />
      <xs:enumeration value=""V1"" />
      <xs:enumeration value=""V2"" />
      <xs:enumeration value=""V3"" />
      <xs:enumeration value=""V4"" />
      <xs:enumeration value=""V5"" />
      <xs:enumeration value=""VA"" />
      <xs:enumeration value=""VB"" />
      <xs:enumeration value=""VC"" />
      <xs:enumeration value=""VD"" />
      <xs:enumeration value=""VE"" />
      <xs:enumeration value=""VF"" />
      <xs:enumeration value=""VG"" />
      <xs:enumeration value=""VH"" />
      <xs:enumeration value=""VI"" />
      <xs:enumeration value=""VJ"" />
      <xs:enumeration value=""VK"" />
      <xs:enumeration value=""VL"" />
      <xs:enumeration value=""VM"" />
      <xs:enumeration value=""VN"" />
      <xs:enumeration value=""VP"" />
      <xs:enumeration value=""VR"" />
      <xs:enumeration value=""VS"" />
      <xs:enumeration value=""VT"" />
      <xs:enumeration value=""VV"" />
      <xs:enumeration value=""VY"" />
      <xs:enumeration value=""WA"" />
      <xs:enumeration value=""WB"" />
      <xs:enumeration value=""WC"" />
      <xs:enumeration value=""WD"" />
      <xs:enumeration value=""WE"" />
      <xs:enumeration value=""WG"" />
      <xs:enumeration value=""WL"" />
      <xs:enumeration value=""WO"" />
      <xs:enumeration value=""WP"" />
      <xs:enumeration value=""WR"" />
      <xs:enumeration value=""WT"" />
      <xs:enumeration value=""WV"" />
      <xs:enumeration value=""WW"" />
      <xs:enumeration value=""WX"" />
      <xs:enumeration value=""WY"" />
      <xs:enumeration value=""X1"" />
      <xs:enumeration value=""XA"" />
      <xs:enumeration value=""XB"" />
      <xs:enumeration value=""XC"" />
      <xs:enumeration value=""XD"" />
      <xs:enumeration value=""XE"" />
      <xs:enumeration value=""XG"" />
      <xs:enumeration value=""XI"" />
      <xs:enumeration value=""XJ"" />
      <xs:enumeration value=""XL"" />
      <xs:enumeration value=""XN"" />
      <xs:enumeration value=""XO"" />
      <xs:enumeration value=""XT"" />
      <xs:enumeration value=""XU"" />
      <xs:enumeration value=""XV"" />
      <xs:enumeration value=""XX"" />
      <xs:enumeration value=""XY"" />
      <xs:enumeration value=""XZ"" />
      <xs:enumeration value=""YA"" />
      <xs:enumeration value=""YB"" />
      <xs:enumeration value=""YC"" />
      <xs:enumeration value=""YD"" />
      <xs:enumeration value=""YE"" />
      <xs:enumeration value=""YF"" />
      <xs:enumeration value=""YG"" />
      <xs:enumeration value=""YH"" />
      <xs:enumeration value=""YJ"" />
      <xs:enumeration value=""YK"" />
      <xs:enumeration value=""YL"" />
      <xs:enumeration value=""YM"" />
      <xs:enumeration value=""YN"" />
      <xs:enumeration value=""YP"" />
      <xs:enumeration value=""YQ"" />
      <xs:enumeration value=""YR"" />
      <xs:enumeration value=""YS"" />
      <xs:enumeration value=""YT"" />
      <xs:enumeration value=""YW"" />
      <xs:enumeration value=""YX"" />
      <xs:enumeration value=""YY"" />
      <xs:enumeration value=""Z1"" />
      <xs:enumeration value=""Z2"" />
      <xs:enumeration value=""Z3"" />
      <xs:enumeration value=""Z4"" />
      <xs:enumeration value=""Z6"" />
      <xs:enumeration value=""ZA"" />
      <xs:enumeration value=""ZB"" />
      <xs:enumeration value=""ZC"" />
      <xs:enumeration value=""ZD"" />
      <xs:enumeration value=""ZE"" />
      <xs:enumeration value=""ZF"" />
      <xs:enumeration value=""ZG"" />
      <xs:enumeration value=""ZH"" />
      <xs:enumeration value=""ZI"" />
      <xs:enumeration value=""ZJ"" />
      <xs:enumeration value=""ZK"" />
      <xs:enumeration value=""ZL"" />
      <xs:enumeration value=""ZM"" />
      <xs:enumeration value=""ZN"" />
      <xs:enumeration value=""ZO"" />
      <xs:enumeration value=""ZP"" />
      <xs:enumeration value=""ZR"" />
      <xs:enumeration value=""ZS"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""X12_ID_737"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""9L"" />
      <xs:enumeration value=""AA"" />
      <xs:enumeration value=""AB"" />
      <xs:enumeration value=""AC"" />
      <xs:enumeration value=""AE"" />
      <xs:enumeration value=""AF"" />
      <xs:enumeration value=""AG"" />
      <xs:enumeration value=""AH"" />
      <xs:enumeration value=""AI"" />
      <xs:enumeration value=""AJ"" />
      <xs:enumeration value=""AK"" />
      <xs:enumeration value=""AM"" />
      <xs:enumeration value=""AN"" />
      <xs:enumeration value=""AO"" />
      <xs:enumeration value=""AP"" />
      <xs:enumeration value=""AQ"" />
      <xs:enumeration value=""AR"" />
      <xs:enumeration value=""AV"" />
      <xs:enumeration value=""BA"" />
      <xs:enumeration value=""BB"" />
      <xs:enumeration value=""BC"" />
      <xs:enumeration value=""BD"" />
      <xs:enumeration value=""BL"" />
      <xs:enumeration value=""BM"" />
      <xs:enumeration value=""BN"" />
      <xs:enumeration value=""BO"" />
      <xs:enumeration value=""BP"" />
      <xs:enumeration value=""BR"" />
      <xs:enumeration value=""BT"" />
      <xs:enumeration value=""BZ"" />
      <xs:enumeration value=""C1"" />
      <xs:enumeration value=""CA"" />
      <xs:enumeration value=""CB"" />
      <xs:enumeration value=""CC"" />
      <xs:enumeration value=""CF"" />
      <xs:enumeration value=""CG"" />
      <xs:enumeration value=""CH"" />
      <xs:enumeration value=""CJ"" />
      <xs:enumeration value=""CK"" />
      <xs:enumeration value=""CL"" />
      <xs:enumeration value=""CM"" />
      <xs:enumeration value=""CN"" />
      <xs:enumeration value=""CO"" />
      <xs:enumeration value=""CP"" />
      <xs:enumeration value=""CQ"" />
      <xs:enumeration value=""CS"" />
      <xs:enumeration value=""CT"" />
      <xs:enumeration value=""CU"" />
      <xs:enumeration value=""CV"" />
      <xs:enumeration value=""CW"" />
      <xs:enumeration value=""CY"" />
      <xs:enumeration value=""DE"" />
      <xs:enumeration value=""DN"" />
      <xs:enumeration value=""DT"" />
      <xs:enumeration value=""EA"" />
      <xs:enumeration value=""EE"" />
      <xs:enumeration value=""EF"" />
      <xs:enumeration value=""EL"" />
      <xs:enumeration value=""EN"" />
      <xs:enumeration value=""FC"" />
      <xs:enumeration value=""FD"" />
      <xs:enumeration value=""FH"" />
      <xs:enumeration value=""FJ"" />
      <xs:enumeration value=""FV"" />
      <xs:enumeration value=""FZ"" />
      <xs:enumeration value=""GC"" />
      <xs:enumeration value=""GL"" />
      <xs:enumeration value=""GO"" />
      <xs:enumeration value=""GP"" />
      <xs:enumeration value=""HC"" />
      <xs:enumeration value=""HR"" />
      <xs:enumeration value=""ID"" />
      <xs:enumeration value=""IN"" />
      <xs:enumeration value=""IR"" />
      <xs:enumeration value=""LC"" />
      <xs:enumeration value=""LD"" />
      <xs:enumeration value=""LG"" />
      <xs:enumeration value=""LL"" />
      <xs:enumeration value=""LM"" />
      <xs:enumeration value=""LP"" />
      <xs:enumeration value=""LS"" />
      <xs:enumeration value=""LT"" />
      <xs:enumeration value=""MP"" />
      <xs:enumeration value=""MR"" />
      <xs:enumeration value=""NC"" />
      <xs:enumeration value=""NE"" />
      <xs:enumeration value=""NX"" />
      <xs:enumeration value=""OD"" />
      <xs:enumeration value=""OG"" />
      <xs:enumeration value=""OL"" />
      <xs:enumeration value=""OP"" />
      <xs:enumeration value=""P1"" />
      <xs:enumeration value=""PA"" />
      <xs:enumeration value=""PB"" />
      <xs:enumeration value=""PC"" />
      <xs:enumeration value=""PD"" />
      <xs:enumeration value=""PI"" />
      <xs:enumeration value=""PJ"" />
      <xs:enumeration value=""PK"" />
      <xs:enumeration value=""PL"" />
      <xs:enumeration value=""PM"" />
      <xs:enumeration value=""PO"" />
      <xs:enumeration value=""PR"" />
      <xs:enumeration value=""PS"" />
      <xs:enumeration value=""PT"" />
      <xs:enumeration value=""PU"" />
      <xs:enumeration value=""PY"" />
      <xs:enumeration value=""QR"" />
      <xs:enumeration value=""QV"" />
      <xs:enumeration value=""R1"" />
      <xs:enumeration value=""R2"" />
      <xs:enumeration value=""RA"" />
      <xs:enumeration value=""RG"" />
      <xs:enumeration value=""RL"" />
      <xs:enumeration value=""RN"" />
      <xs:enumeration value=""RO"" />
      <xs:enumeration value=""RP"" />
      <xs:enumeration value=""RQ"" />
      <xs:enumeration value=""RS"" />
      <xs:enumeration value=""RT"" />
      <xs:enumeration value=""SA"" />
      <xs:enumeration value=""SB"" />
      <xs:enumeration value=""SC"" />
      <xs:enumeration value=""SD"" />
      <xs:enumeration value=""SE"" />
      <xs:enumeration value=""SF"" />
      <xs:enumeration value=""SH"" />
      <xs:enumeration value=""SJ"" />
      <xs:enumeration value=""SK"" />
      <xs:enumeration value=""SL"" />
      <xs:enumeration value=""SM"" />
      <xs:enumeration value=""SP"" />
      <xs:enumeration value=""SR"" />
      <xs:enumeration value=""ST"" />
      <xs:enumeration value=""SU"" />
      <xs:enumeration value=""SZ"" />
      <xs:enumeration value=""TA"" />
      <xs:enumeration value=""TD"" />
      <xs:enumeration value=""TE"" />
      <xs:enumeration value=""TI"" />
      <xs:enumeration value=""TL"" />
      <xs:enumeration value=""TO"" />
      <xs:enumeration value=""TP"" />
      <xs:enumeration value=""TR"" />
      <xs:enumeration value=""TS"" />
      <xs:enumeration value=""TT"" />
      <xs:enumeration value=""VT"" />
      <xs:enumeration value=""WA"" />
      <xs:enumeration value=""WR"" />
      <xs:enumeration value=""WT"" />
      <xs:enumeration value=""ZA"" />
      <xs:enumeration value=""ZP"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""X12_ID_738"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""1"" />
      <xs:enumeration value=""10"" />
      <xs:enumeration value=""11"" />
      <xs:enumeration value=""12"" />
      <xs:enumeration value=""13"" />
      <xs:enumeration value=""14"" />
      <xs:enumeration value=""15"" />
      <xs:enumeration value=""16"" />
      <xs:enumeration value=""18"" />
      <xs:enumeration value=""19"" />
      <xs:enumeration value=""1F"" />
      <xs:enumeration value=""2"" />
      <xs:enumeration value=""20"" />
      <xs:enumeration value=""21"" />
      <xs:enumeration value=""22"" />
      <xs:enumeration value=""23"" />
      <xs:enumeration value=""24"" />
      <xs:enumeration value=""25"" />
      <xs:enumeration value=""26"" />
      <xs:enumeration value=""27"" />
      <xs:enumeration value=""28"" />
      <xs:enumeration value=""29"" />
      <xs:enumeration value=""2F"" />
      <xs:enumeration value=""3"" />
      <xs:enumeration value=""30"" />
      <xs:enumeration value=""31"" />
      <xs:enumeration value=""32"" />
      <xs:enumeration value=""33"" />
      <xs:enumeration value=""34"" />
      <xs:enumeration value=""35"" />
      <xs:enumeration value=""36"" />
      <xs:enumeration value=""37"" />
      <xs:enumeration value=""38"" />
      <xs:enumeration value=""39"" />
      <xs:enumeration value=""3A"" />
      <xs:enumeration value=""3B"" />
      <xs:enumeration value=""3C"" />
      <xs:enumeration value=""3D"" />
      <xs:enumeration value=""3E"" />
      <xs:enumeration value=""3F"" />
      <xs:enumeration value=""3G"" />
      <xs:enumeration value=""3H"" />
      <xs:enumeration value=""3I"" />
      <xs:enumeration value=""3J"" />
      <xs:enumeration value=""4"" />
      <xs:enumeration value=""40"" />
      <xs:enumeration value=""41"" />
      <xs:enumeration value=""42"" />
      <xs:enumeration value=""43"" />
      <xs:enumeration value=""44"" />
      <xs:enumeration value=""4F"" />
      <xs:enumeration value=""5"" />
      <xs:enumeration value=""5F"" />
      <xs:enumeration value=""6"" />
      <xs:enumeration value=""6F"" />
      <xs:enumeration value=""7"" />
      <xs:enumeration value=""8"" />
      <xs:enumeration value=""8F"" />
      <xs:enumeration value=""A"" />
      <xs:enumeration value=""A1"" />
      <xs:enumeration value=""A2"" />
      <xs:enumeration value=""A3"" />
      <xs:enumeration value=""A4"" />
      <xs:enumeration value=""A5"" />
      <xs:enumeration value=""A6"" />
      <xs:enumeration value=""A7"" />
      <xs:enumeration value=""A9"" />
      <xs:enumeration value=""AA"" />
      <xs:enumeration value=""AAP"" />
      <xs:enumeration value=""AB"" />
      <xs:enumeration value=""ABO"" />
      <xs:enumeration value=""ABR"" />
      <xs:enumeration value=""ABS"" />
      <xs:enumeration value=""AC"" />
      <xs:enumeration value=""ACN"" />
      <xs:enumeration value=""AD"" />
      <xs:enumeration value=""ADH"" />
      <xs:enumeration value=""ADM"" />
      <xs:enumeration value=""AE"" />
      <xs:enumeration value=""AF"" />
      <xs:enumeration value=""AG"" />
      <xs:enumeration value=""AGE"" />
      <xs:enumeration value=""AGI"" />
      <xs:enumeration value=""AH"" />
      <xs:enumeration value=""AI"" />
      <xs:enumeration value=""AJ"" />
      <xs:enumeration value=""AK"" />
      <xs:enumeration value=""AL"" />
      <xs:enumeration value=""ALK"" />
      <xs:enumeration value=""ALN"" />
      <xs:enumeration value=""ALP"" />
      <xs:enumeration value=""AM"" />
      <xs:enumeration value=""AMI"" />
      <xs:enumeration value=""AMW"" />
      <xs:enumeration value=""AN"" />
      <xs:enumeration value=""AOX"" />
      <xs:enumeration value=""AP"" />
      <xs:enumeration value=""API"" />
      <xs:enumeration value=""APP"" />
      <xs:enumeration value=""AS"" />
      <xs:enumeration value=""ASH"" />
      <xs:enumeration value=""ASY"" />
      <xs:enumeration value=""AT"" />
      <xs:enumeration value=""AU"" />
      <xs:enumeration value=""AV"" />
      <xs:enumeration value=""AVT"" />
      <xs:enumeration value=""AW"" />
      <xs:enumeration value=""AX"" />
      <xs:enumeration value=""AY"" />
      <xs:enumeration value=""AZ"" />
      <xs:enumeration value=""B"" />
      <xs:enumeration value=""B1"" />
      <xs:enumeration value=""B2"" />
      <xs:enumeration value=""B3"" />
      <xs:enumeration value=""B4"" />
      <xs:enumeration value=""B5"" />
      <xs:enumeration value=""B6"" />
      <xs:enumeration value=""BA"" />
      <xs:enumeration value=""BB"" />
      <xs:enumeration value=""BC"" />
      <xs:enumeration value=""BD"" />
      <xs:enumeration value=""BDP"" />
      <xs:enumeration value=""BE"" />
      <xs:enumeration value=""BF"" />
      <xs:enumeration value=""BG"" />
      <xs:enumeration value=""BH"" />
      <xs:enumeration value=""BHF"" />
      <xs:enumeration value=""BHS"" />
      <xs:enumeration value=""BIC"" />
      <xs:enumeration value=""BJ"" />
      <xs:enumeration value=""BK"" />
      <xs:enumeration value=""BL"" />
      <xs:enumeration value=""BN"" />
      <xs:enumeration value=""BND"" />
      <xs:enumeration value=""BO"" />
      <xs:enumeration value=""BOR"" />
      <xs:enumeration value=""BP"" />
      <xs:enumeration value=""BQ"" />
      <xs:enumeration value=""BR"" />
      <xs:enumeration value=""BRS"" />
      <xs:enumeration value=""BSW"" />
      <xs:enumeration value=""BT"" />
      <xs:enumeration value=""BU"" />
      <xs:enumeration value=""BUD"" />
      <xs:enumeration value=""BW"" />
      <xs:enumeration value=""BX"" />
      <xs:enumeration value=""C"" />
      <xs:enumeration value=""C0"" />
      <xs:enumeration value=""C1"" />
      <xs:enumeration value=""C2"" />
      <xs:enumeration value=""C3"" />
      <xs:enumeration value=""C4"" />
      <xs:enumeration value=""CA"" />
      <xs:enumeration value=""CAU"" />
      <xs:enumeration value=""CC"" />
      <xs:enumeration value=""CCF"" />
      <xs:enumeration value=""CCG"" />
      <xs:enumeration value=""CD"" />
      <xs:enumeration value=""CE"" />
      <xs:enumeration value=""CF"" />
      <xs:enumeration value=""CG"" />
      <xs:enumeration value=""CGR"" />
      <xs:enumeration value=""CH"" />
      <xs:enumeration value=""CHA"" />
      <xs:enumeration value=""CHC"" />
      <xs:enumeration value=""CHG"" />
      <xs:enumeration value=""CHL"" />
      <xs:enumeration value=""CI"" />
      <xs:enumeration value=""CIV"" />
      <xs:enumeration value=""CJ"" />
      <xs:enumeration value=""CK"" />
      <xs:enumeration value=""CL"" />
      <xs:enumeration value=""CLA"" />
      <xs:enumeration value=""CLB"" />
      <xs:enumeration value=""CLN"" />
      <xs:enumeration value=""CM"" />
      <xs:enumeration value=""CN"" />
      <xs:enumeration value=""CO"" />
      <xs:enumeration value=""COH"" />
      <xs:enumeration value=""COL"" />
      <xs:enumeration value=""CON"" />
      <xs:enumeration value=""COR"" />
      <xs:enumeration value=""COS"" />
      <xs:enumeration value=""COT"" />
      <xs:enumeration value=""CP"" />
      <xs:enumeration value=""CPF"" />
      <xs:enumeration value=""CPS"" />
      <xs:enumeration value=""CQ"" />
      <xs:enumeration value=""CR"" />
      <xs:enumeration value=""CRF"" />
      <xs:enumeration value=""CRL"" />
      <xs:enumeration value=""CRN"" />
      <xs:enumeration value=""CRT"" />
      <xs:enumeration value=""CS"" />
      <xs:enumeration value=""CSC"" />
      <xs:enumeration value=""CSR"" />
      <xs:enumeration value=""CST"" />
      <xs:enumeration value=""CT"" />
      <xs:enumeration value=""CTG"" />
      <xs:enumeration value=""CTT"" />
      <xs:enumeration value=""CU"" />
      <xs:enumeration value=""CUT"" />
      <xs:enumeration value=""CW"" />
      <xs:enumeration value=""CWT"" />
      <xs:enumeration value=""CX"" />
      <xs:enumeration value=""CY"" />
      <xs:enumeration value=""CYB"" />
      <xs:enumeration value=""D"" />
      <xs:enumeration value=""D1"" />
      <xs:enumeration value=""D2"" />
      <xs:enumeration value=""D3"" />
      <xs:enumeration value=""D4"" />
      <xs:enumeration value=""D5"" />
      <xs:enumeration value=""D7"" />
      <xs:enumeration value=""DA"" />
      <xs:enumeration value=""DAT"" />
      <xs:enumeration value=""DB"" />
      <xs:enumeration value=""DC"" />
      <xs:enumeration value=""DCT"" />
      <xs:enumeration value=""DD"" />
      <xs:enumeration value=""DE"" />
      <xs:enumeration value=""DEM"" />
      <xs:enumeration value=""DF"" />
      <xs:enumeration value=""DG"" />
      <xs:enumeration value=""DH"" />
      <xs:enumeration value=""DI"" />
      <xs:enumeration value=""DIR"" />
      <xs:enumeration value=""DIS"" />
      <xs:enumeration value=""DJ"" />
      <xs:enumeration value=""DL"" />
      <xs:enumeration value=""DM"" />
      <xs:enumeration value=""DME"" />
      <xs:enumeration value=""DMF"" />
      <xs:enumeration value=""DN"" />
      <xs:enumeration value=""DP"" />
      <xs:enumeration value=""DPM"" />
      <xs:enumeration value=""DR"" />
      <xs:enumeration value=""DRY"" />
      <xs:enumeration value=""DS"" />
      <xs:enumeration value=""DT"" />
      <xs:enumeration value=""DU"" />
      <xs:enumeration value=""DW"" />
      <xs:enumeration value=""DWP"" />
      <xs:enumeration value=""DY"" />
      <xs:enumeration value=""E"" />
      <xs:enumeration value=""E0"" />
      <xs:enumeration value=""E1"" />
      <xs:enumeration value=""EA"" />
      <xs:enumeration value=""EB"" />
      <xs:enumeration value=""EC"" />
      <xs:enumeration value=""ED"" />
      <xs:enumeration value=""EE"" />
      <xs:enumeration value=""EF"" />
      <xs:enumeration value=""EG"" />
      <xs:enumeration value=""EH"" />
      <xs:enumeration value=""EI"" />
      <xs:enumeration value=""EJ"" />
      <xs:enumeration value=""EL"" />
      <xs:enumeration value=""ELC"" />
      <xs:enumeration value=""ELE"" />
      <xs:enumeration value=""ELI"" />
      <xs:enumeration value=""ELL"" />
      <xs:enumeration value=""ELO"" />
      <xs:enumeration value=""ELP"" />
      <xs:enumeration value=""ELS"" />
      <xs:enumeration value=""ELT"" />
      <xs:enumeration value=""ELV"" />
      <xs:enumeration value=""ELW"" />
      <xs:enumeration value=""ELX"" />
      <xs:enumeration value=""EM"" />
      <xs:enumeration value=""EN"" />
      <xs:enumeration value=""EP"" />
      <xs:enumeration value=""EPL"" />
      <xs:enumeration value=""ES"" />
      <xs:enumeration value=""EVL"" />
      <xs:enumeration value=""EVR"" />
      <xs:enumeration value=""EW"" />
      <xs:enumeration value=""EX"" />
      <xs:enumeration value=""EXH"" />
      <xs:enumeration value=""EXT"" />
      <xs:enumeration value=""F"" />
      <xs:enumeration value=""F1"" />
      <xs:enumeration value=""F2"" />
      <xs:enumeration value=""F3"" />
      <xs:enumeration value=""F4"" />
      <xs:enumeration value=""F5"" />
      <xs:enumeration value=""F6"" />
      <xs:enumeration value=""F7"" />
      <xs:enumeration value=""F8"" />
      <xs:enumeration value=""F9"" />
      <xs:enumeration value=""FA"" />
      <xs:enumeration value=""FB"" />
      <xs:enumeration value=""FBP"" />
      <xs:enumeration value=""FC"" />
      <xs:enumeration value=""FD"" />
      <xs:enumeration value=""FE"" />
      <xs:enumeration value=""FF"" />
      <xs:enumeration value=""FG"" />
      <xs:enumeration value=""FH"" />
      <xs:enumeration value=""FI"" />
      <xs:enumeration value=""FIL"" />
      <xs:enumeration value=""FIN"" />
      <xs:enumeration value=""FIT"" />
      <xs:enumeration value=""FJ"" />
      <xs:enumeration value=""FK"" />
      <xs:enumeration value=""FL"" />
      <xs:enumeration value=""FLD"" />
      <xs:enumeration value=""FLN"" />
      <xs:enumeration value=""FLP"" />
      <xs:enumeration value=""FLV"" />
      <xs:enumeration value=""FML"" />
      <xs:enumeration value=""FMZ"" />
      <xs:enumeration value=""FN"" />
      <xs:enumeration value=""FNL"" />
      <xs:enumeration value=""FNS"" />
      <xs:enumeration value=""FOA"" />
      <xs:enumeration value=""FOH"" />
      <xs:enumeration value=""FOI"" />
      <xs:enumeration value=""FOR"" />
      <xs:enumeration value=""FP"" />
      <xs:enumeration value=""FPV"" />
      <xs:enumeration value=""FQ"" />
      <xs:enumeration value=""FR"" />
      <xs:enumeration value=""FS"" />
      <xs:enumeration value=""FSI"" />
      <xs:enumeration value=""FT"" />
      <xs:enumeration value=""FU"" />
      <xs:enumeration value=""FUD"" />
      <xs:enumeration value=""FV"" />
      <xs:enumeration value=""FW"" />
      <xs:enumeration value=""FX"" />
      <xs:enumeration value=""FY"" />
      <xs:enumeration value=""FZ"" />
      <xs:enumeration value=""G"" />
      <xs:enumeration value=""G1"" />
      <xs:enumeration value=""G2"" />
      <xs:enumeration value=""G3"" />
      <xs:enumeration value=""G4"" />
      <xs:enumeration value=""GA"" />
      <xs:enumeration value=""GB"" />
      <xs:enumeration value=""GC"" />
      <xs:enumeration value=""GD"" />
      <xs:enumeration value=""GE"" />
      <xs:enumeration value=""GEL"" />
      <xs:enumeration value=""GF"" />
      <xs:enumeration value=""GG"" />
      <xs:enumeration value=""GGR"" />
      <xs:enumeration value=""GH"" />
      <xs:enumeration value=""GI"" />
      <xs:enumeration value=""GIR"" />
      <xs:enumeration value=""GJ"" />
      <xs:enumeration value=""GK"" />
      <xs:enumeration value=""GL"" />
      <xs:enumeration value=""GLE"" />
      <xs:enumeration value=""GM"" />
      <xs:enumeration value=""GN"" />
      <xs:enumeration value=""GO"" />
      <xs:enumeration value=""GOR"" />
      <xs:enumeration value=""GP"" />
      <xs:enumeration value=""GQ"" />
      <xs:enumeration value=""GR"" />
      <xs:enumeration value=""GRA"" />
      <xs:enumeration value=""GRI"" />
      <xs:enumeration value=""GS"" />
      <xs:enumeration value=""GT"" />
      <xs:enumeration value=""GW"" />
      <xs:enumeration value=""H1"" />
      <xs:enumeration value=""H2O"" />
      <xs:enumeration value=""H8"" />
      <xs:enumeration value=""H9"" />
      <xs:enumeration value=""HA"" />
      <xs:enumeration value=""HAR"" />
      <xs:enumeration value=""HAZ"" />
      <xs:enumeration value=""HB"" />
      <xs:enumeration value=""HC"" />
      <xs:enumeration value=""HCG"" />
      <xs:enumeration value=""HD"" />
      <xs:enumeration value=""HE"" />
      <xs:enumeration value=""HF"" />
      <xs:enumeration value=""HG"" />
      <xs:enumeration value=""HH"" />
      <xs:enumeration value=""HHW"" />
      <xs:enumeration value=""HI"" />
      <xs:enumeration value=""HIB"" />
      <xs:enumeration value=""HJ"" />
      <xs:enumeration value=""HK"" />
      <xs:enumeration value=""HL"" />
      <xs:enumeration value=""HM"" />
      <xs:enumeration value=""HO"" />
      <xs:enumeration value=""HOC"" />
      <xs:enumeration value=""HP"" />
      <xs:enumeration value=""HR"" />
      <xs:enumeration value=""HT"" />
      <xs:enumeration value=""HTE"" />
      <xs:enumeration value=""HVM"" />
      <xs:enumeration value=""HWS"" />
      <xs:enumeration value=""HYD"" />
      <xs:enumeration value=""HZ"" />
      <xs:enumeration value=""HZC"" />
      <xs:enumeration value=""I"" />
      <xs:enumeration value=""IA"" />
      <xs:enumeration value=""IB"" />
      <xs:enumeration value=""IC"" />
      <xs:enumeration value=""ID"" />
      <xs:enumeration value=""IDE"" />
      <xs:enumeration value=""IE"" />
      <xs:enumeration value=""IF"" />
      <xs:enumeration value=""IG"" />
      <xs:enumeration value=""IGA"" />
      <xs:enumeration value=""IGR"" />
      <xs:enumeration value=""IH"" />
      <xs:enumeration value=""IHV"" />
      <xs:enumeration value=""II"" />
      <xs:enumeration value=""IJ"" />
      <xs:enumeration value=""IK"" />
      <xs:enumeration value=""IL"" />
      <xs:enumeration value=""IM"" />
      <xs:enumeration value=""IMP"" />
      <xs:enumeration value=""IN"" />
      <xs:enumeration value=""IND"" />
      <xs:enumeration value=""INS"" />
      <xs:enumeration value=""IO"" />
      <xs:enumeration value=""IP"" />
      <xs:enumeration value=""IPI"" />
      <xs:enumeration value=""IQ"" />
      <xs:enumeration value=""IR"" />
      <xs:enumeration value=""IRA"" />
      <xs:enumeration value=""IS"" />
      <xs:enumeration value=""IT"" />
      <xs:enumeration value=""IU"" />
      <xs:enumeration value=""IV"" />
      <xs:enumeration value=""IW"" />
      <xs:enumeration value=""IX"" />
      <xs:enumeration value=""IY"" />
      <xs:enumeration value=""IZ"" />
      <xs:enumeration value=""JA"" />
      <xs:enumeration value=""JOM"" />
      <xs:enumeration value=""KA"" />
      <xs:enumeration value=""KB"" />
      <xs:enumeration value=""KN"" />
      <xs:enumeration value=""L"" />
      <xs:enumeration value=""L0"" />
      <xs:enumeration value=""L1"" />
      <xs:enumeration value=""LA"" />
      <xs:enumeration value=""LAI"" />
      <xs:enumeration value=""LB"" />
      <xs:enumeration value=""LC"" />
      <xs:enumeration value=""LC5"" />
      <xs:enumeration value=""LCG"" />
      <xs:enumeration value=""LD"" />
      <xs:enumeration value=""LD5"" />
      <xs:enumeration value=""LDH"" />
      <xs:enumeration value=""LE"" />
      <xs:enumeration value=""LEF"" />
      <xs:enumeration value=""LF"" />
      <xs:enumeration value=""LG"" />
      <xs:enumeration value=""LIR"" />
      <xs:enumeration value=""LIV"" />
      <xs:enumeration value=""LL"" />
      <xs:enumeration value=""LLD"" />
      <xs:enumeration value=""LM"" />
      <xs:enumeration value=""LN"" />
      <xs:enumeration value=""LO"" />
      <xs:enumeration value=""LOI"" />
      <xs:enumeration value=""LOS"" />
      <xs:enumeration value=""LOW"" />
      <xs:enumeration value=""LP"" />
      <xs:enumeration value=""LPG"" />
      <xs:enumeration value=""LPL"" />
      <xs:enumeration value=""LPR"" />
      <xs:enumeration value=""LS"" />
      <xs:enumeration value=""LSK"" />
      <xs:enumeration value=""LSS"" />
      <xs:enumeration value=""LT"" />
      <xs:enumeration value=""LTD"" />
      <xs:enumeration value=""LW"" />
      <xs:enumeration value=""M"" />
      <xs:enumeration value=""M1"" />
      <xs:enumeration value=""M2"" />
      <xs:enumeration value=""M3"" />
      <xs:enumeration value=""M4"" />
      <xs:enumeration value=""M5"" />
      <xs:enumeration value=""M6"" />
      <xs:enumeration value=""MA"" />
      <xs:enumeration value=""MAT"" />
      <xs:enumeration value=""MB"" />
      <xs:enumeration value=""MC"" />
      <xs:enumeration value=""MCN"" />
      <xs:enumeration value=""MD"" />
      <xs:enumeration value=""ME"" />
      <xs:enumeration value=""MEF"" />
      <xs:enumeration value=""MEL"" />
      <xs:enumeration value=""MER"" />
      <xs:enumeration value=""MF"" />
      <xs:enumeration value=""MG"" />
      <xs:enumeration value=""MH"" />
      <xs:enumeration value=""MHI"" />
      <xs:enumeration value=""MI"" />
      <xs:enumeration value=""MIC"" />
      <xs:enumeration value=""MJ"" />
      <xs:enumeration value=""MK"" />
      <xs:enumeration value=""MM"" />
      <xs:enumeration value=""MN"" />
      <xs:enumeration value=""MO"" />
      <xs:enumeration value=""MOI"" />
      <xs:enumeration value=""MOR"" />
      <xs:enumeration value=""MP"" />
      <xs:enumeration value=""MPR"" />
      <xs:enumeration value=""MQ"" />
      <xs:enumeration value=""MR"" />
      <xs:enumeration value=""MS"" />
      <xs:enumeration value=""MT"" />
      <xs:enumeration value=""MTD"" />
      <xs:enumeration value=""MU"" />
      <xs:enumeration value=""MUL"" />
      <xs:enumeration value=""MV"" />
      <xs:enumeration value=""MW"" />
      <xs:enumeration value=""MX"" />
      <xs:enumeration value=""MY"" />
      <xs:enumeration value=""N"" />
      <xs:enumeration value=""NA"" />
      <xs:enumeration value=""NB"" />
      <xs:enumeration value=""NC"" />
      <xs:enumeration value=""ND"" />
      <xs:enumeration value=""NEU"" />
      <xs:enumeration value=""NF"" />
      <xs:enumeration value=""NG"" />
      <xs:enumeration value=""NH"" />
      <xs:enumeration value=""NI"" />
      <xs:enumeration value=""NIL"" />
      <xs:enumeration value=""NJ"" />
      <xs:enumeration value=""NK"" />
      <xs:enumeration value=""NL"" />
      <xs:enumeration value=""NM"" />
      <xs:enumeration value=""NNW"" />
      <xs:enumeration value=""NO"" />
      <xs:enumeration value=""NOC"" />
      <xs:enumeration value=""NON"" />
      <xs:enumeration value=""NOR"" />
      <xs:enumeration value=""NOX"" />
      <xs:enumeration value=""NP"" />
      <xs:enumeration value=""NS"" />
      <xs:enumeration value=""NU"" />
      <xs:enumeration value=""NV"" />
      <xs:enumeration value=""O"" />
      <xs:enumeration value=""O1"" />
      <xs:enumeration value=""OA"" />
      <xs:enumeration value=""OAP"" />
      <xs:enumeration value=""OB"" />
      <xs:enumeration value=""OBT"" />
      <xs:enumeration value=""OC"" />
      <xs:enumeration value=""OCG"" />
      <xs:enumeration value=""OCR"" />
      <xs:enumeration value=""OD"" />
      <xs:enumeration value=""ODR"" />
      <xs:enumeration value=""OE"" />
      <xs:enumeration value=""OF"" />
      <xs:enumeration value=""OG"" />
      <xs:enumeration value=""OH"" />
      <xs:enumeration value=""OI"" />
      <xs:enumeration value=""OIL"" />
      <xs:enumeration value=""OJ"" />
      <xs:enumeration value=""OK"" />
      <xs:enumeration value=""OL"" />
      <xs:enumeration value=""OLE"" />
      <xs:enumeration value=""OM"" />
      <xs:enumeration value=""ON"" />
      <xs:enumeration value=""OO"" />
      <xs:enumeration value=""OP"" />
      <xs:enumeration value=""OQ"" />
      <xs:enumeration value=""OR"" />
      <xs:enumeration value=""ORC"" />
      <xs:enumeration value=""OS"" />
      <xs:enumeration value=""OT"" />
      <xs:enumeration value=""OTE"" />
      <xs:enumeration value=""OTH"" />
      <xs:enumeration value=""OTT"" />
      <xs:enumeration value=""OV"" />
      <xs:enumeration value=""OW"" />
      <xs:enumeration value=""OX"" />
      <xs:enumeration value=""OXI"" />
      <xs:enumeration value=""OXS"" />
      <xs:enumeration value=""OY"" />
      <xs:enumeration value=""P1"" />
      <xs:enumeration value=""PA"" />
      <xs:enumeration value=""PAR"" />
      <xs:enumeration value=""PB"" />
      <xs:enumeration value=""PBD"" />
      <xs:enumeration value=""PC"" />
      <xs:enumeration value=""PD"" />
      <xs:enumeration value=""PDE"" />
      <xs:enumeration value=""PDG"" />
      <xs:enumeration value=""PE"" />
      <xs:enumeration value=""PER"" />
      <xs:enumeration value=""PF"" />
      <xs:enumeration value=""PFO"" />
      <xs:enumeration value=""PG"" />
      <xs:enumeration value=""PH"" />
      <xs:enumeration value=""PHA"" />
      <xs:enumeration value=""PHW"" />
      <xs:enumeration value=""PI"" />
      <xs:enumeration value=""PIC"" />
      <xs:enumeration value=""PJ"" />
      <xs:enumeration value=""PK"" />
      <xs:enumeration value=""PL"" />
      <xs:enumeration value=""PM"" />
      <xs:enumeration value=""PN"" />
      <xs:enumeration value=""PO"" />
      <xs:enumeration value=""POC"" />
      <xs:enumeration value=""POD"" />
      <xs:enumeration value=""POP"" />
      <xs:enumeration value=""PP"" />
      <xs:enumeration value=""PPS"" />
      <xs:enumeration value=""PQ"" />
      <xs:enumeration value=""PR"" />
      <xs:enumeration value=""PRE"" />
      <xs:enumeration value=""PRF"" />
      <xs:enumeration value=""PRI"" />
      <xs:enumeration value=""PRL"" />
      <xs:enumeration value=""PRO"" />
      <xs:enumeration value=""PRQ"" />
      <xs:enumeration value=""PRY"" />
      <xs:enumeration value=""PS"" />
      <xs:enumeration value=""PSA"" />
      <xs:enumeration value=""PSP"" />
      <xs:enumeration value=""PSW"" />
      <xs:enumeration value=""PT"" />
      <xs:enumeration value=""PU"" />
      <xs:enumeration value=""PV"" />
      <xs:enumeration value=""PW"" />
      <xs:enumeration value=""PWA"" />
      <xs:enumeration value=""PWE"" />
      <xs:enumeration value=""PWF"" />
      <xs:enumeration value=""PX"" />
      <xs:enumeration value=""PY"" />
      <xs:enumeration value=""PZ"" />
      <xs:enumeration value=""Q"" />
      <xs:enumeration value=""QA"" />
      <xs:enumeration value=""QB"" />
      <xs:enumeration value=""QC"" />
      <xs:enumeration value=""QD"" />
      <xs:enumeration value=""QE"" />
      <xs:enumeration value=""QF"" />
      <xs:enumeration value=""QL"" />
      <xs:enumeration value=""QUR"" />
      <xs:enumeration value=""R"" />
      <xs:enumeration value=""R1"" />
      <xs:enumeration value=""R10"" />
      <xs:enumeration value=""R18"" />
      <xs:enumeration value=""R2"" />
      <xs:enumeration value=""R3"" />
      <xs:enumeration value=""R4"" />
      <xs:enumeration value=""R7"" />
      <xs:enumeration value=""R8"" />
      <xs:enumeration value=""RA"" />
      <xs:enumeration value=""RAD"" />
      <xs:enumeration value=""RAF"" />
      <xs:enumeration value=""RB"" />
      <xs:enumeration value=""RC"" />
      <xs:enumeration value=""RD"" />
      <xs:enumeration value=""RE"" />
      <xs:enumeration value=""REA"" />
      <xs:enumeration value=""RED"" />
      <xs:enumeration value=""REF"" />
      <xs:enumeration value=""REI"" />
      <xs:enumeration value=""REL"" />
      <xs:enumeration value=""RES"" />
      <xs:enumeration value=""RF"" />
      <xs:enumeration value=""RG"" />
      <xs:enumeration value=""RH"" />
      <xs:enumeration value=""RI"" />
      <xs:enumeration value=""RJ"" />
      <xs:enumeration value=""RK"" />
      <xs:enumeration value=""RL"" />
      <xs:enumeration value=""RM"" />
      <xs:enumeration value=""RN"" />
      <xs:enumeration value=""RO"" />
      <xs:enumeration value=""ROH"" />
      <xs:enumeration value=""ROX"" />
      <xs:enumeration value=""RP"" />
      <xs:enumeration value=""RQ"" />
      <xs:enumeration value=""RR"" />
      <xs:enumeration value=""RS"" />
      <xs:enumeration value=""RSZ"" />
      <xs:enumeration value=""RT"" />
      <xs:enumeration value=""RTB"" />
      <xs:enumeration value=""RU"" />
      <xs:enumeration value=""RUD"" />
      <xs:enumeration value=""RV"" />
      <xs:enumeration value=""RVP"" />
      <xs:enumeration value=""RW"" />
      <xs:enumeration value=""RX"" />
      <xs:enumeration value=""RY"" />
      <xs:enumeration value=""S"" />
      <xs:enumeration value=""S1"" />
      <xs:enumeration value=""S10"" />
      <xs:enumeration value=""S12"" />
      <xs:enumeration value=""S18"" />
      <xs:enumeration value=""S2"" />
      <xs:enumeration value=""S3"" />
      <xs:enumeration value=""S4"" />
      <xs:enumeration value=""S5"" />
      <xs:enumeration value=""S6"" />
      <xs:enumeration value=""S7"" />
      <xs:enumeration value=""S8"" />
      <xs:enumeration value=""S9"" />
      <xs:enumeration value=""SA"" />
      <xs:enumeration value=""SAP"" />
      <xs:enumeration value=""SB"" />
      <xs:enumeration value=""SC"" />
      <xs:enumeration value=""SCH"" />
      <xs:enumeration value=""SD"" />
      <xs:enumeration value=""SE"" />
      <xs:enumeration value=""SEV"" />
      <xs:enumeration value=""SF"" />
      <xs:enumeration value=""SG"" />
      <xs:enumeration value=""SH"" />
      <xs:enumeration value=""SHA"" />
      <xs:enumeration value=""SI"" />
      <xs:enumeration value=""SIL"" />
      <xs:enumeration value=""SJ"" />
      <xs:enumeration value=""SK"" />
      <xs:enumeration value=""SL"" />
      <xs:enumeration value=""SLD"" />
      <xs:enumeration value=""SLI"" />
      <xs:enumeration value=""SM"" />
      <xs:enumeration value=""SMB"" />
      <xs:enumeration value=""SMD"" />
      <xs:enumeration value=""SN"" />
      <xs:enumeration value=""SO"" />
      <xs:enumeration value=""SOD"" />
      <xs:enumeration value=""SOF"" />
      <xs:enumeration value=""SP"" />
      <xs:enumeration value=""SPG"" />
      <xs:enumeration value=""SPR"" />
      <xs:enumeration value=""SQ"" />
      <xs:enumeration value=""SR"" />
      <xs:enumeration value=""SS"" />
      <xs:enumeration value=""ST"" />
      <xs:enumeration value=""STA"" />
      <xs:enumeration value=""STL"" />
      <xs:enumeration value=""STP"" />
      <xs:enumeration value=""SU"" />
      <xs:enumeration value=""SUM"" />
      <xs:enumeration value=""SUR"" />
      <xs:enumeration value=""SUT"" />
      <xs:enumeration value=""SV"" />
      <xs:enumeration value=""SVL"" />
      <xs:enumeration value=""SW"" />
      <xs:enumeration value=""SX"" />
      <xs:enumeration value=""SXX"" />
      <xs:enumeration value=""SY"" />
      <xs:enumeration value=""SZ"" />
      <xs:enumeration value=""T"" />
      <xs:enumeration value=""T1"" />
      <xs:enumeration value=""T2"" />
      <xs:enumeration value=""T3"" />
      <xs:enumeration value=""T4"" />
      <xs:enumeration value=""T5"" />
      <xs:enumeration value=""T50"" />
      <xs:enumeration value=""T90"" />
      <xs:enumeration value=""TA"" />
      <xs:enumeration value=""TAS"" />
      <xs:enumeration value=""TB"" />
      <xs:enumeration value=""TC"" />
      <xs:enumeration value=""TCL"" />
      <xs:enumeration value=""TD"" />
      <xs:enumeration value=""TDP"" />
      <xs:enumeration value=""TE"" />
      <xs:enumeration value=""TEE"" />
      <xs:enumeration value=""TES"" />
      <xs:enumeration value=""TEX"" />
      <xs:enumeration value=""TF"" />
      <xs:enumeration value=""TG"" />
      <xs:enumeration value=""TH"" />
      <xs:enumeration value=""TI"" />
      <xs:enumeration value=""TJ"" />
      <xs:enumeration value=""TK"" />
      <xs:enumeration value=""TL"" />
      <xs:enumeration value=""TM"" />
      <xs:enumeration value=""TN"" />
      <xs:enumeration value=""TO"" />
      <xs:enumeration value=""TOA"" />
      <xs:enumeration value=""TOR"" />
      <xs:enumeration value=""TOX"" />
      <xs:enumeration value=""TP"" />
      <xs:enumeration value=""TPF"" />
      <xs:enumeration value=""TPL"" />
      <xs:enumeration value=""TPQ"" />
      <xs:enumeration value=""TPS"" />
      <xs:enumeration value=""TQ"" />
      <xs:enumeration value=""TR"" />
      <xs:enumeration value=""TRA"" />
      <xs:enumeration value=""TRC"" />
      <xs:enumeration value=""TRD"" />
      <xs:enumeration value=""TRN"" />
      <xs:enumeration value=""TS"" />
      <xs:enumeration value=""TSZ"" />
      <xs:enumeration value=""TT"" />
      <xs:enumeration value=""TTL"" />
      <xs:enumeration value=""TU"" />
      <xs:enumeration value=""TUR"" />
      <xs:enumeration value=""TV"" />
      <xs:enumeration value=""TVD"" />
      <xs:enumeration value=""TW"" />
      <xs:enumeration value=""TWD"" />
      <xs:enumeration value=""TX"" />
      <xs:enumeration value=""TY"" />
      <xs:enumeration value=""U"" />
      <xs:enumeration value=""UA"" />
      <xs:enumeration value=""UCB"" />
      <xs:enumeration value=""UG"" />
      <xs:enumeration value=""UNI"" />
      <xs:enumeration value=""UNK"" />
      <xs:enumeration value=""VAD"" />
      <xs:enumeration value=""VAP"" />
      <xs:enumeration value=""VCG"" />
      <xs:enumeration value=""VH"" />
      <xs:enumeration value=""VIN"" />
      <xs:enumeration value=""VIS"" />
      <xs:enumeration value=""VO"" />
      <xs:enumeration value=""VOC"" />
      <xs:enumeration value=""VOL"" />
      <xs:enumeration value=""VOT"" />
      <xs:enumeration value=""VOV"" />
      <xs:enumeration value=""VOW"" />
      <xs:enumeration value=""VSO"" />
      <xs:enumeration value=""VW"" />
      <xs:enumeration value=""VWT"" />
      <xs:enumeration value=""WA"" />
      <xs:enumeration value=""WB"" />
      <xs:enumeration value=""WC"" />
      <xs:enumeration value=""WD"" />
      <xs:enumeration value=""WDE"" />
      <xs:enumeration value=""WE"" />
      <xs:enumeration value=""WEL"" />
      <xs:enumeration value=""WF"" />
      <xs:enumeration value=""WH"" />
      <xs:enumeration value=""WI"" />
      <xs:enumeration value=""WL"" />
      <xs:enumeration value=""WM"" />
      <xs:enumeration value=""WOD"" />
      <xs:enumeration value=""WPF"" />
      <xs:enumeration value=""WPL"" />
      <xs:enumeration value=""WPS"" />
      <xs:enumeration value=""WR"" />
      <xs:enumeration value=""WRA"" />
      <xs:enumeration value=""WSK"" />
      <xs:enumeration value=""WT"" />
      <xs:enumeration value=""WTB"" />
      <xs:enumeration value=""WU"" />
      <xs:enumeration value=""WX"" />
      <xs:enumeration value=""X"" />
      <xs:enumeration value=""XA"" />
      <xs:enumeration value=""XH"" />
      <xs:enumeration value=""XP"" />
      <xs:enumeration value=""XQ"" />
      <xs:enumeration value=""XZ"" />
      <xs:enumeration value=""YA"" />
      <xs:enumeration value=""YB"" />
      <xs:enumeration value=""YC"" />
      <xs:enumeration value=""YD"" />
      <xs:enumeration value=""ZA"" />
      <xs:enumeration value=""ZAL"" />
      <xs:enumeration value=""ZAS"" />
      <xs:enumeration value=""ZB"" />
      <xs:enumeration value=""ZBI"" />
      <xs:enumeration value=""ZBT"" />
      <xs:enumeration value=""ZBZ"" />
      <xs:enumeration value=""ZC"" />
      <xs:enumeration value=""ZCA"" />
      <xs:enumeration value=""ZCB"" />
      <xs:enumeration value=""ZCD"" />
      <xs:enumeration value=""ZCE"" />
      <xs:enumeration value=""ZCO"" />
      <xs:enumeration value=""ZCR"" />
      <xs:enumeration value=""ZCU"" />
      <xs:enumeration value=""ZD"" />
      <xs:enumeration value=""ZET"" />
      <xs:enumeration value=""ZF"" />
      <xs:enumeration value=""ZFE"" />
      <xs:enumeration value=""ZFL"" />
      <xs:enumeration value=""ZFS"" />
      <xs:enumeration value=""ZG"" />
      <xs:enumeration value=""ZGE"" />
      <xs:enumeration value=""ZH"" />
      <xs:enumeration value=""ZHP"" />
      <xs:enumeration value=""ZHS"" />
      <xs:enumeration value=""ZHX"" />
      <xs:enumeration value=""ZIB"" />
      <xs:enumeration value=""ZIP"" />
      <xs:enumeration value=""ZMG"" />
      <xs:enumeration value=""ZMN"" />
      <xs:enumeration value=""ZMO"" />
      <xs:enumeration value=""ZMT"" />
      <xs:enumeration value=""ZN"" />
      <xs:enumeration value=""ZNB"" />
      <xs:enumeration value=""ZNI"" />
      <xs:enumeration value=""ZNP"" />
      <xs:enumeration value=""ZO"" />
      <xs:enumeration value=""ZOC"" />
      <xs:enumeration value=""ZP"" />
      <xs:enumeration value=""ZPB"" />
      <xs:enumeration value=""ZPP"" />
      <xs:enumeration value=""ZPT"" />
      <xs:enumeration value=""ZR"" />
      <xs:enumeration value=""ZS"" />
      <xs:enumeration value=""ZSB"" />
      <xs:enumeration value=""ZSE"" />
      <xs:enumeration value=""ZSI"" />
      <xs:enumeration value=""ZSN"" />
      <xs:enumeration value=""ZTA"" />
      <xs:enumeration value=""ZTB"" />
      <xs:enumeration value=""ZTE"" />
      <xs:enumeration value=""ZTI"" />
      <xs:enumeration value=""ZV"" />
      <xs:enumeration value=""ZW"" />
      <xs:enumeration value=""ZZN"" />
      <xs:enumeration value=""ZZR"" />
      <xs:enumeration value=""ZZZ"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""X12_ID_935"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""01"" />
      <xs:enumeration value=""02"" />
      <xs:enumeration value=""03"" />
      <xs:enumeration value=""04"" />
      <xs:enumeration value=""05"" />
      <xs:enumeration value=""06"" />
      <xs:enumeration value=""07"" />
      <xs:enumeration value=""08"" />
      <xs:enumeration value=""09"" />
      <xs:enumeration value=""10"" />
      <xs:enumeration value=""11"" />
      <xs:enumeration value=""12"" />
      <xs:enumeration value=""13"" />
      <xs:enumeration value=""14"" />
      <xs:enumeration value=""15"" />
      <xs:enumeration value=""16"" />
      <xs:enumeration value=""17"" />
      <xs:enumeration value=""18"" />
      <xs:enumeration value=""19"" />
      <xs:enumeration value=""20"" />
      <xs:enumeration value=""21"" />
      <xs:enumeration value=""22"" />
      <xs:enumeration value=""23"" />
      <xs:enumeration value=""24"" />
      <xs:enumeration value=""25"" />
      <xs:enumeration value=""26"" />
      <xs:enumeration value=""27"" />
      <xs:enumeration value=""28"" />
      <xs:enumeration value=""29"" />
      <xs:enumeration value=""30"" />
      <xs:enumeration value=""31"" />
      <xs:enumeration value=""32"" />
      <xs:enumeration value=""34"" />
      <xs:enumeration value=""35"" />
      <xs:enumeration value=""36"" />
      <xs:enumeration value=""37"" />
      <xs:enumeration value=""38"" />
      <xs:enumeration value=""39"" />
      <xs:enumeration value=""40"" />
      <xs:enumeration value=""41"" />
      <xs:enumeration value=""42"" />
      <xs:enumeration value=""43"" />
      <xs:enumeration value=""44"" />
      <xs:enumeration value=""45"" />
      <xs:enumeration value=""46"" />
      <xs:enumeration value=""47"" />
      <xs:enumeration value=""49"" />
      <xs:enumeration value=""50"" />
      <xs:enumeration value=""51"" />
      <xs:enumeration value=""52"" />
      <xs:enumeration value=""53"" />
      <xs:enumeration value=""54"" />
      <xs:enumeration value=""55"" />
      <xs:enumeration value=""56"" />
      <xs:enumeration value=""57"" />
      <xs:enumeration value=""58"" />
      <xs:enumeration value=""59"" />
      <xs:enumeration value=""60"" />
      <xs:enumeration value=""61"" />
      <xs:enumeration value=""62"" />
      <xs:enumeration value=""63"" />
      <xs:enumeration value=""64"" />
      <xs:enumeration value=""65"" />
      <xs:enumeration value=""66"" />
      <xs:enumeration value=""67"" />
      <xs:enumeration value=""68"" />
      <xs:enumeration value=""69"" />
      <xs:enumeration value=""70"" />
      <xs:enumeration value=""71"" />
      <xs:enumeration value=""72"" />
      <xs:enumeration value=""73"" />
      <xs:enumeration value=""74"" />
      <xs:enumeration value=""75"" />
      <xs:enumeration value=""76"" />
      <xs:enumeration value=""77"" />
      <xs:enumeration value=""78"" />
      <xs:enumeration value=""79"" />
      <xs:enumeration value=""80"" />
      <xs:enumeration value=""81"" />
      <xs:enumeration value=""82"" />
      <xs:enumeration value=""83"" />
      <xs:enumeration value=""84"" />
      <xs:enumeration value=""85"" />
      <xs:enumeration value=""86"" />
      <xs:enumeration value=""87"" />
      <xs:enumeration value=""88"" />
      <xs:enumeration value=""89"" />
      <xs:enumeration value=""90"" />
      <xs:enumeration value=""91"" />
      <xs:enumeration value=""92"" />
      <xs:enumeration value=""93"" />
      <xs:enumeration value=""94"" />
      <xs:enumeration value=""95"" />
      <xs:enumeration value=""96"" />
      <xs:enumeration value=""97"" />
      <xs:enumeration value=""ZZ"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""X12_ID_936"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""01"" />
      <xs:enumeration value=""02"" />
      <xs:enumeration value=""03"" />
      <xs:enumeration value=""04"" />
      <xs:enumeration value=""05"" />
      <xs:enumeration value=""06"" />
      <xs:enumeration value=""07"" />
      <xs:enumeration value=""08"" />
      <xs:enumeration value=""09"" />
      <xs:enumeration value=""10"" />
      <xs:enumeration value=""11"" />
      <xs:enumeration value=""12"" />
      <xs:enumeration value=""13"" />
      <xs:enumeration value=""14"" />
      <xs:enumeration value=""15"" />
      <xs:enumeration value=""16"" />
      <xs:enumeration value=""17"" />
      <xs:enumeration value=""18"" />
      <xs:enumeration value=""19"" />
      <xs:enumeration value=""20"" />
      <xs:enumeration value=""21"" />
      <xs:enumeration value=""22"" />
      <xs:enumeration value=""23"" />
      <xs:enumeration value=""24"" />
      <xs:enumeration value=""25"" />
      <xs:enumeration value=""26"" />
      <xs:enumeration value=""27"" />
      <xs:enumeration value=""28"" />
      <xs:enumeration value=""29"" />
      <xs:enumeration value=""40"" />
      <xs:enumeration value=""41"" />
      <xs:enumeration value=""42"" />
      <xs:enumeration value=""44"" />
      <xs:enumeration value=""45"" />
      <xs:enumeration value=""46"" />
      <xs:enumeration value=""48"" />
      <xs:enumeration value=""49"" />
      <xs:enumeration value=""50"" />
      <xs:enumeration value=""51"" />
      <xs:enumeration value=""52"" />
      <xs:enumeration value=""Q1"" />
      <xs:enumeration value=""Q2"" />
      <xs:enumeration value=""TA"" />
      <xs:enumeration value=""TB"" />
      <xs:enumeration value=""ZZ"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""X12_ID_752"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""1S"" />
      <xs:enumeration value=""2S"" />
      <xs:enumeration value=""A1"" />
      <xs:enumeration value=""AL"" />
      <xs:enumeration value=""AO"" />
      <xs:enumeration value=""AS"" />
      <xs:enumeration value=""B1"" />
      <xs:enumeration value=""BC"" />
      <xs:enumeration value=""BI"" />
      <xs:enumeration value=""BK"" />
      <xs:enumeration value=""BL"" />
      <xs:enumeration value=""BR"" />
      <xs:enumeration value=""BS"" />
      <xs:enumeration value=""BT"" />
      <xs:enumeration value=""CH"" />
      <xs:enumeration value=""CT"" />
      <xs:enumeration value=""DO"" />
      <xs:enumeration value=""DT"" />
      <xs:enumeration value=""DU"" />
      <xs:enumeration value=""EX"" />
      <xs:enumeration value=""FR"" />
      <xs:enumeration value=""FS"" />
      <xs:enumeration value=""GF"" />
      <xs:enumeration value=""IN"" />
      <xs:enumeration value=""IT"" />
      <xs:enumeration value=""KB"" />
      <xs:enumeration value=""LC"" />
      <xs:enumeration value=""LO"" />
      <xs:enumeration value=""LT"" />
      <xs:enumeration value=""M1"" />
      <xs:enumeration value=""MC"" />
      <xs:enumeration value=""MD"" />
      <xs:enumeration value=""NS"" />
      <xs:enumeration value=""NT"" />
      <xs:enumeration value=""OA"" />
      <xs:enumeration value=""OS"" />
      <xs:enumeration value=""OT"" />
      <xs:enumeration value=""R0"" />
      <xs:enumeration value=""R1"" />
      <xs:enumeration value=""R2"" />
      <xs:enumeration value=""R3"" />
      <xs:enumeration value=""R4"" />
      <xs:enumeration value=""R5"" />
      <xs:enumeration value=""R6"" />
      <xs:enumeration value=""R7"" />
      <xs:enumeration value=""R8"" />
      <xs:enumeration value=""R9"" />
      <xs:enumeration value=""RA"" />
      <xs:enumeration value=""RB"" />
      <xs:enumeration value=""RC"" />
      <xs:enumeration value=""RD"" />
      <xs:enumeration value=""RE"" />
      <xs:enumeration value=""RF"" />
      <xs:enumeration value=""RG"" />
      <xs:enumeration value=""RH"" />
      <xs:enumeration value=""RI"" />
      <xs:enumeration value=""RJ"" />
      <xs:enumeration value=""RK"" />
      <xs:enumeration value=""RL"" />
      <xs:enumeration value=""RM"" />
      <xs:enumeration value=""RN"" />
      <xs:enumeration value=""RO"" />
      <xs:enumeration value=""RP"" />
      <xs:enumeration value=""RQ"" />
      <xs:enumeration value=""RR"" />
      <xs:enumeration value=""RS"" />
      <xs:enumeration value=""RT"" />
      <xs:enumeration value=""RU"" />
      <xs:enumeration value=""RV"" />
      <xs:enumeration value=""RW"" />
      <xs:enumeration value=""RX"" />
      <xs:enumeration value=""RY"" />
      <xs:enumeration value=""RZ"" />
      <xs:enumeration value=""S1"" />
      <xs:enumeration value=""S2"" />
      <xs:enumeration value=""S3"" />
      <xs:enumeration value=""S4"" />
      <xs:enumeration value=""S5"" />
      <xs:enumeration value=""S6"" />
      <xs:enumeration value=""S7"" />
      <xs:enumeration value=""S8"" />
      <xs:enumeration value=""S9"" />
      <xs:enumeration value=""SA"" />
      <xs:enumeration value=""SB"" />
      <xs:enumeration value=""SC"" />
      <xs:enumeration value=""SD"" />
      <xs:enumeration value=""SE"" />
      <xs:enumeration value=""SF"" />
      <xs:enumeration value=""SN"" />
      <xs:enumeration value=""SP"" />
      <xs:enumeration value=""SS"" />
      <xs:enumeration value=""ST"" />
      <xs:enumeration value=""SU"" />
      <xs:enumeration value=""TB"" />
      <xs:enumeration value=""TP"" />
      <xs:enumeration value=""TS"" />
      <xs:enumeration value=""UC"" />
      <xs:enumeration value=""UN"" />
      <xs:enumeration value=""UP"" />
      <xs:enumeration value=""UT"" />
      <xs:enumeration value=""WF"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""X12_ID_1373"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""BM"" />
      <xs:enumeration value=""BO"" />
      <xs:enumeration value=""DM"" />
      <xs:enumeration value=""FT"" />
      <xs:enumeration value=""MA"" />
      <xs:enumeration value=""MM"" />
      <xs:enumeration value=""OM"" />
      <xs:enumeration value=""PT"" />
      <xs:enumeration value=""TM"" />
      <xs:enumeration value=""VA"" />
      <xs:enumeration value=""VB"" />
      <xs:enumeration value=""VC"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""X12_ID_522"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""01"" />
      <xs:enumeration value=""02"" />
      <xs:enumeration value=""03"" />
      <xs:enumeration value=""04"" />
      <xs:enumeration value=""05"" />
      <xs:enumeration value=""06"" />
      <xs:enumeration value=""07"" />
      <xs:enumeration value=""08"" />
      <xs:enumeration value=""09"" />
      <xs:enumeration value=""0A"" />
      <xs:enumeration value=""0B"" />
      <xs:enumeration value=""0C"" />
      <xs:enumeration value=""0D"" />
      <xs:enumeration value=""0E"" />
      <xs:enumeration value=""0F"" />
      <xs:enumeration value=""0G"" />
      <xs:enumeration value=""0H"" />
      <xs:enumeration value=""0I"" />
      <xs:enumeration value=""0J"" />
      <xs:enumeration value=""0K"" />
      <xs:enumeration value=""0L"" />
      <xs:enumeration value=""0M"" />
      <xs:enumeration value=""0N"" />
      <xs:enumeration value=""0P"" />
      <xs:enumeration value=""0Q"" />
      <xs:enumeration value=""0R"" />
      <xs:enumeration value=""0S"" />
      <xs:enumeration value=""0T"" />
      <xs:enumeration value=""0U"" />
      <xs:enumeration value=""1"" />
      <xs:enumeration value=""10"" />
      <xs:enumeration value=""11"" />
      <xs:enumeration value=""12"" />
      <xs:enumeration value=""13"" />
      <xs:enumeration value=""14"" />
      <xs:enumeration value=""15"" />
      <xs:enumeration value=""16"" />
      <xs:enumeration value=""17"" />
      <xs:enumeration value=""18"" />
      <xs:enumeration value=""19"" />
      <xs:enumeration value=""1A"" />
      <xs:enumeration value=""1B"" />
      <xs:enumeration value=""1C"" />
      <xs:enumeration value=""1D"" />
      <xs:enumeration value=""1E"" />
      <xs:enumeration value=""1F"" />
      <xs:enumeration value=""1G"" />
      <xs:enumeration value=""1H"" />
      <xs:enumeration value=""1J"" />
      <xs:enumeration value=""1K"" />
      <xs:enumeration value=""1L"" />
      <xs:enumeration value=""1M"" />
      <xs:enumeration value=""1N"" />
      <xs:enumeration value=""1P"" />
      <xs:enumeration value=""1Q"" />
      <xs:enumeration value=""1R"" />
      <xs:enumeration value=""1S"" />
      <xs:enumeration value=""1T"" />
      <xs:enumeration value=""1U"" />
      <xs:enumeration value=""1V"" />
      <xs:enumeration value=""1W"" />
      <xs:enumeration value=""1X"" />
      <xs:enumeration value=""1Y"" />
      <xs:enumeration value=""1Z"" />
      <xs:enumeration value=""2"" />
      <xs:enumeration value=""20"" />
      <xs:enumeration value=""21"" />
      <xs:enumeration value=""22"" />
      <xs:enumeration value=""23"" />
      <xs:enumeration value=""24"" />
      <xs:enumeration value=""25"" />
      <xs:enumeration value=""26"" />
      <xs:enumeration value=""27"" />
      <xs:enumeration value=""28"" />
      <xs:enumeration value=""29"" />
      <xs:enumeration value=""2A"" />
      <xs:enumeration value=""2B"" />
      <xs:enumeration value=""2C"" />
      <xs:enumeration value=""2D"" />
      <xs:enumeration value=""2E"" />
      <xs:enumeration value=""2F"" />
      <xs:enumeration value=""2G"" />
      <xs:enumeration value=""2H"" />
      <xs:enumeration value=""2I"" />
      <xs:enumeration value=""2J"" />
      <xs:enumeration value=""2K"" />
      <xs:enumeration value=""2L"" />
      <xs:enumeration value=""2M"" />
      <xs:enumeration value=""2N"" />
      <xs:enumeration value=""2P"" />
      <xs:enumeration value=""2Q"" />
      <xs:enumeration value=""2R"" />
      <xs:enumeration value=""2S"" />
      <xs:enumeration value=""2T"" />
      <xs:enumeration value=""2U"" />
      <xs:enumeration value=""2V"" />
      <xs:enumeration value=""2W"" />
      <xs:enumeration value=""2X"" />
      <xs:enumeration value=""2Y"" />
      <xs:enumeration value=""2Z"" />
      <xs:enumeration value=""3"" />
      <xs:enumeration value=""30"" />
      <xs:enumeration value=""31"" />
      <xs:enumeration value=""32"" />
      <xs:enumeration value=""33"" />
      <xs:enumeration value=""34"" />
      <xs:enumeration value=""35"" />
      <xs:enumeration value=""36"" />
      <xs:enumeration value=""37"" />
      <xs:enumeration value=""38"" />
      <xs:enumeration value=""39"" />
      <xs:enumeration value=""3A"" />
      <xs:enumeration value=""3B"" />
      <xs:enumeration value=""3C"" />
      <xs:enumeration value=""3D"" />
      <xs:enumeration value=""3E"" />
      <xs:enumeration value=""3F"" />
      <xs:enumeration value=""3G"" />
      <xs:enumeration value=""3H"" />
      <xs:enumeration value=""3I"" />
      <xs:enumeration value=""3J"" />
      <xs:enumeration value=""3K"" />
      <xs:enumeration value=""3L"" />
      <xs:enumeration value=""3M"" />
      <xs:enumeration value=""3N"" />
      <xs:enumeration value=""3O"" />
      <xs:enumeration value=""3P"" />
      <xs:enumeration value=""3Q"" />
      <xs:enumeration value=""3R"" />
      <xs:enumeration value=""3S"" />
      <xs:enumeration value=""3T"" />
      <xs:enumeration value=""3U"" />
      <xs:enumeration value=""3V"" />
      <xs:enumeration value=""3W"" />
      <xs:enumeration value=""3X"" />
      <xs:enumeration value=""3Y"" />
      <xs:enumeration value=""3Z"" />
      <xs:enumeration value=""4"" />
      <xs:enumeration value=""40"" />
      <xs:enumeration value=""41"" />
      <xs:enumeration value=""42"" />
      <xs:enumeration value=""43"" />
      <xs:enumeration value=""44"" />
      <xs:enumeration value=""45"" />
      <xs:enumeration value=""46"" />
      <xs:enumeration value=""47"" />
      <xs:enumeration value=""48"" />
      <xs:enumeration value=""49"" />
      <xs:enumeration value=""4A"" />
      <xs:enumeration value=""4B"" />
      <xs:enumeration value=""4C"" />
      <xs:enumeration value=""4D"" />
      <xs:enumeration value=""4E"" />
      <xs:enumeration value=""4F"" />
      <xs:enumeration value=""4G"" />
      <xs:enumeration value=""4H"" />
      <xs:enumeration value=""4I"" />
      <xs:enumeration value=""4J"" />
      <xs:enumeration value=""4K"" />
      <xs:enumeration value=""4L"" />
      <xs:enumeration value=""4M"" />
      <xs:enumeration value=""4N"" />
      <xs:enumeration value=""4O"" />
      <xs:enumeration value=""4P"" />
      <xs:enumeration value=""4Q"" />
      <xs:enumeration value=""4R"" />
      <xs:enumeration value=""4S"" />
      <xs:enumeration value=""4T"" />
      <xs:enumeration value=""4U"" />
      <xs:enumeration value=""4V"" />
      <xs:enumeration value=""4W"" />
      <xs:enumeration value=""4X"" />
      <xs:enumeration value=""4Y"" />
      <xs:enumeration value=""4Z"" />
      <xs:enumeration value=""5"" />
      <xs:enumeration value=""50"" />
      <xs:enumeration value=""51"" />
      <xs:enumeration value=""52"" />
      <xs:enumeration value=""53"" />
      <xs:enumeration value=""54"" />
      <xs:enumeration value=""55"" />
      <xs:enumeration value=""56"" />
      <xs:enumeration value=""57"" />
      <xs:enumeration value=""58"" />
      <xs:enumeration value=""59"" />
      <xs:enumeration value=""5A"" />
      <xs:enumeration value=""5B"" />
      <xs:enumeration value=""5C"" />
      <xs:enumeration value=""5D"" />
      <xs:enumeration value=""5E"" />
      <xs:enumeration value=""5F"" />
      <xs:enumeration value=""5G"" />
      <xs:enumeration value=""5H"" />
      <xs:enumeration value=""5I"" />
      <xs:enumeration value=""5J"" />
      <xs:enumeration value=""5K"" />
      <xs:enumeration value=""5L"" />
      <xs:enumeration value=""5M"" />
      <xs:enumeration value=""5N"" />
      <xs:enumeration value=""5O"" />
      <xs:enumeration value=""5P"" />
      <xs:enumeration value=""5Q"" />
      <xs:enumeration value=""5R"" />
      <xs:enumeration value=""5S"" />
      <xs:enumeration value=""5T"" />
      <xs:enumeration value=""5U"" />
      <xs:enumeration value=""5V"" />
      <xs:enumeration value=""5W"" />
      <xs:enumeration value=""5X"" />
      <xs:enumeration value=""5Y"" />
      <xs:enumeration value=""5Z"" />
      <xs:enumeration value=""6"" />
      <xs:enumeration value=""60"" />
      <xs:enumeration value=""61"" />
      <xs:enumeration value=""62"" />
      <xs:enumeration value=""63"" />
      <xs:enumeration value=""64"" />
      <xs:enumeration value=""65"" />
      <xs:enumeration value=""66"" />
      <xs:enumeration value=""67"" />
      <xs:enumeration value=""68"" />
      <xs:enumeration value=""69"" />
      <xs:enumeration value=""6A"" />
      <xs:enumeration value=""6B"" />
      <xs:enumeration value=""6C"" />
      <xs:enumeration value=""6D"" />
      <xs:enumeration value=""6E"" />
      <xs:enumeration value=""6F"" />
      <xs:enumeration value=""6G"" />
      <xs:enumeration value=""6H"" />
      <xs:enumeration value=""6I"" />
      <xs:enumeration value=""6J"" />
      <xs:enumeration value=""6K"" />
      <xs:enumeration value=""6L"" />
      <xs:enumeration value=""6M"" />
      <xs:enumeration value=""6N"" />
      <xs:enumeration value=""6O"" />
      <xs:enumeration value=""6P"" />
      <xs:enumeration value=""6Q"" />
      <xs:enumeration value=""6R"" />
      <xs:enumeration value=""6S"" />
      <xs:enumeration value=""6T"" />
      <xs:enumeration value=""6U"" />
      <xs:enumeration value=""6V"" />
      <xs:enumeration value=""6W"" />
      <xs:enumeration value=""6X"" />
      <xs:enumeration value=""6Y"" />
      <xs:enumeration value=""6Z"" />
      <xs:enumeration value=""7"" />
      <xs:enumeration value=""70"" />
      <xs:enumeration value=""71"" />
      <xs:enumeration value=""72"" />
      <xs:enumeration value=""73"" />
      <xs:enumeration value=""74"" />
      <xs:enumeration value=""75"" />
      <xs:enumeration value=""76"" />
      <xs:enumeration value=""77"" />
      <xs:enumeration value=""78"" />
      <xs:enumeration value=""79"" />
      <xs:enumeration value=""7A"" />
      <xs:enumeration value=""7B"" />
      <xs:enumeration value=""7C"" />
      <xs:enumeration value=""7D"" />
      <xs:enumeration value=""7E"" />
      <xs:enumeration value=""7F"" />
      <xs:enumeration value=""7G"" />
      <xs:enumeration value=""7H"" />
      <xs:enumeration value=""7I"" />
      <xs:enumeration value=""7J"" />
      <xs:enumeration value=""7K"" />
      <xs:enumeration value=""7L"" />
      <xs:enumeration value=""7M"" />
      <xs:enumeration value=""7N"" />
      <xs:enumeration value=""7O"" />
      <xs:enumeration value=""7P"" />
      <xs:enumeration value=""7Q"" />
      <xs:enumeration value=""7R"" />
      <xs:enumeration value=""7S"" />
      <xs:enumeration value=""7T"" />
      <xs:enumeration value=""7U"" />
      <xs:enumeration value=""7V"" />
      <xs:enumeration value=""7W"" />
      <xs:enumeration value=""7X"" />
      <xs:enumeration value=""7Y"" />
      <xs:enumeration value=""7Z"" />
      <xs:enumeration value=""8"" />
      <xs:enumeration value=""80"" />
      <xs:enumeration value=""81"" />
      <xs:enumeration value=""82"" />
      <xs:enumeration value=""83"" />
      <xs:enumeration value=""84"" />
      <xs:enumeration value=""85"" />
      <xs:enumeration value=""86"" />
      <xs:enumeration value=""87"" />
      <xs:enumeration value=""88"" />
      <xs:enumeration value=""89"" />
      <xs:enumeration value=""8A"" />
      <xs:enumeration value=""8B"" />
      <xs:enumeration value=""8C"" />
      <xs:enumeration value=""8D"" />
      <xs:enumeration value=""8E"" />
      <xs:enumeration value=""8F"" />
      <xs:enumeration value=""8G"" />
      <xs:enumeration value=""8H"" />
      <xs:enumeration value=""8I"" />
      <xs:enumeration value=""8J"" />
      <xs:enumeration value=""8K"" />
      <xs:enumeration value=""8L"" />
      <xs:enumeration value=""8M"" />
      <xs:enumeration value=""8N"" />
      <xs:enumeration value=""8O"" />
      <xs:enumeration value=""8P"" />
      <xs:enumeration value=""8Q"" />
      <xs:enumeration value=""8R"" />
      <xs:enumeration value=""8S"" />
      <xs:enumeration value=""8T"" />
      <xs:enumeration value=""8U"" />
      <xs:enumeration value=""8V"" />
      <xs:enumeration value=""8W"" />
      <xs:enumeration value=""8X"" />
      <xs:enumeration value=""8Y"" />
      <xs:enumeration value=""8Z"" />
      <xs:enumeration value=""9"" />
      <xs:enumeration value=""90"" />
      <xs:enumeration value=""91"" />
      <xs:enumeration value=""92"" />
      <xs:enumeration value=""93"" />
      <xs:enumeration value=""94"" />
      <xs:enumeration value=""95"" />
      <xs:enumeration value=""96"" />
      <xs:enumeration value=""97"" />
      <xs:enumeration value=""98"" />
      <xs:enumeration value=""99"" />
      <xs:enumeration value=""9A"" />
      <xs:enumeration value=""9B"" />
      <xs:enumeration value=""9C"" />
      <xs:enumeration value=""9D"" />
      <xs:enumeration value=""9E"" />
      <xs:enumeration value=""9F"" />
      <xs:enumeration value=""9G"" />
      <xs:enumeration value=""9H"" />
      <xs:enumeration value=""9I"" />
      <xs:enumeration value=""9J"" />
      <xs:enumeration value=""9K"" />
      <xs:enumeration value=""9L"" />
      <xs:enumeration value=""9M"" />
      <xs:enumeration value=""9N"" />
      <xs:enumeration value=""9O"" />
      <xs:enumeration value=""9P"" />
      <xs:enumeration value=""9Q"" />
      <xs:enumeration value=""9R"" />
      <xs:enumeration value=""9S"" />
      <xs:enumeration value=""9T"" />
      <xs:enumeration value=""9U"" />
      <xs:enumeration value=""9V"" />
      <xs:enumeration value=""9W"" />
      <xs:enumeration value=""9X"" />
      <xs:enumeration value=""9Y"" />
      <xs:enumeration value=""9Z"" />
      <xs:enumeration value=""A"" />
      <xs:enumeration value=""A0"" />
      <xs:enumeration value=""A1"" />
      <xs:enumeration value=""A2"" />
      <xs:enumeration value=""A3"" />
      <xs:enumeration value=""A4"" />
      <xs:enumeration value=""A5"" />
      <xs:enumeration value=""A6"" />
      <xs:enumeration value=""A7"" />
      <xs:enumeration value=""A8"" />
      <xs:enumeration value=""A9"" />
      <xs:enumeration value=""AA"" />
      <xs:enumeration value=""AAA"" />
      <xs:enumeration value=""AAB"" />
      <xs:enumeration value=""AAC"" />
      <xs:enumeration value=""AAD"" />
      <xs:enumeration value=""AAE"" />
      <xs:enumeration value=""AAF"" />
      <xs:enumeration value=""AAG"" />
      <xs:enumeration value=""AAH"" />
      <xs:enumeration value=""AAI"" />
      <xs:enumeration value=""AAJ"" />
      <xs:enumeration value=""AAK"" />
      <xs:enumeration value=""AAL"" />
      <xs:enumeration value=""AAM"" />
      <xs:enumeration value=""AAN"" />
      <xs:enumeration value=""AAO"" />
      <xs:enumeration value=""AAP"" />
      <xs:enumeration value=""AAQ"" />
      <xs:enumeration value=""AAR"" />
      <xs:enumeration value=""AAS"" />
      <xs:enumeration value=""AAT"" />
      <xs:enumeration value=""AAU"" />
      <xs:enumeration value=""AAV"" />
      <xs:enumeration value=""AAW"" />
      <xs:enumeration value=""AAX"" />
      <xs:enumeration value=""AAY"" />
      <xs:enumeration value=""AAZ"" />
      <xs:enumeration value=""AB"" />
      <xs:enumeration value=""ABA"" />
      <xs:enumeration value=""ABB"" />
      <xs:enumeration value=""ABC"" />
      <xs:enumeration value=""ABD"" />
      <xs:enumeration value=""ABE"" />
      <xs:enumeration value=""ABF"" />
      <xs:enumeration value=""ABG"" />
      <xs:enumeration value=""ABH"" />
      <xs:enumeration value=""ABI"" />
      <xs:enumeration value=""ABJ"" />
      <xs:enumeration value=""ABK"" />
      <xs:enumeration value=""ABL"" />
      <xs:enumeration value=""ABM"" />
      <xs:enumeration value=""ABN"" />
      <xs:enumeration value=""ABO"" />
      <xs:enumeration value=""ABP"" />
      <xs:enumeration value=""ABQ"" />
      <xs:enumeration value=""ABR"" />
      <xs:enumeration value=""ABS"" />
      <xs:enumeration value=""ABT"" />
      <xs:enumeration value=""ABU"" />
      <xs:enumeration value=""ABV"" />
      <xs:enumeration value=""ABW"" />
      <xs:enumeration value=""ABX"" />
      <xs:enumeration value=""ABY"" />
      <xs:enumeration value=""ABZ"" />
      <xs:enumeration value=""AC"" />
      <xs:enumeration value=""ACA"" />
      <xs:enumeration value=""ACB"" />
      <xs:enumeration value=""ACC"" />
      <xs:enumeration value=""ACD"" />
      <xs:enumeration value=""ACE"" />
      <xs:enumeration value=""ACF"" />
      <xs:enumeration value=""ACG"" />
      <xs:enumeration value=""ACH"" />
      <xs:enumeration value=""ACI"" />
      <xs:enumeration value=""ACJ"" />
      <xs:enumeration value=""ACK"" />
      <xs:enumeration value=""ACL"" />
      <xs:enumeration value=""ACM"" />
      <xs:enumeration value=""ACN"" />
      <xs:enumeration value=""ACO"" />
      <xs:enumeration value=""ACP"" />
      <xs:enumeration value=""ACQ"" />
      <xs:enumeration value=""ACR"" />
      <xs:enumeration value=""ACS"" />
      <xs:enumeration value=""ACT"" />
      <xs:enumeration value=""ACU"" />
      <xs:enumeration value=""ACV"" />
      <xs:enumeration value=""ACW"" />
      <xs:enumeration value=""ACX"" />
      <xs:enumeration value=""ACY"" />
      <xs:enumeration value=""ACZ"" />
      <xs:enumeration value=""AD"" />
      <xs:enumeration value=""ADA"" />
      <xs:enumeration value=""ADB"" />
      <xs:enumeration value=""ADC"" />
      <xs:enumeration value=""ADD"" />
      <xs:enumeration value=""ADE"" />
      <xs:enumeration value=""ADF"" />
      <xs:enumeration value=""ADG"" />
      <xs:enumeration value=""ADH"" />
      <xs:enumeration value=""ADI"" />
      <xs:enumeration value=""ADJ"" />
      <xs:enumeration value=""ADK"" />
      <xs:enumeration value=""ADL"" />
      <xs:enumeration value=""ADM"" />
      <xs:enumeration value=""ADN"" />
      <xs:enumeration value=""ADO"" />
      <xs:enumeration value=""ADP"" />
      <xs:enumeration value=""ADQ"" />
      <xs:enumeration value=""ADR"" />
      <xs:enumeration value=""ADS"" />
      <xs:enumeration value=""ADT"" />
      <xs:enumeration value=""ADW"" />
      <xs:enumeration value=""ADX"" />
      <xs:enumeration value=""ADY"" />
      <xs:enumeration value=""ADZ"" />
      <xs:enumeration value=""AE"" />
      <xs:enumeration value=""AEB"" />
      <xs:enumeration value=""AEC"" />
      <xs:enumeration value=""AED"" />
      <xs:enumeration value=""AEE"" />
      <xs:enumeration value=""AEF"" />
      <xs:enumeration value=""AEG"" />
      <xs:enumeration value=""AEH"" />
      <xs:enumeration value=""AEI"" />
      <xs:enumeration value=""AEJ"" />
      <xs:enumeration value=""AEK"" />
      <xs:enumeration value=""AEL"" />
      <xs:enumeration value=""AF"" />
      <xs:enumeration value=""AG"" />
      <xs:enumeration value=""AH"" />
      <xs:enumeration value=""AI"" />
      <xs:enumeration value=""AJ"" />
      <xs:enumeration value=""AK"" />
      <xs:enumeration value=""AL"" />
      <xs:enumeration value=""AM"" />
      <xs:enumeration value=""AN"" />
      <xs:enumeration value=""AO"" />
      <xs:enumeration value=""AP"" />
      <xs:enumeration value=""AQ"" />
      <xs:enumeration value=""AR"" />
      <xs:enumeration value=""AS"" />
      <xs:enumeration value=""AT"" />
      <xs:enumeration value=""AU"" />
      <xs:enumeration value=""AV"" />
      <xs:enumeration value=""AVE"" />
      <xs:enumeration value=""AW"" />
      <xs:enumeration value=""AX"" />
      <xs:enumeration value=""AY"" />
      <xs:enumeration value=""AZ"" />
      <xs:enumeration value=""B"" />
      <xs:enumeration value=""B0"" />
      <xs:enumeration value=""B1"" />
      <xs:enumeration value=""B2"" />
      <xs:enumeration value=""B3"" />
      <xs:enumeration value=""B4"" />
      <xs:enumeration value=""B5"" />
      <xs:enumeration value=""B6"" />
      <xs:enumeration value=""B7"" />
      <xs:enumeration value=""B8"" />
      <xs:enumeration value=""B9"" />
      <xs:enumeration value=""BA"" />
      <xs:enumeration value=""BAA"" />
      <xs:enumeration value=""BAB"" />
      <xs:enumeration value=""BAC"" />
      <xs:enumeration value=""BAD"" />
      <xs:enumeration value=""BAE"" />
      <xs:enumeration value=""BAF"" />
      <xs:enumeration value=""BAG"" />
      <xs:enumeration value=""BAH"" />
      <xs:enumeration value=""BAI"" />
      <xs:enumeration value=""BAJ"" />
      <xs:enumeration value=""BAK"" />
      <xs:enumeration value=""BAL"" />
      <xs:enumeration value=""BAM"" />
      <xs:enumeration value=""BAN"" />
      <xs:enumeration value=""BAO"" />
      <xs:enumeration value=""BAP"" />
      <xs:enumeration value=""BAQ"" />
      <xs:enumeration value=""BAR"" />
      <xs:enumeration value=""BAS"" />
      <xs:enumeration value=""BAT"" />
      <xs:enumeration value=""BAU"" />
      <xs:enumeration value=""BAV"" />
      <xs:enumeration value=""BAW"" />
      <xs:enumeration value=""BAX"" />
      <xs:enumeration value=""BAY"" />
      <xs:enumeration value=""BAZ"" />
      <xs:enumeration value=""BB"" />
      <xs:enumeration value=""BBA"" />
      <xs:enumeration value=""BBB"" />
      <xs:enumeration value=""BBC"" />
      <xs:enumeration value=""BBD"" />
      <xs:enumeration value=""BBE"" />
      <xs:enumeration value=""BBF"" />
      <xs:enumeration value=""BBG"" />
      <xs:enumeration value=""BC"" />
      <xs:enumeration value=""BD"" />
      <xs:enumeration value=""BE"" />
      <xs:enumeration value=""BF"" />
      <xs:enumeration value=""BG"" />
      <xs:enumeration value=""BH"" />
      <xs:enumeration value=""BI"" />
      <xs:enumeration value=""BJ"" />
      <xs:enumeration value=""BK"" />
      <xs:enumeration value=""BL"" />
      <xs:enumeration value=""BM"" />
      <xs:enumeration value=""BN"" />
      <xs:enumeration value=""BO"" />
      <xs:enumeration value=""BP"" />
      <xs:enumeration value=""BQ"" />
      <xs:enumeration value=""BR"" />
      <xs:enumeration value=""BS"" />
      <xs:enumeration value=""BT"" />
      <xs:enumeration value=""BU"" />
      <xs:enumeration value=""BV"" />
      <xs:enumeration value=""BW"" />
      <xs:enumeration value=""BX"" />
      <xs:enumeration value=""BY"" />
      <xs:enumeration value=""BZ"" />
      <xs:enumeration value=""C"" />
      <xs:enumeration value=""C0"" />
      <xs:enumeration value=""C1"" />
      <xs:enumeration value=""C2"" />
      <xs:enumeration value=""C3"" />
      <xs:enumeration value=""C4"" />
      <xs:enumeration value=""C5"" />
      <xs:enumeration value=""C6"" />
      <xs:enumeration value=""C7"" />
      <xs:enumeration value=""C8"" />
      <xs:enumeration value=""C9"" />
      <xs:enumeration value=""CA"" />
      <xs:enumeration value=""CB"" />
      <xs:enumeration value=""CC"" />
      <xs:enumeration value=""CD"" />
      <xs:enumeration value=""CE"" />
      <xs:enumeration value=""CF"" />
      <xs:enumeration value=""CG"" />
      <xs:enumeration value=""CH"" />
      <xs:enumeration value=""CI"" />
      <xs:enumeration value=""CJ"" />
      <xs:enumeration value=""CK"" />
      <xs:enumeration value=""CL"" />
      <xs:enumeration value=""CM"" />
      <xs:enumeration value=""CN"" />
      <xs:enumeration value=""CO"" />
      <xs:enumeration value=""CP"" />
      <xs:enumeration value=""CQ"" />
      <xs:enumeration value=""CR"" />
      <xs:enumeration value=""CS"" />
      <xs:enumeration value=""CT"" />
      <xs:enumeration value=""CU"" />
      <xs:enumeration value=""CV"" />
      <xs:enumeration value=""CW"" />
      <xs:enumeration value=""CX"" />
      <xs:enumeration value=""CY"" />
      <xs:enumeration value=""CZ"" />
      <xs:enumeration value=""D"" />
      <xs:enumeration value=""D0"" />
      <xs:enumeration value=""D1"" />
      <xs:enumeration value=""D2"" />
      <xs:enumeration value=""D3"" />
      <xs:enumeration value=""D4"" />
      <xs:enumeration value=""D5"" />
      <xs:enumeration value=""D6"" />
      <xs:enumeration value=""D7"" />
      <xs:enumeration value=""D8"" />
      <xs:enumeration value=""D9"" />
      <xs:enumeration value=""DA"" />
      <xs:enumeration value=""DB"" />
      <xs:enumeration value=""DC"" />
      <xs:enumeration value=""DD"" />
      <xs:enumeration value=""DE"" />
      <xs:enumeration value=""DF"" />
      <xs:enumeration value=""DG"" />
      <xs:enumeration value=""DH"" />
      <xs:enumeration value=""DI"" />
      <xs:enumeration value=""DJ"" />
      <xs:enumeration value=""DK"" />
      <xs:enumeration value=""DL"" />
      <xs:enumeration value=""DM"" />
      <xs:enumeration value=""DN"" />
      <xs:enumeration value=""DO"" />
      <xs:enumeration value=""DP"" />
      <xs:enumeration value=""DQ"" />
      <xs:enumeration value=""DR"" />
      <xs:enumeration value=""DS"" />
      <xs:enumeration value=""DT"" />
      <xs:enumeration value=""DU"" />
      <xs:enumeration value=""DV"" />
      <xs:enumeration value=""DW"" />
      <xs:enumeration value=""DX"" />
      <xs:enumeration value=""DY"" />
      <xs:enumeration value=""DZ"" />
      <xs:enumeration value=""E"" />
      <xs:enumeration value=""E0"" />
      <xs:enumeration value=""E1"" />
      <xs:enumeration value=""E2"" />
      <xs:enumeration value=""E3"" />
      <xs:enumeration value=""E4"" />
      <xs:enumeration value=""E5"" />
      <xs:enumeration value=""E6"" />
      <xs:enumeration value=""E7"" />
      <xs:enumeration value=""E8"" />
      <xs:enumeration value=""E9"" />
      <xs:enumeration value=""EA"" />
      <xs:enumeration value=""EB"" />
      <xs:enumeration value=""EC"" />
      <xs:enumeration value=""ED"" />
      <xs:enumeration value=""EE"" />
      <xs:enumeration value=""EF"" />
      <xs:enumeration value=""EG"" />
      <xs:enumeration value=""EH"" />
      <xs:enumeration value=""EI"" />
      <xs:enumeration value=""EJ"" />
      <xs:enumeration value=""EK"" />
      <xs:enumeration value=""EL"" />
      <xs:enumeration value=""EM"" />
      <xs:enumeration value=""EN"" />
      <xs:enumeration value=""EO"" />
      <xs:enumeration value=""EP"" />
      <xs:enumeration value=""EQ"" />
      <xs:enumeration value=""ER"" />
      <xs:enumeration value=""ES"" />
      <xs:enumeration value=""ET"" />
      <xs:enumeration value=""EU"" />
      <xs:enumeration value=""EV"" />
      <xs:enumeration value=""EW"" />
      <xs:enumeration value=""EX"" />
      <xs:enumeration value=""EY"" />
      <xs:enumeration value=""EZ"" />
      <xs:enumeration value=""F"" />
      <xs:enumeration value=""F0"" />
      <xs:enumeration value=""F1"" />
      <xs:enumeration value=""F2"" />
      <xs:enumeration value=""F3"" />
      <xs:enumeration value=""F4"" />
      <xs:enumeration value=""F5"" />
      <xs:enumeration value=""F6"" />
      <xs:enumeration value=""F7"" />
      <xs:enumeration value=""F8"" />
      <xs:enumeration value=""F9"" />
      <xs:enumeration value=""FA"" />
      <xs:enumeration value=""FB"" />
      <xs:enumeration value=""FBA"" />
      <xs:enumeration value=""FC"" />
      <xs:enumeration value=""FD"" />
      <xs:enumeration value=""FE"" />
      <xs:enumeration value=""FF"" />
      <xs:enumeration value=""FG"" />
      <xs:enumeration value=""FH"" />
      <xs:enumeration value=""FI"" />
      <xs:enumeration value=""FJ"" />
      <xs:enumeration value=""FK"" />
      <xs:enumeration value=""FL"" />
      <xs:enumeration value=""FM"" />
      <xs:enumeration value=""FN"" />
      <xs:enumeration value=""FO"" />
      <xs:enumeration value=""FP"" />
      <xs:enumeration value=""FQ"" />
      <xs:enumeration value=""FR"" />
      <xs:enumeration value=""FS"" />
      <xs:enumeration value=""FT"" />
      <xs:enumeration value=""FU"" />
      <xs:enumeration value=""FV"" />
      <xs:enumeration value=""FW"" />
      <xs:enumeration value=""FX"" />
      <xs:enumeration value=""FY"" />
      <xs:enumeration value=""FZ"" />
      <xs:enumeration value=""G"" />
      <xs:enumeration value=""G0"" />
      <xs:enumeration value=""G1"" />
      <xs:enumeration value=""G2"" />
      <xs:enumeration value=""G3"" />
      <xs:enumeration value=""G4"" />
      <xs:enumeration value=""G5"" />
      <xs:enumeration value=""G6"" />
      <xs:enumeration value=""G7"" />
      <xs:enumeration value=""G8"" />
      <xs:enumeration value=""G9"" />
      <xs:enumeration value=""GA"" />
      <xs:enumeration value=""GB"" />
      <xs:enumeration value=""GC"" />
      <xs:enumeration value=""GD"" />
      <xs:enumeration value=""GE"" />
      <xs:enumeration value=""GF"" />
      <xs:enumeration value=""GG"" />
      <xs:enumeration value=""GH"" />
      <xs:enumeration value=""GI"" />
      <xs:enumeration value=""GJ"" />
      <xs:enumeration value=""GK"" />
      <xs:enumeration value=""GL"" />
      <xs:enumeration value=""GM"" />
      <xs:enumeration value=""GN"" />
      <xs:enumeration value=""GO"" />
      <xs:enumeration value=""GP"" />
      <xs:enumeration value=""GQ"" />
      <xs:enumeration value=""GR"" />
      <xs:enumeration value=""GS"" />
      <xs:enumeration value=""GT"" />
      <xs:enumeration value=""GU"" />
      <xs:enumeration value=""GV"" />
      <xs:enumeration value=""GW"" />
      <xs:enumeration value=""GX"" />
      <xs:enumeration value=""GY"" />
      <xs:enumeration value=""GZ"" />
      <xs:enumeration value=""H"" />
      <xs:enumeration value=""H0"" />
      <xs:enumeration value=""H1"" />
      <xs:enumeration value=""H2"" />
      <xs:enumeration value=""H3"" />
      <xs:enumeration value=""H4"" />
      <xs:enumeration value=""H5"" />
      <xs:enumeration value=""H6"" />
      <xs:enumeration value=""H7"" />
      <xs:enumeration value=""H8"" />
      <xs:enumeration value=""H9"" />
      <xs:enumeration value=""HA"" />
      <xs:enumeration value=""HB"" />
      <xs:enumeration value=""HC"" />
      <xs:enumeration value=""HD"" />
      <xs:enumeration value=""HE"" />
      <xs:enumeration value=""HF"" />
      <xs:enumeration value=""HG"" />
      <xs:enumeration value=""HH"" />
      <xs:enumeration value=""HI"" />
      <xs:enumeration value=""HJ"" />
      <xs:enumeration value=""HK"" />
      <xs:enumeration value=""HL"" />
      <xs:enumeration value=""HM"" />
      <xs:enumeration value=""HN"" />
      <xs:enumeration value=""HO"" />
      <xs:enumeration value=""HP"" />
      <xs:enumeration value=""HQ"" />
      <xs:enumeration value=""HR"" />
      <xs:enumeration value=""HS"" />
      <xs:enumeration value=""HT"" />
      <xs:enumeration value=""HU"" />
      <xs:enumeration value=""HV"" />
      <xs:enumeration value=""HW"" />
      <xs:enumeration value=""HX"" />
      <xs:enumeration value=""HY"" />
      <xs:enumeration value=""HZ"" />
      <xs:enumeration value=""I"" />
      <xs:enumeration value=""I0"" />
      <xs:enumeration value=""I1"" />
      <xs:enumeration value=""I2"" />
      <xs:enumeration value=""I3"" />
      <xs:enumeration value=""I4"" />
      <xs:enumeration value=""I5"" />
      <xs:enumeration value=""I6"" />
      <xs:enumeration value=""I7"" />
      <xs:enumeration value=""I8"" />
      <xs:enumeration value=""I9"" />
      <xs:enumeration value=""IA"" />
      <xs:enumeration value=""IB"" />
      <xs:enumeration value=""IC"" />
      <xs:enumeration value=""ID"" />
      <xs:enumeration value=""IE"" />
      <xs:enumeration value=""IF"" />
      <xs:enumeration value=""IG"" />
      <xs:enumeration value=""IH"" />
      <xs:enumeration value=""II"" />
      <xs:enumeration value=""IJ"" />
      <xs:enumeration value=""IK"" />
      <xs:enumeration value=""IL"" />
      <xs:enumeration value=""IM"" />
      <xs:enumeration value=""IN"" />
      <xs:enumeration value=""IO"" />
      <xs:enumeration value=""IP"" />
      <xs:enumeration value=""IQ"" />
      <xs:enumeration value=""IR"" />
      <xs:enumeration value=""IS"" />
      <xs:enumeration value=""IT"" />
      <xs:enumeration value=""IU"" />
      <xs:enumeration value=""IV"" />
      <xs:enumeration value=""IW"" />
      <xs:enumeration value=""IX"" />
      <xs:enumeration value=""IY"" />
      <xs:enumeration value=""IZ"" />
      <xs:enumeration value=""J"" />
      <xs:enumeration value=""J0"" />
      <xs:enumeration value=""J1"" />
      <xs:enumeration value=""J2"" />
      <xs:enumeration value=""J3"" />
      <xs:enumeration value=""J4"" />
      <xs:enumeration value=""J5"" />
      <xs:enumeration value=""J6"" />
      <xs:enumeration value=""J7"" />
      <xs:enumeration value=""J8"" />
      <xs:enumeration value=""J9"" />
      <xs:enumeration value=""JA"" />
      <xs:enumeration value=""JB"" />
      <xs:enumeration value=""JC"" />
      <xs:enumeration value=""JD"" />
      <xs:enumeration value=""JE"" />
      <xs:enumeration value=""JF"" />
      <xs:enumeration value=""JG"" />
      <xs:enumeration value=""JH"" />
      <xs:enumeration value=""JI"" />
      <xs:enumeration value=""JJ"" />
      <xs:enumeration value=""JK"" />
      <xs:enumeration value=""JL"" />
      <xs:enumeration value=""JM"" />
      <xs:enumeration value=""JN"" />
      <xs:enumeration value=""JO"" />
      <xs:enumeration value=""JP"" />
      <xs:enumeration value=""JQ"" />
      <xs:enumeration value=""JR"" />
      <xs:enumeration value=""JS"" />
      <xs:enumeration value=""JT"" />
      <xs:enumeration value=""JU"" />
      <xs:enumeration value=""JV"" />
      <xs:enumeration value=""JW"" />
      <xs:enumeration value=""JX"" />
      <xs:enumeration value=""JY"" />
      <xs:enumeration value=""JZ"" />
      <xs:enumeration value=""K"" />
      <xs:enumeration value=""K0"" />
      <xs:enumeration value=""K1"" />
      <xs:enumeration value=""K2"" />
      <xs:enumeration value=""K3"" />
      <xs:enumeration value=""K4"" />
      <xs:enumeration value=""K5"" />
      <xs:enumeration value=""K6"" />
      <xs:enumeration value=""K7"" />
      <xs:enumeration value=""K8"" />
      <xs:enumeration value=""K9"" />
      <xs:enumeration value=""KA"" />
      <xs:enumeration value=""KB"" />
      <xs:enumeration value=""KC"" />
      <xs:enumeration value=""KD"" />
      <xs:enumeration value=""KE"" />
      <xs:enumeration value=""KF"" />
      <xs:enumeration value=""KG"" />
      <xs:enumeration value=""KH"" />
      <xs:enumeration value=""KI"" />
      <xs:enumeration value=""KJ"" />
      <xs:enumeration value=""KK"" />
      <xs:enumeration value=""KL"" />
      <xs:enumeration value=""KM"" />
      <xs:enumeration value=""KN"" />
      <xs:enumeration value=""KO"" />
      <xs:enumeration value=""KP"" />
      <xs:enumeration value=""KQ"" />
      <xs:enumeration value=""KR"" />
      <xs:enumeration value=""KS"" />
      <xs:enumeration value=""KT"" />
      <xs:enumeration value=""KU"" />
      <xs:enumeration value=""KV"" />
      <xs:enumeration value=""KW"" />
      <xs:enumeration value=""KX"" />
      <xs:enumeration value=""KY"" />
      <xs:enumeration value=""KZ"" />
      <xs:enumeration value=""L"" />
      <xs:enumeration value=""L0"" />
      <xs:enumeration value=""L1"" />
      <xs:enumeration value=""L2"" />
      <xs:enumeration value=""L3"" />
      <xs:enumeration value=""L4"" />
      <xs:enumeration value=""L5"" />
      <xs:enumeration value=""L6"" />
      <xs:enumeration value=""L7"" />
      <xs:enumeration value=""L8"" />
      <xs:enumeration value=""L9"" />
      <xs:enumeration value=""LA"" />
      <xs:enumeration value=""LB"" />
      <xs:enumeration value=""LC"" />
      <xs:enumeration value=""LD"" />
      <xs:enumeration value=""LE"" />
      <xs:enumeration value=""LF"" />
      <xs:enumeration value=""LG"" />
      <xs:enumeration value=""LH"" />
      <xs:enumeration value=""LI"" />
      <xs:enumeration value=""LJ"" />
      <xs:enumeration value=""LK"" />
      <xs:enumeration value=""LL"" />
      <xs:enumeration value=""LM"" />
      <xs:enumeration value=""LN"" />
      <xs:enumeration value=""LO"" />
      <xs:enumeration value=""LOW"" />
      <xs:enumeration value=""LP"" />
      <xs:enumeration value=""LQ"" />
      <xs:enumeration value=""LR"" />
      <xs:enumeration value=""LS"" />
      <xs:enumeration value=""LT"" />
      <xs:enumeration value=""LU"" />
      <xs:enumeration value=""LV"" />
      <xs:enumeration value=""LW"" />
      <xs:enumeration value=""LX"" />
      <xs:enumeration value=""LY"" />
      <xs:enumeration value=""LZ"" />
      <xs:enumeration value=""M"" />
      <xs:enumeration value=""M0"" />
      <xs:enumeration value=""M1"" />
      <xs:enumeration value=""M2"" />
      <xs:enumeration value=""M3"" />
      <xs:enumeration value=""M4"" />
      <xs:enumeration value=""M5"" />
      <xs:enumeration value=""M6"" />
      <xs:enumeration value=""M7"" />
      <xs:enumeration value=""M8"" />
      <xs:enumeration value=""M9"" />
      <xs:enumeration value=""MA"" />
      <xs:enumeration value=""MB"" />
      <xs:enumeration value=""MC"" />
      <xs:enumeration value=""MD"" />
      <xs:enumeration value=""ME"" />
      <xs:enumeration value=""MF"" />
      <xs:enumeration value=""MG"" />
      <xs:enumeration value=""MH"" />
      <xs:enumeration value=""MI"" />
      <xs:enumeration value=""MJ"" />
      <xs:enumeration value=""MK"" />
      <xs:enumeration value=""ML"" />
      <xs:enumeration value=""MM"" />
      <xs:enumeration value=""MN"" />
      <xs:enumeration value=""MO"" />
      <xs:enumeration value=""MP"" />
      <xs:enumeration value=""MQ"" />
      <xs:enumeration value=""MR"" />
      <xs:enumeration value=""MS"" />
      <xs:enumeration value=""MT"" />
      <xs:enumeration value=""MU"" />
      <xs:enumeration value=""MV"" />
      <xs:enumeration value=""MW"" />
      <xs:enumeration value=""MX"" />
      <xs:enumeration value=""MY"" />
      <xs:enumeration value=""MZ"" />
      <xs:enumeration value=""N"" />
      <xs:enumeration value=""N0"" />
      <xs:enumeration value=""N1"" />
      <xs:enumeration value=""N2"" />
      <xs:enumeration value=""N3"" />
      <xs:enumeration value=""N4"" />
      <xs:enumeration value=""N5"" />
      <xs:enumeration value=""N6"" />
      <xs:enumeration value=""N7"" />
      <xs:enumeration value=""N8"" />
      <xs:enumeration value=""N9"" />
      <xs:enumeration value=""NA"" />
      <xs:enumeration value=""NB"" />
      <xs:enumeration value=""NC"" />
      <xs:enumeration value=""ND"" />
      <xs:enumeration value=""NE"" />
      <xs:enumeration value=""NF"" />
      <xs:enumeration value=""NG"" />
      <xs:enumeration value=""NH"" />
      <xs:enumeration value=""NI"" />
      <xs:enumeration value=""NJ"" />
      <xs:enumeration value=""NK"" />
      <xs:enumeration value=""NL"" />
      <xs:enumeration value=""NM"" />
      <xs:enumeration value=""NN"" />
      <xs:enumeration value=""NO"" />
      <xs:enumeration value=""NP"" />
      <xs:enumeration value=""NQ"" />
      <xs:enumeration value=""NR"" />
      <xs:enumeration value=""NS"" />
      <xs:enumeration value=""NT"" />
      <xs:enumeration value=""NU"" />
      <xs:enumeration value=""NV"" />
      <xs:enumeration value=""NW"" />
      <xs:enumeration value=""NX"" />
      <xs:enumeration value=""NY"" />
      <xs:enumeration value=""NZ"" />
      <xs:enumeration value=""O"" />
      <xs:enumeration value=""O0"" />
      <xs:enumeration value=""O1"" />
      <xs:enumeration value=""O2"" />
      <xs:enumeration value=""O3"" />
      <xs:enumeration value=""O4"" />
      <xs:enumeration value=""O5"" />
      <xs:enumeration value=""O6"" />
      <xs:enumeration value=""O7"" />
      <xs:enumeration value=""O8"" />
      <xs:enumeration value=""O9"" />
      <xs:enumeration value=""OA"" />
      <xs:enumeration value=""OB"" />
      <xs:enumeration value=""OC"" />
      <xs:enumeration value=""OD"" />
      <xs:enumeration value=""OE"" />
      <xs:enumeration value=""OF"" />
      <xs:enumeration value=""OG"" />
      <xs:enumeration value=""OH"" />
      <xs:enumeration value=""OI"" />
      <xs:enumeration value=""OJ"" />
      <xs:enumeration value=""OK"" />
      <xs:enumeration value=""OL"" />
      <xs:enumeration value=""OM"" />
      <xs:enumeration value=""ON"" />
      <xs:enumeration value=""OO"" />
      <xs:enumeration value=""OP"" />
      <xs:enumeration value=""OQ"" />
      <xs:enumeration value=""OR"" />
      <xs:enumeration value=""OS"" />
      <xs:enumeration value=""OT"" />
      <xs:enumeration value=""OU"" />
      <xs:enumeration value=""OV"" />
      <xs:enumeration value=""OW"" />
      <xs:enumeration value=""OX"" />
      <xs:enumeration value=""OY"" />
      <xs:enumeration value=""OZ"" />
      <xs:enumeration value=""P"" />
      <xs:enumeration value=""P0"" />
      <xs:enumeration value=""P1"" />
      <xs:enumeration value=""P2"" />
      <xs:enumeration value=""P3"" />
      <xs:enumeration value=""P4"" />
      <xs:enumeration value=""P5"" />
      <xs:enumeration value=""P6"" />
      <xs:enumeration value=""P7"" />
      <xs:enumeration value=""P8"" />
      <xs:enumeration value=""P9"" />
      <xs:enumeration value=""PA"" />
      <xs:enumeration value=""PB"" />
      <xs:enumeration value=""PC"" />
      <xs:enumeration value=""PCC"" />
      <xs:enumeration value=""PCS"" />
      <xs:enumeration value=""PCV"" />
      <xs:enumeration value=""PD"" />
      <xs:enumeration value=""PE"" />
      <xs:enumeration value=""PF"" />
      <xs:enumeration value=""PG"" />
      <xs:enumeration value=""PH"" />
      <xs:enumeration value=""PI"" />
      <xs:enumeration value=""PJ"" />
      <xs:enumeration value=""PK"" />
      <xs:enumeration value=""PL"" />
      <xs:enumeration value=""PM"" />
      <xs:enumeration value=""PN"" />
      <xs:enumeration value=""PO"" />
      <xs:enumeration value=""PP"" />
      <xs:enumeration value=""PQ"" />
      <xs:enumeration value=""PR"" />
      <xs:enumeration value=""PS"" />
      <xs:enumeration value=""PT"" />
      <xs:enumeration value=""PU"" />
      <xs:enumeration value=""PV"" />
      <xs:enumeration value=""PW"" />
      <xs:enumeration value=""PX"" />
      <xs:enumeration value=""PY"" />
      <xs:enumeration value=""PZ"" />
      <xs:enumeration value=""Q"" />
      <xs:enumeration value=""Q0"" />
      <xs:enumeration value=""Q1"" />
      <xs:enumeration value=""Q2"" />
      <xs:enumeration value=""Q3"" />
      <xs:enumeration value=""Q4"" />
      <xs:enumeration value=""Q5"" />
      <xs:enumeration value=""Q6"" />
      <xs:enumeration value=""Q7"" />
      <xs:enumeration value=""Q8"" />
      <xs:enumeration value=""Q9"" />
      <xs:enumeration value=""QA"" />
      <xs:enumeration value=""QB"" />
      <xs:enumeration value=""QC"" />
      <xs:enumeration value=""QD"" />
      <xs:enumeration value=""QE"" />
      <xs:enumeration value=""QF"" />
      <xs:enumeration value=""QG"" />
      <xs:enumeration value=""QH"" />
      <xs:enumeration value=""QI"" />
      <xs:enumeration value=""QJ"" />
      <xs:enumeration value=""QK"" />
      <xs:enumeration value=""QL"" />
      <xs:enumeration value=""QM"" />
      <xs:enumeration value=""QN"" />
      <xs:enumeration value=""QO"" />
      <xs:enumeration value=""QP"" />
      <xs:enumeration value=""QQ"" />
      <xs:enumeration value=""QR"" />
      <xs:enumeration value=""QS"" />
      <xs:enumeration value=""QT"" />
      <xs:enumeration value=""QU"" />
      <xs:enumeration value=""QV"" />
      <xs:enumeration value=""QW"" />
      <xs:enumeration value=""QX"" />
      <xs:enumeration value=""QY"" />
      <xs:enumeration value=""QZ"" />
      <xs:enumeration value=""R"" />
      <xs:enumeration value=""R0"" />
      <xs:enumeration value=""R1"" />
      <xs:enumeration value=""R2"" />
      <xs:enumeration value=""R3"" />
      <xs:enumeration value=""R4"" />
      <xs:enumeration value=""R5"" />
      <xs:enumeration value=""R6"" />
      <xs:enumeration value=""R7"" />
      <xs:enumeration value=""R8"" />
      <xs:enumeration value=""R9"" />
      <xs:enumeration value=""RA"" />
      <xs:enumeration value=""RB"" />
      <xs:enumeration value=""RC"" />
      <xs:enumeration value=""RD"" />
      <xs:enumeration value=""RE"" />
      <xs:enumeration value=""RF"" />
      <xs:enumeration value=""RG"" />
      <xs:enumeration value=""RH"" />
      <xs:enumeration value=""RI"" />
      <xs:enumeration value=""RJ"" />
      <xs:enumeration value=""RK"" />
      <xs:enumeration value=""RL"" />
      <xs:enumeration value=""RM"" />
      <xs:enumeration value=""RN"" />
      <xs:enumeration value=""RO"" />
      <xs:enumeration value=""RP"" />
      <xs:enumeration value=""RQ"" />
      <xs:enumeration value=""RR"" />
      <xs:enumeration value=""RS"" />
      <xs:enumeration value=""RT"" />
      <xs:enumeration value=""RU"" />
      <xs:enumeration value=""RV"" />
      <xs:enumeration value=""RW"" />
      <xs:enumeration value=""RX"" />
      <xs:enumeration value=""RY"" />
      <xs:enumeration value=""RZ"" />
      <xs:enumeration value=""S"" />
      <xs:enumeration value=""S0"" />
      <xs:enumeration value=""S1"" />
      <xs:enumeration value=""S2"" />
      <xs:enumeration value=""S3"" />
      <xs:enumeration value=""S4"" />
      <xs:enumeration value=""S5"" />
      <xs:enumeration value=""S6"" />
      <xs:enumeration value=""S7"" />
      <xs:enumeration value=""S8"" />
      <xs:enumeration value=""S9"" />
      <xs:enumeration value=""SA"" />
      <xs:enumeration value=""SB"" />
      <xs:enumeration value=""SC"" />
      <xs:enumeration value=""SD"" />
      <xs:enumeration value=""SE"" />
      <xs:enumeration value=""SF"" />
      <xs:enumeration value=""SG"" />
      <xs:enumeration value=""SH"" />
      <xs:enumeration value=""SI"" />
      <xs:enumeration value=""SJ"" />
      <xs:enumeration value=""SK"" />
      <xs:enumeration value=""SL"" />
      <xs:enumeration value=""SM"" />
      <xs:enumeration value=""SN"" />
      <xs:enumeration value=""SO"" />
      <xs:enumeration value=""SOF"" />
      <xs:enumeration value=""SP"" />
      <xs:enumeration value=""SQ"" />
      <xs:enumeration value=""SR"" />
      <xs:enumeration value=""SS"" />
      <xs:enumeration value=""ST"" />
      <xs:enumeration value=""SU"" />
      <xs:enumeration value=""SV"" />
      <xs:enumeration value=""SW"" />
      <xs:enumeration value=""SX"" />
      <xs:enumeration value=""SY"" />
      <xs:enumeration value=""SZ"" />
      <xs:enumeration value=""T"" />
      <xs:enumeration value=""T0"" />
      <xs:enumeration value=""T1"" />
      <xs:enumeration value=""T2"" />
      <xs:enumeration value=""T3"" />
      <xs:enumeration value=""T4"" />
      <xs:enumeration value=""T5"" />
      <xs:enumeration value=""T6"" />
      <xs:enumeration value=""T7"" />
      <xs:enumeration value=""T8"" />
      <xs:enumeration value=""T9"" />
      <xs:enumeration value=""TA"" />
      <xs:enumeration value=""TB"" />
      <xs:enumeration value=""TC"" />
      <xs:enumeration value=""TD"" />
      <xs:enumeration value=""TE"" />
      <xs:enumeration value=""TF"" />
      <xs:enumeration value=""TG"" />
      <xs:enumeration value=""TH"" />
      <xs:enumeration value=""TI"" />
      <xs:enumeration value=""TJ"" />
      <xs:enumeration value=""TK"" />
      <xs:enumeration value=""TL"" />
      <xs:enumeration value=""TM"" />
      <xs:enumeration value=""TN"" />
      <xs:enumeration value=""TO"" />
      <xs:enumeration value=""TP"" />
      <xs:enumeration value=""TQ"" />
      <xs:enumeration value=""TR"" />
      <xs:enumeration value=""TS"" />
      <xs:enumeration value=""TT"" />
      <xs:enumeration value=""TU"" />
      <xs:enumeration value=""TW"" />
      <xs:enumeration value=""TX"" />
      <xs:enumeration value=""TY"" />
      <xs:enumeration value=""TZ"" />
      <xs:enumeration value=""U"" />
      <xs:enumeration value=""U0"" />
      <xs:enumeration value=""U1"" />
      <xs:enumeration value=""U2"" />
      <xs:enumeration value=""U3"" />
      <xs:enumeration value=""U4"" />
      <xs:enumeration value=""U5"" />
      <xs:enumeration value=""U6"" />
      <xs:enumeration value=""U7"" />
      <xs:enumeration value=""U8"" />
      <xs:enumeration value=""U9"" />
      <xs:enumeration value=""UA"" />
      <xs:enumeration value=""UB"" />
      <xs:enumeration value=""UC"" />
      <xs:enumeration value=""UD"" />
      <xs:enumeration value=""UE"" />
      <xs:enumeration value=""UF"" />
      <xs:enumeration value=""UG"" />
      <xs:enumeration value=""UH"" />
      <xs:enumeration value=""UI"" />
      <xs:enumeration value=""UJ"" />
      <xs:enumeration value=""UK"" />
      <xs:enumeration value=""UL"" />
      <xs:enumeration value=""UM"" />
      <xs:enumeration value=""UN"" />
      <xs:enumeration value=""UO"" />
      <xs:enumeration value=""UP"" />
      <xs:enumeration value=""UPF"" />
      <xs:enumeration value=""UQ"" />
      <xs:enumeration value=""UR"" />
      <xs:enumeration value=""US"" />
      <xs:enumeration value=""UT"" />
      <xs:enumeration value=""UU"" />
      <xs:enumeration value=""UV"" />
      <xs:enumeration value=""UW"" />
      <xs:enumeration value=""UX"" />
      <xs:enumeration value=""UY"" />
      <xs:enumeration value=""UZ"" />
      <xs:enumeration value=""V"" />
      <xs:enumeration value=""V0"" />
      <xs:enumeration value=""V1"" />
      <xs:enumeration value=""V2"" />
      <xs:enumeration value=""V3"" />
      <xs:enumeration value=""V4"" />
      <xs:enumeration value=""V5"" />
      <xs:enumeration value=""V6"" />
      <xs:enumeration value=""V7"" />
      <xs:enumeration value=""V8"" />
      <xs:enumeration value=""V9"" />
      <xs:enumeration value=""VA"" />
      <xs:enumeration value=""VB"" />
      <xs:enumeration value=""VC"" />
      <xs:enumeration value=""VD"" />
      <xs:enumeration value=""VE"" />
      <xs:enumeration value=""VES"" />
      <xs:enumeration value=""VF"" />
      <xs:enumeration value=""VG"" />
      <xs:enumeration value=""VH"" />
      <xs:enumeration value=""VI"" />
      <xs:enumeration value=""VJ"" />
      <xs:enumeration value=""VK"" />
      <xs:enumeration value=""VL"" />
      <xs:enumeration value=""VM"" />
      <xs:enumeration value=""VN"" />
      <xs:enumeration value=""VO"" />
      <xs:enumeration value=""VP"" />
      <xs:enumeration value=""VQ"" />
      <xs:enumeration value=""VR"" />
      <xs:enumeration value=""VS"" />
      <xs:enumeration value=""VT"" />
      <xs:enumeration value=""VU"" />
      <xs:enumeration value=""VV"" />
      <xs:enumeration value=""VW"" />
      <xs:enumeration value=""VX"" />
      <xs:enumeration value=""VY"" />
      <xs:enumeration value=""VZ"" />
      <xs:enumeration value=""W"" />
      <xs:enumeration value=""W0"" />
      <xs:enumeration value=""W1"" />
      <xs:enumeration value=""W2"" />
      <xs:enumeration value=""W3"" />
      <xs:enumeration value=""W4"" />
      <xs:enumeration value=""W5"" />
      <xs:enumeration value=""W6"" />
      <xs:enumeration value=""W7"" />
      <xs:enumeration value=""W8"" />
      <xs:enumeration value=""W9"" />
      <xs:enumeration value=""WA"" />
      <xs:enumeration value=""WB"" />
      <xs:enumeration value=""WC"" />
      <xs:enumeration value=""WD"" />
      <xs:enumeration value=""WE"" />
      <xs:enumeration value=""WF"" />
      <xs:enumeration value=""WG"" />
      <xs:enumeration value=""WH"" />
      <xs:enumeration value=""WI"" />
      <xs:enumeration value=""WJ"" />
      <xs:enumeration value=""WK"" />
      <xs:enumeration value=""WL"" />
      <xs:enumeration value=""WM"" />
      <xs:enumeration value=""WN"" />
      <xs:enumeration value=""WO"" />
      <xs:enumeration value=""WP"" />
      <xs:enumeration value=""WQ"" />
      <xs:enumeration value=""WR"" />
      <xs:enumeration value=""WS"" />
      <xs:enumeration value=""WT"" />
      <xs:enumeration value=""WU"" />
      <xs:enumeration value=""WV"" />
      <xs:enumeration value=""WW"" />
      <xs:enumeration value=""WX"" />
      <xs:enumeration value=""WY"" />
      <xs:enumeration value=""WZ"" />
      <xs:enumeration value=""X"" />
      <xs:enumeration value=""X0"" />
      <xs:enumeration value=""X1"" />
      <xs:enumeration value=""X2"" />
      <xs:enumeration value=""X3"" />
      <xs:enumeration value=""X4"" />
      <xs:enumeration value=""X5"" />
      <xs:enumeration value=""X6"" />
      <xs:enumeration value=""X7"" />
      <xs:enumeration value=""X8"" />
      <xs:enumeration value=""X9"" />
      <xs:enumeration value=""XA"" />
      <xs:enumeration value=""XB"" />
      <xs:enumeration value=""XC"" />
      <xs:enumeration value=""XD"" />
      <xs:enumeration value=""XE"" />
      <xs:enumeration value=""XF"" />
      <xs:enumeration value=""XG"" />
      <xs:enumeration value=""XH"" />
      <xs:enumeration value=""XI"" />
      <xs:enumeration value=""XJ"" />
      <xs:enumeration value=""XK"" />
      <xs:enumeration value=""XL"" />
      <xs:enumeration value=""XM"" />
      <xs:enumeration value=""XN"" />
      <xs:enumeration value=""XO"" />
      <xs:enumeration value=""XP"" />
      <xs:enumeration value=""XQ"" />
      <xs:enumeration value=""XR"" />
      <xs:enumeration value=""XS"" />
      <xs:enumeration value=""XT"" />
      <xs:enumeration value=""XU"" />
      <xs:enumeration value=""XV"" />
      <xs:enumeration value=""XW"" />
      <xs:enumeration value=""XX"" />
      <xs:enumeration value=""XY"" />
      <xs:enumeration value=""XZ"" />
      <xs:enumeration value=""Y"" />
      <xs:enumeration value=""Y1"" />
      <xs:enumeration value=""Y2"" />
      <xs:enumeration value=""Y3"" />
      <xs:enumeration value=""Y4"" />
      <xs:enumeration value=""Y5"" />
      <xs:enumeration value=""Y6"" />
      <xs:enumeration value=""Y7"" />
      <xs:enumeration value=""Y8"" />
      <xs:enumeration value=""Y9"" />
      <xs:enumeration value=""YA"" />
      <xs:enumeration value=""YB"" />
      <xs:enumeration value=""YC"" />
      <xs:enumeration value=""YD"" />
      <xs:enumeration value=""YE"" />
      <xs:enumeration value=""YF"" />
      <xs:enumeration value=""YG"" />
      <xs:enumeration value=""YH"" />
      <xs:enumeration value=""YI"" />
      <xs:enumeration value=""YJ"" />
      <xs:enumeration value=""YK"" />
      <xs:enumeration value=""YL"" />
      <xs:enumeration value=""YM"" />
      <xs:enumeration value=""YN"" />
      <xs:enumeration value=""YO"" />
      <xs:enumeration value=""YQ"" />
      <xs:enumeration value=""YR"" />
      <xs:enumeration value=""YS"" />
      <xs:enumeration value=""YT"" />
      <xs:enumeration value=""YU"" />
      <xs:enumeration value=""YV"" />
      <xs:enumeration value=""YW"" />
      <xs:enumeration value=""YX"" />
      <xs:enumeration value=""YY"" />
      <xs:enumeration value=""YZ"" />
      <xs:enumeration value=""Z"" />
      <xs:enumeration value=""Z0"" />
      <xs:enumeration value=""Z1"" />
      <xs:enumeration value=""Z2"" />
      <xs:enumeration value=""Z3"" />
      <xs:enumeration value=""Z4"" />
      <xs:enumeration value=""Z5"" />
      <xs:enumeration value=""Z6"" />
      <xs:enumeration value=""Z7"" />
      <xs:enumeration value=""Z8"" />
      <xs:enumeration value=""Z9"" />
      <xs:enumeration value=""ZA"" />
      <xs:enumeration value=""ZB"" />
      <xs:enumeration value=""ZC"" />
      <xs:enumeration value=""ZD"" />
      <xs:enumeration value=""ZE"" />
      <xs:enumeration value=""ZF"" />
      <xs:enumeration value=""ZG"" />
      <xs:enumeration value=""ZH"" />
      <xs:enumeration value=""ZI"" />
      <xs:enumeration value=""ZJ"" />
      <xs:enumeration value=""ZK"" />
      <xs:enumeration value=""ZL"" />
      <xs:enumeration value=""ZM"" />
      <xs:enumeration value=""ZN"" />
      <xs:enumeration value=""ZO"" />
      <xs:enumeration value=""ZP"" />
      <xs:enumeration value=""ZQ"" />
      <xs:enumeration value=""ZR"" />
      <xs:enumeration value=""ZS"" />
      <xs:enumeration value=""ZT"" />
      <xs:enumeration value=""ZU"" />
      <xs:enumeration value=""ZV"" />
      <xs:enumeration value=""ZW"" />
      <xs:enumeration value=""ZX"" />
      <xs:enumeration value=""ZY"" />
      <xs:enumeration value=""ZZ"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""X12_ID_478"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""C"" />
      <xs:enumeration value=""D"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""X12_ID_115"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""1"" />
      <xs:enumeration value=""2"" />
      <xs:enumeration value=""3"" />
      <xs:enumeration value=""4"" />
      <xs:enumeration value=""5"" />
      <xs:enumeration value=""6"" />
      <xs:enumeration value=""7"" />
      <xs:enumeration value=""A"" />
      <xs:enumeration value=""B"" />
      <xs:enumeration value=""C"" />
      <xs:enumeration value=""D"" />
      <xs:enumeration value=""E"" />
      <xs:enumeration value=""F"" />
      <xs:enumeration value=""G"" />
      <xs:enumeration value=""H"" />
      <xs:enumeration value=""I"" />
      <xs:enumeration value=""J"" />
      <xs:enumeration value=""K"" />
      <xs:enumeration value=""L"" />
      <xs:enumeration value=""M"" />
      <xs:enumeration value=""N"" />
      <xs:enumeration value=""O"" />
      <xs:enumeration value=""P"" />
      <xs:enumeration value=""Q"" />
      <xs:enumeration value=""R"" />
      <xs:enumeration value=""S"" />
      <xs:enumeration value=""T"" />
      <xs:enumeration value=""V"" />
      <xs:enumeration value=""W"" />
      <xs:enumeration value=""Y"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""X12_ID_1300"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""A010"" />
      <xs:enumeration value=""A020"" />
      <xs:enumeration value=""A030"" />
      <xs:enumeration value=""A040"" />
      <xs:enumeration value=""A050"" />
      <xs:enumeration value=""A060"" />
      <xs:enumeration value=""A070"" />
      <xs:enumeration value=""A080"" />
      <xs:enumeration value=""A090"" />
      <xs:enumeration value=""A100"" />
      <xs:enumeration value=""A110"" />
      <xs:enumeration value=""A112"" />
      <xs:enumeration value=""A120"" />
      <xs:enumeration value=""A121"" />
      <xs:enumeration value=""A122"" />
      <xs:enumeration value=""A130"" />
      <xs:enumeration value=""A140"" />
      <xs:enumeration value=""A150"" />
      <xs:enumeration value=""A160"" />
      <xs:enumeration value=""A170"" />
      <xs:enumeration value=""A172"" />
      <xs:enumeration value=""A180"" />
      <xs:enumeration value=""A190"" />
      <xs:enumeration value=""A200"" />
      <xs:enumeration value=""A210"" />
      <xs:enumeration value=""A220"" />
      <xs:enumeration value=""A230"" />
      <xs:enumeration value=""A240"" />
      <xs:enumeration value=""A250"" />
      <xs:enumeration value=""A260"" />
      <xs:enumeration value=""A270"" />
      <xs:enumeration value=""A280"" />
      <xs:enumeration value=""A290"" />
      <xs:enumeration value=""A300"" />
      <xs:enumeration value=""A310"" />
      <xs:enumeration value=""A320"" />
      <xs:enumeration value=""A330"" />
      <xs:enumeration value=""A340"" />
      <xs:enumeration value=""A350"" />
      <xs:enumeration value=""A360"" />
      <xs:enumeration value=""A370"" />
      <xs:enumeration value=""A380"" />
      <xs:enumeration value=""A390"" />
      <xs:enumeration value=""A400"" />
      <xs:enumeration value=""A410"" />
      <xs:enumeration value=""A420"" />
      <xs:enumeration value=""A430"" />
      <xs:enumeration value=""A440"" />
      <xs:enumeration value=""A445"" />
      <xs:enumeration value=""A450"" />
      <xs:enumeration value=""A460"" />
      <xs:enumeration value=""A470"" />
      <xs:enumeration value=""A480"" />
      <xs:enumeration value=""A485"" />
      <xs:enumeration value=""A490"" />
      <xs:enumeration value=""A500"" />
      <xs:enumeration value=""A510"" />
      <xs:enumeration value=""A520"" />
      <xs:enumeration value=""A530"" />
      <xs:enumeration value=""A540"" />
      <xs:enumeration value=""A550"" />
      <xs:enumeration value=""A555"" />
      <xs:enumeration value=""A560"" />
      <xs:enumeration value=""A570"" />
      <xs:enumeration value=""A580"" />
      <xs:enumeration value=""A590"" />
      <xs:enumeration value=""A600"" />
      <xs:enumeration value=""A610"" />
      <xs:enumeration value=""A620"" />
      <xs:enumeration value=""A630"" />
      <xs:enumeration value=""A640"" />
      <xs:enumeration value=""A650"" />
      <xs:enumeration value=""A658"" />
      <xs:enumeration value=""A660"" />
      <xs:enumeration value=""A670"" />
      <xs:enumeration value=""A680"" />
      <xs:enumeration value=""A690"" />
      <xs:enumeration value=""A691"" />
      <xs:enumeration value=""A700"" />
      <xs:enumeration value=""A710"" />
      <xs:enumeration value=""A720"" />
      <xs:enumeration value=""A721"" />
      <xs:enumeration value=""A730"" />
      <xs:enumeration value=""A740"" />
      <xs:enumeration value=""A750"" />
      <xs:enumeration value=""A760"" />
      <xs:enumeration value=""A770"" />
      <xs:enumeration value=""A780"" />
      <xs:enumeration value=""A790"" />
      <xs:enumeration value=""A800"" />
      <xs:enumeration value=""A810"" />
      <xs:enumeration value=""A820"" />
      <xs:enumeration value=""A830"" />
      <xs:enumeration value=""A840"" />
      <xs:enumeration value=""A850"" />
      <xs:enumeration value=""A860"" />
      <xs:enumeration value=""A870"" />
      <xs:enumeration value=""A880"" />
      <xs:enumeration value=""A890"" />
      <xs:enumeration value=""A900"" />
      <xs:enumeration value=""A910"" />
      <xs:enumeration value=""A920"" />
      <xs:enumeration value=""A930"" />
      <xs:enumeration value=""A940"" />
      <xs:enumeration value=""A950"" />
      <xs:enumeration value=""A960"" />
      <xs:enumeration value=""A970"" />
      <xs:enumeration value=""A980"" />
      <xs:enumeration value=""A990"" />
      <xs:enumeration value=""ADOW"" />
      <xs:enumeration value=""ADRW"" />
      <xs:enumeration value=""AFEE"" />
      <xs:enumeration value=""ALPT"" />
      <xs:enumeration value=""B000"" />
      <xs:enumeration value=""B010"" />
      <xs:enumeration value=""B015"" />
      <xs:enumeration value=""B020"" />
      <xs:enumeration value=""B030"" />
      <xs:enumeration value=""B040"" />
      <xs:enumeration value=""B050"" />
      <xs:enumeration value=""B060"" />
      <xs:enumeration value=""B070"" />
      <xs:enumeration value=""B080"" />
      <xs:enumeration value=""B090"" />
      <xs:enumeration value=""B091"" />
      <xs:enumeration value=""B100"" />
      <xs:enumeration value=""B110"" />
      <xs:enumeration value=""B120"" />
      <xs:enumeration value=""B130"" />
      <xs:enumeration value=""B140"" />
      <xs:enumeration value=""B150"" />
      <xs:enumeration value=""B160"" />
      <xs:enumeration value=""B170"" />
      <xs:enumeration value=""B180"" />
      <xs:enumeration value=""B190"" />
      <xs:enumeration value=""B200"" />
      <xs:enumeration value=""B210"" />
      <xs:enumeration value=""B220"" />
      <xs:enumeration value=""B230"" />
      <xs:enumeration value=""B240"" />
      <xs:enumeration value=""B250"" />
      <xs:enumeration value=""B260"" />
      <xs:enumeration value=""B270"" />
      <xs:enumeration value=""B280"" />
      <xs:enumeration value=""B290"" />
      <xs:enumeration value=""B300"" />
      <xs:enumeration value=""B310"" />
      <xs:enumeration value=""B320"" />
      <xs:enumeration value=""B330"" />
      <xs:enumeration value=""B340"" />
      <xs:enumeration value=""B350"" />
      <xs:enumeration value=""B360"" />
      <xs:enumeration value=""B370"" />
      <xs:enumeration value=""B380"" />
      <xs:enumeration value=""B390"" />
      <xs:enumeration value=""B400"" />
      <xs:enumeration value=""B500"" />
      <xs:enumeration value=""B510"" />
      <xs:enumeration value=""B520"" />
      <xs:enumeration value=""B530"" />
      <xs:enumeration value=""B540"" />
      <xs:enumeration value=""B550"" />
      <xs:enumeration value=""B551"" />
      <xs:enumeration value=""B560"" />
      <xs:enumeration value=""B570"" />
      <xs:enumeration value=""B580"" />
      <xs:enumeration value=""B581"" />
      <xs:enumeration value=""B590"" />
      <xs:enumeration value=""B600"" />
      <xs:enumeration value=""B610"" />
      <xs:enumeration value=""B620"" />
      <xs:enumeration value=""B630"" />
      <xs:enumeration value=""B650"" />
      <xs:enumeration value=""B660"" />
      <xs:enumeration value=""B670"" />
      <xs:enumeration value=""B680"" />
      <xs:enumeration value=""B690"" />
      <xs:enumeration value=""B700"" />
      <xs:enumeration value=""B720"" />
      <xs:enumeration value=""B730"" />
      <xs:enumeration value=""B740"" />
      <xs:enumeration value=""B742"" />
      <xs:enumeration value=""B750"" />
      <xs:enumeration value=""B760"" />
      <xs:enumeration value=""B770"" />
      <xs:enumeration value=""B775"" />
      <xs:enumeration value=""B780"" />
      <xs:enumeration value=""B785"" />
      <xs:enumeration value=""B787"" />
      <xs:enumeration value=""B790"" />
      <xs:enumeration value=""B791"" />
      <xs:enumeration value=""B800"" />
      <xs:enumeration value=""B810"" />
      <xs:enumeration value=""B820"" />
      <xs:enumeration value=""B830"" />
      <xs:enumeration value=""B840"" />
      <xs:enumeration value=""B850"" />
      <xs:enumeration value=""B860"" />
      <xs:enumeration value=""B870"" />
      <xs:enumeration value=""B872"" />
      <xs:enumeration value=""B880"" />
      <xs:enumeration value=""B881"" />
      <xs:enumeration value=""B890"" />
      <xs:enumeration value=""B900"" />
      <xs:enumeration value=""B910"" />
      <xs:enumeration value=""B911"" />
      <xs:enumeration value=""B920"" />
      <xs:enumeration value=""B930"" />
      <xs:enumeration value=""B940"" />
      <xs:enumeration value=""B950"" />
      <xs:enumeration value=""B960"" />
      <xs:enumeration value=""B970"" />
      <xs:enumeration value=""B980"" />
      <xs:enumeration value=""B990"" />
      <xs:enumeration value=""B992"" />
      <xs:enumeration value=""B994"" />
      <xs:enumeration value=""B996"" />
      <xs:enumeration value=""B998"" />
      <xs:enumeration value=""BU2T"" />
      <xs:enumeration value=""BU4T"" />
      <xs:enumeration value=""BUAT"" />
      <xs:enumeration value=""BURD"" />
      <xs:enumeration value=""C000"" />
      <xs:enumeration value=""C010"" />
      <xs:enumeration value=""C020"" />
      <xs:enumeration value=""C030"" />
      <xs:enumeration value=""C040"" />
      <xs:enumeration value=""C050"" />
      <xs:enumeration value=""C060"" />
      <xs:enumeration value=""C070"" />
      <xs:enumeration value=""C080"" />
      <xs:enumeration value=""C090"" />
      <xs:enumeration value=""C100"" />
      <xs:enumeration value=""C110"" />
      <xs:enumeration value=""C120"" />
      <xs:enumeration value=""C130"" />
      <xs:enumeration value=""C140"" />
      <xs:enumeration value=""C150"" />
      <xs:enumeration value=""C160"" />
      <xs:enumeration value=""C170"" />
      <xs:enumeration value=""C180"" />
      <xs:enumeration value=""C190"" />
      <xs:enumeration value=""C200"" />
      <xs:enumeration value=""C210"" />
      <xs:enumeration value=""C220"" />
      <xs:enumeration value=""C230"" />
      <xs:enumeration value=""C231"" />
      <xs:enumeration value=""C240"" />
      <xs:enumeration value=""C250"" />
      <xs:enumeration value=""C260"" />
      <xs:enumeration value=""C270"" />
      <xs:enumeration value=""C280"" />
      <xs:enumeration value=""C290"" />
      <xs:enumeration value=""C300"" />
      <xs:enumeration value=""C310"" />
      <xs:enumeration value=""C320"" />
      <xs:enumeration value=""C330"" />
      <xs:enumeration value=""C340"" />
      <xs:enumeration value=""C350"" />
      <xs:enumeration value=""C360"" />
      <xs:enumeration value=""C370"" />
      <xs:enumeration value=""C380"" />
      <xs:enumeration value=""C390"" />
      <xs:enumeration value=""C400"" />
      <xs:enumeration value=""C401"" />
      <xs:enumeration value=""C402"" />
      <xs:enumeration value=""C410"" />
      <xs:enumeration value=""C420"" />
      <xs:enumeration value=""C430"" />
      <xs:enumeration value=""C440"" />
      <xs:enumeration value=""C450"" />
      <xs:enumeration value=""C460"" />
      <xs:enumeration value=""C470"" />
      <xs:enumeration value=""C480"" />
      <xs:enumeration value=""C490"" />
      <xs:enumeration value=""C500"" />
      <xs:enumeration value=""C510"" />
      <xs:enumeration value=""C520"" />
      <xs:enumeration value=""C530"" />
      <xs:enumeration value=""C531"" />
      <xs:enumeration value=""C540"" />
      <xs:enumeration value=""C550"" />
      <xs:enumeration value=""C560"" />
      <xs:enumeration value=""C570"" />
      <xs:enumeration value=""C580"" />
      <xs:enumeration value=""C590"" />
      <xs:enumeration value=""C600"" />
      <xs:enumeration value=""C610"" />
      <xs:enumeration value=""C630"" />
      <xs:enumeration value=""C640"" />
      <xs:enumeration value=""C650"" />
      <xs:enumeration value=""C660"" />
      <xs:enumeration value=""C670"" />
      <xs:enumeration value=""C675"" />
      <xs:enumeration value=""C680"" />
      <xs:enumeration value=""C690"" />
      <xs:enumeration value=""C700"" />
      <xs:enumeration value=""C710"" />
      <xs:enumeration value=""C720"" />
      <xs:enumeration value=""C730"" />
      <xs:enumeration value=""C740"" />
      <xs:enumeration value=""C750"" />
      <xs:enumeration value=""C760"" />
      <xs:enumeration value=""C770"" />
      <xs:enumeration value=""C780"" />
      <xs:enumeration value=""C790"" />
      <xs:enumeration value=""C800"" />
      <xs:enumeration value=""C810"" />
      <xs:enumeration value=""C820"" />
      <xs:enumeration value=""C830"" />
      <xs:enumeration value=""C840"" />
      <xs:enumeration value=""C850"" />
      <xs:enumeration value=""C860"" />
      <xs:enumeration value=""C870"" />
      <xs:enumeration value=""C880"" />
      <xs:enumeration value=""C890"" />
      <xs:enumeration value=""C900"" />
      <xs:enumeration value=""C910"" />
      <xs:enumeration value=""C920"" />
      <xs:enumeration value=""C930"" />
      <xs:enumeration value=""C940"" />
      <xs:enumeration value=""C950"" />
      <xs:enumeration value=""C960"" />
      <xs:enumeration value=""C970"" />
      <xs:enumeration value=""C980"" />
      <xs:enumeration value=""C990"" />
      <xs:enumeration value=""CA2T"" />
      <xs:enumeration value=""CA4T"" />
      <xs:enumeration value=""CFCT"" />
      <xs:enumeration value=""CFLT"" />
      <xs:enumeration value=""CGTT"" />
      <xs:enumeration value=""CLDT"" />
      <xs:enumeration value=""COMM"" />
      <xs:enumeration value=""CRLT"" />
      <xs:enumeration value=""CTLT"" />
      <xs:enumeration value=""CUFT"" />
      <xs:enumeration value=""D000"" />
      <xs:enumeration value=""D010"" />
      <xs:enumeration value=""D015"" />
      <xs:enumeration value=""D020"" />
      <xs:enumeration value=""D025"" />
      <xs:enumeration value=""D030"" />
      <xs:enumeration value=""D040"" />
      <xs:enumeration value=""D050"" />
      <xs:enumeration value=""D060"" />
      <xs:enumeration value=""D070"" />
      <xs:enumeration value=""D080"" />
      <xs:enumeration value=""D100"" />
      <xs:enumeration value=""D101"" />
      <xs:enumeration value=""D103"" />
      <xs:enumeration value=""D110"" />
      <xs:enumeration value=""D120"" />
      <xs:enumeration value=""D130"" />
      <xs:enumeration value=""D140"" />
      <xs:enumeration value=""D141"" />
      <xs:enumeration value=""D142"" />
      <xs:enumeration value=""D143"" />
      <xs:enumeration value=""D144"" />
      <xs:enumeration value=""D150"" />
      <xs:enumeration value=""D160"" />
      <xs:enumeration value=""D170"" />
      <xs:enumeration value=""D180"" />
      <xs:enumeration value=""D190"" />
      <xs:enumeration value=""D200"" />
      <xs:enumeration value=""D210"" />
      <xs:enumeration value=""D220"" />
      <xs:enumeration value=""D230"" />
      <xs:enumeration value=""D240"" />
      <xs:enumeration value=""D242"" />
      <xs:enumeration value=""D244"" />
      <xs:enumeration value=""D246"" />
      <xs:enumeration value=""D250"" />
      <xs:enumeration value=""D260"" />
      <xs:enumeration value=""D270"" />
      <xs:enumeration value=""D280"" />
      <xs:enumeration value=""D290"" />
      <xs:enumeration value=""D292"" />
      <xs:enumeration value=""D300"" />
      <xs:enumeration value=""D301"" />
      <xs:enumeration value=""D310"" />
      <xs:enumeration value=""D320"" />
      <xs:enumeration value=""D330"" />
      <xs:enumeration value=""D340"" />
      <xs:enumeration value=""D350"" />
      <xs:enumeration value=""D360"" />
      <xs:enumeration value=""D370"" />
      <xs:enumeration value=""D380"" />
      <xs:enumeration value=""D390"" />
      <xs:enumeration value=""D400"" />
      <xs:enumeration value=""D410"" />
      <xs:enumeration value=""D420"" />
      <xs:enumeration value=""D430"" />
      <xs:enumeration value=""D440"" />
      <xs:enumeration value=""D450"" />
      <xs:enumeration value=""D460"" />
      <xs:enumeration value=""D470"" />
      <xs:enumeration value=""D480"" />
      <xs:enumeration value=""D490"" />
      <xs:enumeration value=""D500"" />
      <xs:enumeration value=""D501"" />
      <xs:enumeration value=""D502"" />
      <xs:enumeration value=""D510"" />
      <xs:enumeration value=""D520"" />
      <xs:enumeration value=""D530"" />
      <xs:enumeration value=""D540"" />
      <xs:enumeration value=""D550"" />
      <xs:enumeration value=""D560"" />
      <xs:enumeration value=""D570"" />
      <xs:enumeration value=""D580"" />
      <xs:enumeration value=""D590"" />
      <xs:enumeration value=""D600"" />
      <xs:enumeration value=""D610"" />
      <xs:enumeration value=""D620"" />
      <xs:enumeration value=""D630"" />
      <xs:enumeration value=""D640"" />
      <xs:enumeration value=""D650"" />
      <xs:enumeration value=""D655"" />
      <xs:enumeration value=""D660"" />
      <xs:enumeration value=""D670"" />
      <xs:enumeration value=""D680"" />
      <xs:enumeration value=""D690"" />
      <xs:enumeration value=""D700"" />
      <xs:enumeration value=""D701"" />
      <xs:enumeration value=""D710"" />
      <xs:enumeration value=""D711"" />
      <xs:enumeration value=""D720"" />
      <xs:enumeration value=""D730"" />
      <xs:enumeration value=""D740"" />
      <xs:enumeration value=""D750"" />
      <xs:enumeration value=""D760"" />
      <xs:enumeration value=""D770"" />
      <xs:enumeration value=""D780"" />
      <xs:enumeration value=""D790"" />
      <xs:enumeration value=""D800"" />
      <xs:enumeration value=""D810"" />
      <xs:enumeration value=""D820"" />
      <xs:enumeration value=""D830"" />
      <xs:enumeration value=""D840"" />
      <xs:enumeration value=""D850"" />
      <xs:enumeration value=""D860"" />
      <xs:enumeration value=""D870"" />
      <xs:enumeration value=""D880"" />
      <xs:enumeration value=""D890"" />
      <xs:enumeration value=""D900"" />
      <xs:enumeration value=""D910"" />
      <xs:enumeration value=""D920"" />
      <xs:enumeration value=""D930"" />
      <xs:enumeration value=""D940"" />
      <xs:enumeration value=""D950"" />
      <xs:enumeration value=""D960"" />
      <xs:enumeration value=""D970"" />
      <xs:enumeration value=""D980"" />
      <xs:enumeration value=""D990"" />
      <xs:enumeration value=""D995"" />
      <xs:enumeration value=""DCET"" />
      <xs:enumeration value=""DCVT"" />
      <xs:enumeration value=""DDZT"" />
      <xs:enumeration value=""DEZT"" />
      <xs:enumeration value=""DFDT"" />
      <xs:enumeration value=""DGET"" />
      <xs:enumeration value=""DOVT"" />
      <xs:enumeration value=""DPDT"" />
      <xs:enumeration value=""DPET"" />
      <xs:enumeration value=""E000"" />
      <xs:enumeration value=""E010"" />
      <xs:enumeration value=""E020"" />
      <xs:enumeration value=""E022"" />
      <xs:enumeration value=""E030"" />
      <xs:enumeration value=""E040"" />
      <xs:enumeration value=""E050"" />
      <xs:enumeration value=""E060"" />
      <xs:enumeration value=""E063"" />
      <xs:enumeration value=""E065"" />
      <xs:enumeration value=""E067"" />
      <xs:enumeration value=""E068"" />
      <xs:enumeration value=""E069"" />
      <xs:enumeration value=""E070"" />
      <xs:enumeration value=""E080"" />
      <xs:enumeration value=""E090"" />
      <xs:enumeration value=""E100"" />
      <xs:enumeration value=""E110"" />
      <xs:enumeration value=""E120"" />
      <xs:enumeration value=""E130"" />
      <xs:enumeration value=""E140"" />
      <xs:enumeration value=""E150"" />
      <xs:enumeration value=""E160"" />
      <xs:enumeration value=""E170"" />
      <xs:enumeration value=""E180"" />
      <xs:enumeration value=""E190"" />
      <xs:enumeration value=""E191"" />
      <xs:enumeration value=""E192"" />
      <xs:enumeration value=""E193"" />
      <xs:enumeration value=""E200"" />
      <xs:enumeration value=""E210"" />
      <xs:enumeration value=""E220"" />
      <xs:enumeration value=""E230"" />
      <xs:enumeration value=""E240"" />
      <xs:enumeration value=""E250"" />
      <xs:enumeration value=""E260"" />
      <xs:enumeration value=""E270"" />
      <xs:enumeration value=""E280"" />
      <xs:enumeration value=""E290"" />
      <xs:enumeration value=""E300"" />
      <xs:enumeration value=""E310"" />
      <xs:enumeration value=""E320"" />
      <xs:enumeration value=""E330"" />
      <xs:enumeration value=""E340"" />
      <xs:enumeration value=""E350"" />
      <xs:enumeration value=""E360"" />
      <xs:enumeration value=""E370"" />
      <xs:enumeration value=""E380"" />
      <xs:enumeration value=""E381"" />
      <xs:enumeration value=""E382"" />
      <xs:enumeration value=""E384"" />
      <xs:enumeration value=""E386"" />
      <xs:enumeration value=""E388"" />
      <xs:enumeration value=""E389"" />
      <xs:enumeration value=""E390"" />
      <xs:enumeration value=""E400"" />
      <xs:enumeration value=""E410"" />
      <xs:enumeration value=""E420"" />
      <xs:enumeration value=""E430"" />
      <xs:enumeration value=""E440"" />
      <xs:enumeration value=""E450"" />
      <xs:enumeration value=""E460"" />
      <xs:enumeration value=""E470"" />
      <xs:enumeration value=""E480"" />
      <xs:enumeration value=""E485"" />
      <xs:enumeration value=""E490"" />
      <xs:enumeration value=""E500"" />
      <xs:enumeration value=""E510"" />
      <xs:enumeration value=""E520"" />
      <xs:enumeration value=""E530"" />
      <xs:enumeration value=""E540"" />
      <xs:enumeration value=""E550"" />
      <xs:enumeration value=""E560"" />
      <xs:enumeration value=""E570"" />
      <xs:enumeration value=""E580"" />
      <xs:enumeration value=""E585"" />
      <xs:enumeration value=""E590"" />
      <xs:enumeration value=""E600"" />
      <xs:enumeration value=""E610"" />
      <xs:enumeration value=""E620"" />
      <xs:enumeration value=""E630"" />
      <xs:enumeration value=""E640"" />
      <xs:enumeration value=""E650"" />
      <xs:enumeration value=""E660"" />
      <xs:enumeration value=""E670"" />
      <xs:enumeration value=""E680"" />
      <xs:enumeration value=""E690"" />
      <xs:enumeration value=""E695"" />
      <xs:enumeration value=""E700"" />
      <xs:enumeration value=""E710"" />
      <xs:enumeration value=""E720"" />
      <xs:enumeration value=""E730"" />
      <xs:enumeration value=""E740"" />
      <xs:enumeration value=""E750"" />
      <xs:enumeration value=""E760"" />
      <xs:enumeration value=""E770"" />
      <xs:enumeration value=""E780"" />
      <xs:enumeration value=""E790"" />
      <xs:enumeration value=""E800"" />
      <xs:enumeration value=""E805"" />
      <xs:enumeration value=""E810"" />
      <xs:enumeration value=""E820"" />
      <xs:enumeration value=""E830"" />
      <xs:enumeration value=""E840"" />
      <xs:enumeration value=""E850"" />
      <xs:enumeration value=""E860"" />
      <xs:enumeration value=""E870"" />
      <xs:enumeration value=""E880"" />
      <xs:enumeration value=""E890"" />
      <xs:enumeration value=""E900"" />
      <xs:enumeration value=""E910"" />
      <xs:enumeration value=""E920"" />
      <xs:enumeration value=""E930"" />
      <xs:enumeration value=""E940"" />
      <xs:enumeration value=""E950"" />
      <xs:enumeration value=""E960"" />
      <xs:enumeration value=""E970"" />
      <xs:enumeration value=""E980"" />
      <xs:enumeration value=""E990"" />
      <xs:enumeration value=""ENGA"" />
      <xs:enumeration value=""EXLT"" />
      <xs:enumeration value=""F000"" />
      <xs:enumeration value=""F010"" />
      <xs:enumeration value=""F020"" />
      <xs:enumeration value=""F030"" />
      <xs:enumeration value=""F040"" />
      <xs:enumeration value=""F050"" />
      <xs:enumeration value=""F060"" />
      <xs:enumeration value=""F061"" />
      <xs:enumeration value=""F062"" />
      <xs:enumeration value=""F063"" />
      <xs:enumeration value=""F065"" />
      <xs:enumeration value=""F067"" />
      <xs:enumeration value=""F070"" />
      <xs:enumeration value=""F080"" />
      <xs:enumeration value=""F090"" />
      <xs:enumeration value=""F100"" />
      <xs:enumeration value=""F110"" />
      <xs:enumeration value=""F120"" />
      <xs:enumeration value=""F130"" />
      <xs:enumeration value=""F140"" />
      <xs:enumeration value=""F150"" />
      <xs:enumeration value=""F155"" />
      <xs:enumeration value=""F160"" />
      <xs:enumeration value=""F170"" />
      <xs:enumeration value=""F180"" />
      <xs:enumeration value=""F190"" />
      <xs:enumeration value=""F200"" />
      <xs:enumeration value=""F210"" />
      <xs:enumeration value=""F220"" />
      <xs:enumeration value=""F225"" />
      <xs:enumeration value=""F230"" />
      <xs:enumeration value=""F240"" />
      <xs:enumeration value=""F250"" />
      <xs:enumeration value=""F260"" />
      <xs:enumeration value=""F270"" />
      <xs:enumeration value=""F271"" />
      <xs:enumeration value=""F272"" />
      <xs:enumeration value=""F280"" />
      <xs:enumeration value=""F290"" />
      <xs:enumeration value=""F300"" />
      <xs:enumeration value=""F310"" />
      <xs:enumeration value=""F320"" />
      <xs:enumeration value=""F330"" />
      <xs:enumeration value=""F340"" />
      <xs:enumeration value=""F350"" />
      <xs:enumeration value=""F360"" />
      <xs:enumeration value=""F370"" />
      <xs:enumeration value=""F380"" />
      <xs:enumeration value=""F390"" />
      <xs:enumeration value=""F400"" />
      <xs:enumeration value=""F401"" />
      <xs:enumeration value=""F410"" />
      <xs:enumeration value=""F420"" />
      <xs:enumeration value=""F430"" />
      <xs:enumeration value=""F440"" />
      <xs:enumeration value=""F445"" />
      <xs:enumeration value=""F450"" />
      <xs:enumeration value=""F460"" />
      <xs:enumeration value=""F465"" />
      <xs:enumeration value=""F470"" />
      <xs:enumeration value=""F480"" />
      <xs:enumeration value=""F490"" />
      <xs:enumeration value=""F500"" />
      <xs:enumeration value=""F510"" />
      <xs:enumeration value=""F520"" />
      <xs:enumeration value=""F530"" />
      <xs:enumeration value=""F540"" />
      <xs:enumeration value=""F550"" />
      <xs:enumeration value=""F560"" />
      <xs:enumeration value=""F570"" />
      <xs:enumeration value=""F580"" />
      <xs:enumeration value=""F590"" />
      <xs:enumeration value=""F600"" />
      <xs:enumeration value=""F610"" />
      <xs:enumeration value=""F620"" />
      <xs:enumeration value=""F630"" />
      <xs:enumeration value=""F640"" />
      <xs:enumeration value=""F650"" />
      <xs:enumeration value=""F660"" />
      <xs:enumeration value=""F670"" />
      <xs:enumeration value=""F680"" />
      <xs:enumeration value=""F690"" />
      <xs:enumeration value=""F700"" />
      <xs:enumeration value=""F710"" />
      <xs:enumeration value=""F720"" />
      <xs:enumeration value=""F730"" />
      <xs:enumeration value=""F740"" />
      <xs:enumeration value=""F750"" />
      <xs:enumeration value=""F760"" />
      <xs:enumeration value=""F770"" />
      <xs:enumeration value=""F780"" />
      <xs:enumeration value=""F790"" />
      <xs:enumeration value=""F800"" />
      <xs:enumeration value=""F810"" />
      <xs:enumeration value=""F820"" />
      <xs:enumeration value=""F830"" />
      <xs:enumeration value=""F840"" />
      <xs:enumeration value=""F850"" />
      <xs:enumeration value=""F860"" />
      <xs:enumeration value=""F870"" />
      <xs:enumeration value=""F880"" />
      <xs:enumeration value=""F890"" />
      <xs:enumeration value=""F900"" />
      <xs:enumeration value=""F910"" />
      <xs:enumeration value=""F920"" />
      <xs:enumeration value=""F930"" />
      <xs:enumeration value=""F940"" />
      <xs:enumeration value=""F950"" />
      <xs:enumeration value=""F960"" />
      <xs:enumeration value=""F970"" />
      <xs:enumeration value=""F980"" />
      <xs:enumeration value=""F990"" />
      <xs:enumeration value=""F991"" />
      <xs:enumeration value=""FAKT"" />
      <xs:enumeration value=""FLST"" />
      <xs:enumeration value=""G000"" />
      <xs:enumeration value=""G010"" />
      <xs:enumeration value=""G020"" />
      <xs:enumeration value=""G025"" />
      <xs:enumeration value=""G030"" />
      <xs:enumeration value=""G040"" />
      <xs:enumeration value=""G050"" />
      <xs:enumeration value=""G060"" />
      <xs:enumeration value=""G070"" />
      <xs:enumeration value=""G080"" />
      <xs:enumeration value=""G090"" />
      <xs:enumeration value=""G100"" />
      <xs:enumeration value=""G110"" />
      <xs:enumeration value=""G120"" />
      <xs:enumeration value=""G130"" />
      <xs:enumeration value=""G140"" />
      <xs:enumeration value=""G150"" />
      <xs:enumeration value=""G160"" />
      <xs:enumeration value=""G170"" />
      <xs:enumeration value=""G180"" />
      <xs:enumeration value=""G190"" />
      <xs:enumeration value=""G200"" />
      <xs:enumeration value=""G210"" />
      <xs:enumeration value=""G220"" />
      <xs:enumeration value=""G230"" />
      <xs:enumeration value=""G240"" />
      <xs:enumeration value=""G250"" />
      <xs:enumeration value=""G260"" />
      <xs:enumeration value=""G270"" />
      <xs:enumeration value=""G280"" />
      <xs:enumeration value=""G290"" />
      <xs:enumeration value=""G300"" />
      <xs:enumeration value=""G310"" />
      <xs:enumeration value=""G320"" />
      <xs:enumeration value=""G322"" />
      <xs:enumeration value=""G324"" />
      <xs:enumeration value=""G326"" />
      <xs:enumeration value=""G328"" />
      <xs:enumeration value=""G329"" />
      <xs:enumeration value=""G330"" />
      <xs:enumeration value=""G340"" />
      <xs:enumeration value=""G350"" />
      <xs:enumeration value=""G360"" />
      <xs:enumeration value=""G370"" />
      <xs:enumeration value=""G380"" />
      <xs:enumeration value=""G390"" />
      <xs:enumeration value=""G400"" />
      <xs:enumeration value=""G410"" />
      <xs:enumeration value=""G420"" />
      <xs:enumeration value=""G430"" />
      <xs:enumeration value=""G440"" />
      <xs:enumeration value=""G450"" />
      <xs:enumeration value=""G460"" />
      <xs:enumeration value=""G470"" />
      <xs:enumeration value=""G480"" />
      <xs:enumeration value=""G490"" />
      <xs:enumeration value=""G500"" />
      <xs:enumeration value=""G510"" />
      <xs:enumeration value=""G520"" />
      <xs:enumeration value=""G530"" />
      <xs:enumeration value=""G540"" />
      <xs:enumeration value=""G550"" />
      <xs:enumeration value=""G560"" />
      <xs:enumeration value=""G570"" />
      <xs:enumeration value=""G580"" />
      <xs:enumeration value=""G590"" />
      <xs:enumeration value=""G600"" />
      <xs:enumeration value=""G610"" />
      <xs:enumeration value=""G620"" />
      <xs:enumeration value=""G630"" />
      <xs:enumeration value=""G640"" />
      <xs:enumeration value=""G650"" />
      <xs:enumeration value=""G660"" />
      <xs:enumeration value=""G670"" />
      <xs:enumeration value=""G680"" />
      <xs:enumeration value=""G690"" />
      <xs:enumeration value=""G700"" />
      <xs:enumeration value=""G710"" />
      <xs:enumeration value=""G720"" />
      <xs:enumeration value=""G730"" />
      <xs:enumeration value=""G740"" />
      <xs:enumeration value=""G750"" />
      <xs:enumeration value=""G760"" />
      <xs:enumeration value=""G770"" />
      <xs:enumeration value=""G775"" />
      <xs:enumeration value=""G780"" />
      <xs:enumeration value=""G790"" />
      <xs:enumeration value=""G800"" />
      <xs:enumeration value=""G810"" />
      <xs:enumeration value=""G820"" />
      <xs:enumeration value=""G821"" />
      <xs:enumeration value=""G830"" />
      <xs:enumeration value=""G840"" />
      <xs:enumeration value=""G850"" />
      <xs:enumeration value=""G860"" />
      <xs:enumeration value=""G870"" />
      <xs:enumeration value=""G880"" />
      <xs:enumeration value=""G890"" />
      <xs:enumeration value=""G900"" />
      <xs:enumeration value=""G910"" />
      <xs:enumeration value=""G920"" />
      <xs:enumeration value=""G930"" />
      <xs:enumeration value=""G940"" />
      <xs:enumeration value=""G950"" />
      <xs:enumeration value=""G960"" />
      <xs:enumeration value=""G970"" />
      <xs:enumeration value=""G980"" />
      <xs:enumeration value=""G990"" />
      <xs:enumeration value=""GMST"" />
      <xs:enumeration value=""H000"" />
      <xs:enumeration value=""H010"" />
      <xs:enumeration value=""H020"" />
      <xs:enumeration value=""H030"" />
      <xs:enumeration value=""H040"" />
      <xs:enumeration value=""H050"" />
      <xs:enumeration value=""H060"" />
      <xs:enumeration value=""H070"" />
      <xs:enumeration value=""H080"" />
      <xs:enumeration value=""H090"" />
      <xs:enumeration value=""H100"" />
      <xs:enumeration value=""H110"" />
      <xs:enumeration value=""H120"" />
      <xs:enumeration value=""H130"" />
      <xs:enumeration value=""H140"" />
      <xs:enumeration value=""H150"" />
      <xs:enumeration value=""H151"" />
      <xs:enumeration value=""H160"" />
      <xs:enumeration value=""H170"" />
      <xs:enumeration value=""H180"" />
      <xs:enumeration value=""H190"" />
      <xs:enumeration value=""H200"" />
      <xs:enumeration value=""H210"" />
      <xs:enumeration value=""H215"" />
      <xs:enumeration value=""H220"" />
      <xs:enumeration value=""H230"" />
      <xs:enumeration value=""H240"" />
      <xs:enumeration value=""H250"" />
      <xs:enumeration value=""H260"" />
      <xs:enumeration value=""H270"" />
      <xs:enumeration value=""H280"" />
      <xs:enumeration value=""H290"" />
      <xs:enumeration value=""H300"" />
      <xs:enumeration value=""H310"" />
      <xs:enumeration value=""H320"" />
      <xs:enumeration value=""H330"" />
      <xs:enumeration value=""H340"" />
      <xs:enumeration value=""H350"" />
      <xs:enumeration value=""H360"" />
      <xs:enumeration value=""H370"" />
      <xs:enumeration value=""H380"" />
      <xs:enumeration value=""H390"" />
      <xs:enumeration value=""H400"" />
      <xs:enumeration value=""H410"" />
      <xs:enumeration value=""H420"" />
      <xs:enumeration value=""H430"" />
      <xs:enumeration value=""H440"" />
      <xs:enumeration value=""H450"" />
      <xs:enumeration value=""H460"" />
      <xs:enumeration value=""H470"" />
      <xs:enumeration value=""H480"" />
      <xs:enumeration value=""H490"" />
      <xs:enumeration value=""H500"" />
      <xs:enumeration value=""H505"" />
      <xs:enumeration value=""H507"" />
      <xs:enumeration value=""H510"" />
      <xs:enumeration value=""H520"" />
      <xs:enumeration value=""H530"" />
      <xs:enumeration value=""H535"" />
      <xs:enumeration value=""H540"" />
      <xs:enumeration value=""H550"" />
      <xs:enumeration value=""H551"" />
      <xs:enumeration value=""H560"" />
      <xs:enumeration value=""H570"" />
      <xs:enumeration value=""H580"" />
      <xs:enumeration value=""H590"" />
      <xs:enumeration value=""H600"" />
      <xs:enumeration value=""H605"" />
      <xs:enumeration value=""H610"" />
      <xs:enumeration value=""H620"" />
      <xs:enumeration value=""H625"" />
      <xs:enumeration value=""H630"" />
      <xs:enumeration value=""H640"" />
      <xs:enumeration value=""H650"" />
      <xs:enumeration value=""H660"" />
      <xs:enumeration value=""H670"" />
      <xs:enumeration value=""H680"" />
      <xs:enumeration value=""H690"" />
      <xs:enumeration value=""H700"" />
      <xs:enumeration value=""H710"" />
      <xs:enumeration value=""H720"" />
      <xs:enumeration value=""H730"" />
      <xs:enumeration value=""H740"" />
      <xs:enumeration value=""H750"" />
      <xs:enumeration value=""H760"" />
      <xs:enumeration value=""H770"" />
      <xs:enumeration value=""H780"" />
      <xs:enumeration value=""H790"" />
      <xs:enumeration value=""H800"" />
      <xs:enumeration value=""H806"" />
      <xs:enumeration value=""H810"" />
      <xs:enumeration value=""H820"" />
      <xs:enumeration value=""H830"" />
      <xs:enumeration value=""H840"" />
      <xs:enumeration value=""H850"" />
      <xs:enumeration value=""H855"" />
      <xs:enumeration value=""H860"" />
      <xs:enumeration value=""H870"" />
      <xs:enumeration value=""H880"" />
      <xs:enumeration value=""H890"" />
      <xs:enumeration value=""H900"" />
      <xs:enumeration value=""H910"" />
      <xs:enumeration value=""H920"" />
      <xs:enumeration value=""H930"" />
      <xs:enumeration value=""H935"" />
      <xs:enumeration value=""H940"" />
      <xs:enumeration value=""H950"" />
      <xs:enumeration value=""H960"" />
      <xs:enumeration value=""H970"" />
      <xs:enumeration value=""H980"" />
      <xs:enumeration value=""H990"" />
      <xs:enumeration value=""HZDT"" />
      <xs:enumeration value=""I000"" />
      <xs:enumeration value=""I010"" />
      <xs:enumeration value=""I020"" />
      <xs:enumeration value=""I030"" />
      <xs:enumeration value=""I040"" />
      <xs:enumeration value=""I050"" />
      <xs:enumeration value=""I060"" />
      <xs:enumeration value=""I070"" />
      <xs:enumeration value=""I080"" />
      <xs:enumeration value=""I090"" />
      <xs:enumeration value=""I100"" />
      <xs:enumeration value=""I110"" />
      <xs:enumeration value=""I120"" />
      <xs:enumeration value=""I130"" />
      <xs:enumeration value=""I131"" />
      <xs:enumeration value=""I132"" />
      <xs:enumeration value=""I133"" />
      <xs:enumeration value=""I134"" />
      <xs:enumeration value=""I136"" />
      <xs:enumeration value=""I138"" />
      <xs:enumeration value=""I140"" />
      <xs:enumeration value=""I150"" />
      <xs:enumeration value=""I160"" />
      <xs:enumeration value=""I170"" />
      <xs:enumeration value=""I180"" />
      <xs:enumeration value=""I190"" />
      <xs:enumeration value=""I200"" />
      <xs:enumeration value=""I210"" />
      <xs:enumeration value=""I220"" />
      <xs:enumeration value=""I230"" />
      <xs:enumeration value=""I240"" />
      <xs:enumeration value=""I250"" />
      <xs:enumeration value=""I260"" />
      <xs:enumeration value=""I270"" />
      <xs:enumeration value=""I280"" />
      <xs:enumeration value=""I290"" />
      <xs:enumeration value=""I300"" />
      <xs:enumeration value=""I310"" />
      <xs:enumeration value=""I320"" />
      <xs:enumeration value=""I330"" />
      <xs:enumeration value=""I340"" />
      <xs:enumeration value=""I350"" />
      <xs:enumeration value=""I360"" />
      <xs:enumeration value=""I370"" />
      <xs:enumeration value=""I380"" />
      <xs:enumeration value=""I390"" />
      <xs:enumeration value=""I400"" />
      <xs:enumeration value=""I410"" />
      <xs:enumeration value=""I411"" />
      <xs:enumeration value=""I420"" />
      <xs:enumeration value=""I430"" />
      <xs:enumeration value=""I431"" />
      <xs:enumeration value=""I432"" />
      <xs:enumeration value=""I440"" />
      <xs:enumeration value=""I450"" />
      <xs:enumeration value=""I460"" />
      <xs:enumeration value=""I470"" />
      <xs:enumeration value=""I480"" />
      <xs:enumeration value=""I490"" />
      <xs:enumeration value=""I495"" />
      <xs:enumeration value=""I500"" />
      <xs:enumeration value=""I510"" />
      <xs:enumeration value=""I520"" />
      <xs:enumeration value=""I530"" />
      <xs:enumeration value=""I540"" />
      <xs:enumeration value=""I550"" />
      <xs:enumeration value=""I560"" />
      <xs:enumeration value=""I570"" />
      <xs:enumeration value=""I580"" />
      <xs:enumeration value=""I590"" />
      <xs:enumeration value=""I595"" />
      <xs:enumeration value=""I600"" />
      <xs:enumeration value=""I610"" />
      <xs:enumeration value=""I620"" />
      <xs:enumeration value=""I630"" />
      <xs:enumeration value=""I640"" />
      <xs:enumeration value=""I650"" />
      <xs:enumeration value=""I660"" />
      <xs:enumeration value=""I670"" />
      <xs:enumeration value=""I680"" />
      <xs:enumeration value=""I690"" />
      <xs:enumeration value=""I700"" />
      <xs:enumeration value=""I710"" />
      <xs:enumeration value=""I720"" />
      <xs:enumeration value=""I730"" />
      <xs:enumeration value=""I740"" />
      <xs:enumeration value=""I750"" />
      <xs:enumeration value=""I760"" />
      <xs:enumeration value=""IDCT"" />
      <xs:enumeration value=""LC2T"" />
      <xs:enumeration value=""LC4T"" />
      <xs:enumeration value=""LCLT"" />
      <xs:enumeration value=""LECT"" />
      <xs:enumeration value=""LFDT"" />
      <xs:enumeration value=""LMDT"" />
      <xs:enumeration value=""LNDT"" />
      <xs:enumeration value=""LPDT"" />
      <xs:enumeration value=""LQDT"" />
      <xs:enumeration value=""LTET"" />
      <xs:enumeration value=""MATT"" />
      <xs:enumeration value=""OCNT"" />
      <xs:enumeration value=""OFFA"" />
      <xs:enumeration value=""OODT"" />
      <xs:enumeration value=""OTHR"" />
      <xs:enumeration value=""OWCT"" />
      <xs:enumeration value=""PRST"" />
      <xs:enumeration value=""PTAX"" />
      <xs:enumeration value=""PVPT"" />
      <xs:enumeration value=""R020"" />
      <xs:enumeration value=""R030"" />
      <xs:enumeration value=""R040"" />
      <xs:enumeration value=""R060"" />
      <xs:enumeration value=""R080"" />
      <xs:enumeration value=""RDHT"" />
      <xs:enumeration value=""RFMT"" />
      <xs:enumeration value=""RPDT"" />
      <xs:enumeration value=""RSTT"" />
      <xs:enumeration value=""SFBT"" />
      <xs:enumeration value=""SFDT"" />
      <xs:enumeration value=""SFET"" />
      <xs:enumeration value=""SSCT"" />
      <xs:enumeration value=""SSUT"" />
      <xs:enumeration value=""STDT"" />
      <xs:enumeration value=""STFT"" />
      <xs:enumeration value=""STOT"" />
      <xs:enumeration value=""TERT"" />
      <xs:enumeration value=""VCLT"" />
      <xs:enumeration value=""WBBT"" />
      <xs:enumeration value=""WCFT"" />
      <xs:enumeration value=""WFTT"" />
      <xs:enumeration value=""WRBT"" />
      <xs:enumeration value=""WRIT"" />
      <xs:enumeration value=""ZZZZ"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""X12_ID_248"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""A"" />
      <xs:enumeration value=""C"" />
      <xs:enumeration value=""N"" />
      <xs:enumeration value=""P"" />
      <xs:enumeration value=""Q"" />
      <xs:enumeration value=""R"" />
      <xs:enumeration value=""S"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""X12_ID_1196"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""01"" />
      <xs:enumeration value=""02"" />
      <xs:enumeration value=""03"" />
      <xs:enumeration value=""04"" />
      <xs:enumeration value=""05"" />
      <xs:enumeration value=""06"" />
      <xs:enumeration value=""07"" />
      <xs:enumeration value=""08"" />
      <xs:enumeration value=""09"" />
      <xs:enumeration value=""10"" />
      <xs:enumeration value=""11"" />
      <xs:enumeration value=""12"" />
      <xs:enumeration value=""13"" />
      <xs:enumeration value=""14"" />
      <xs:enumeration value=""15"" />
      <xs:enumeration value=""16"" />
      <xs:enumeration value=""17"" />
      <xs:enumeration value=""18"" />
      <xs:enumeration value=""19"" />
      <xs:enumeration value=""20"" />
      <xs:enumeration value=""21"" />
      <xs:enumeration value=""22"" />
      <xs:enumeration value=""23"" />
      <xs:enumeration value=""24"" />
      <xs:enumeration value=""25"" />
      <xs:enumeration value=""26"" />
      <xs:enumeration value=""27"" />
      <xs:enumeration value=""28"" />
      <xs:enumeration value=""29"" />
      <xs:enumeration value=""30"" />
      <xs:enumeration value=""31"" />
      <xs:enumeration value=""32"" />
      <xs:enumeration value=""33"" />
      <xs:enumeration value=""34"" />
      <xs:enumeration value=""35"" />
      <xs:enumeration value=""36"" />
      <xs:enumeration value=""37"" />
      <xs:enumeration value=""38"" />
      <xs:enumeration value=""39"" />
      <xs:enumeration value=""40"" />
      <xs:enumeration value=""41"" />
      <xs:enumeration value=""42"" />
      <xs:enumeration value=""43"" />
      <xs:enumeration value=""44"" />
      <xs:enumeration value=""45"" />
      <xs:enumeration value=""46"" />
      <xs:enumeration value=""47"" />
      <xs:enumeration value=""48"" />
      <xs:enumeration value=""49"" />
      <xs:enumeration value=""50"" />
      <xs:enumeration value=""51"" />
      <xs:enumeration value=""52"" />
      <xs:enumeration value=""53"" />
      <xs:enumeration value=""54"" />
      <xs:enumeration value=""55"" />
      <xs:enumeration value=""56"" />
      <xs:enumeration value=""57"" />
      <xs:enumeration value=""58"" />
      <xs:enumeration value=""59"" />
      <xs:enumeration value=""60"" />
      <xs:enumeration value=""61"" />
      <xs:enumeration value=""62"" />
      <xs:enumeration value=""63"" />
      <xs:enumeration value=""64"" />
      <xs:enumeration value=""65"" />
      <xs:enumeration value=""66"" />
      <xs:enumeration value=""67"" />
      <xs:enumeration value=""70"" />
      <xs:enumeration value=""71"" />
      <xs:enumeration value=""72"" />
      <xs:enumeration value=""73"" />
      <xs:enumeration value=""74"" />
      <xs:enumeration value=""75"" />
      <xs:enumeration value=""77"" />
      <xs:enumeration value=""78"" />
      <xs:enumeration value=""79"" />
      <xs:enumeration value=""80"" />
      <xs:enumeration value=""81"" />
      <xs:enumeration value=""82"" />
      <xs:enumeration value=""83"" />
      <xs:enumeration value=""84"" />
      <xs:enumeration value=""85"" />
      <xs:enumeration value=""86"" />
      <xs:enumeration value=""87"" />
      <xs:enumeration value=""88"" />
      <xs:enumeration value=""A1"" />
      <xs:enumeration value=""A2"" />
      <xs:enumeration value=""A3"" />
      <xs:enumeration value=""A4"" />
      <xs:enumeration value=""A5"" />
      <xs:enumeration value=""A6"" />
      <xs:enumeration value=""A7"" />
      <xs:enumeration value=""A8"" />
      <xs:enumeration value=""A9"" />
      <xs:enumeration value=""AT"" />
      <xs:enumeration value=""B1"" />
      <xs:enumeration value=""B2"" />
      <xs:enumeration value=""B3"" />
      <xs:enumeration value=""B4"" />
      <xs:enumeration value=""B5"" />
      <xs:enumeration value=""BL"" />
      <xs:enumeration value=""BY"" />
      <xs:enumeration value=""C1"" />
      <xs:enumeration value=""C2"" />
      <xs:enumeration value=""C3"" />
      <xs:enumeration value=""C4"" />
      <xs:enumeration value=""CM"" />
      <xs:enumeration value=""CY"" />
      <xs:enumeration value=""D1"" />
      <xs:enumeration value=""D2"" />
      <xs:enumeration value=""D3"" />
      <xs:enumeration value=""D4"" />
      <xs:enumeration value=""D5"" />
      <xs:enumeration value=""D6"" />
      <xs:enumeration value=""D7"" />
      <xs:enumeration value=""E1"" />
      <xs:enumeration value=""E2"" />
      <xs:enumeration value=""E3"" />
      <xs:enumeration value=""E4"" />
      <xs:enumeration value=""EH"" />
      <xs:enumeration value=""ES"" />
      <xs:enumeration value=""EX"" />
      <xs:enumeration value=""F1"" />
      <xs:enumeration value=""F2"" />
      <xs:enumeration value=""F3"" />
      <xs:enumeration value=""F4"" />
      <xs:enumeration value=""FE"" />
      <xs:enumeration value=""FP"" />
      <xs:enumeration value=""FR"" />
      <xs:enumeration value=""G1"" />
      <xs:enumeration value=""G2"" />
      <xs:enumeration value=""G3"" />
      <xs:enumeration value=""G4"" />
      <xs:enumeration value=""G5"" />
      <xs:enumeration value=""H1"" />
      <xs:enumeration value=""H2"" />
      <xs:enumeration value=""H3"" />
      <xs:enumeration value=""H4"" />
      <xs:enumeration value=""H5"" />
      <xs:enumeration value=""I1"" />
      <xs:enumeration value=""IN"" />
      <xs:enumeration value=""J1"" />
      <xs:enumeration value=""J2"" />
      <xs:enumeration value=""K6"" />
      <xs:enumeration value=""L1"" />
      <xs:enumeration value=""LM"" />
      <xs:enumeration value=""M1"" />
      <xs:enumeration value=""MD"" />
      <xs:enumeration value=""MR"" />
      <xs:enumeration value=""N1"" />
      <xs:enumeration value=""NP"" />
      <xs:enumeration value=""P1"" />
      <xs:enumeration value=""P2"" />
      <xs:enumeration value=""P3"" />
      <xs:enumeration value=""P4"" />
      <xs:enumeration value=""P5"" />
      <xs:enumeration value=""P6"" />
      <xs:enumeration value=""RL"" />
      <xs:enumeration value=""SC"" />
      <xs:enumeration value=""TA"" />
      <xs:enumeration value=""TC"" />
      <xs:enumeration value=""TD"" />
      <xs:enumeration value=""TR"" />
      <xs:enumeration value=""TU"" />
      <xs:enumeration value=""UB"" />
      <xs:enumeration value=""ZZ"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""date"">
    <xs:restriction base=""xs:string"">
      <xs:pattern value=""\d*-\d\d-\d\d"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""time"">
    <xs:restriction base=""xs:string"">
      <xs:pattern value=""\d\d:\d\d(:\d\d)?"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""X12_N"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""X12_R"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""X12_AN"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""X12_ID"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""X12_DT"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""X12_TM"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""X12_N0"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""X12_N1"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""X12_N2"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""X12_N3"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""X12_N4"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""X12_N5"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""X12_N6"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""X12_N7"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""X12_N8"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""X12_N9"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
</xs:schema>";
        
        public X12_00401_945() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "X12_00401_945";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
    }
}
