// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.38967
//    <NameSpace>schemas</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>False</IncludeSerializeMethod><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net20</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>False</GenerateXMLAttributes><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>False</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;
using NPOI.OpenXmlFormats.Dml;
using System.Xml;
using System.IO;
using NPOI.OpenXml4Net.Util;


namespace NPOI.OpenXmlFormats.Spreadsheet
{
    public class ST_UnsignedshortHex
    {
        string stringValueField = null;
        public string StringValue
        {
            get { return stringValueField; }
            set { stringValueField = value; }
        }
        public byte[] ToBytes()
        {
            throw new NotImplementedException();
        }
    }

    [Serializable]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    public class CT_GradientFill
    {

        private List<CT_GradientStop> stopField = null; // 0..*

        private ST_GradientType typeField = ST_GradientType.NONE;

        private double? degreeField = null;

        private double? leftField = null;

        private double? rightField = null;

        private double? topField = null;

        private double? bottomField = null;

        [XmlElement]
        public List<CT_GradientStop> stop
        {
            get { return this.stopField; }
            set { this.stopField = value; }
        }

        [XmlAttribute]
        [DefaultValue(ST_GradientType.linear)]
        public ST_GradientType type
        {
            get { return ST_GradientType.NONE == this.typeField ? ST_GradientType.linear : this.typeField; }
            set { this.typeField = value; }
        }
        [XmlIgnore]
        public bool typeSpecified
        {
            get { return (ST_GradientType.NONE != typeField); }
        }

        [XmlAttribute]
        [DefaultValue(0D)]
        public double degree
        {
            get { return null == this.degreeField ? 0.0 : (double)degreeField; }
            set { this.degreeField = value; }
        }
        [XmlIgnore]
        public bool degreeSpecified
        {
            get { return (null != degreeField); }
        }

        [XmlAttribute]
        [DefaultValue(0D)]
        public double left
        {
            get { return null == this.leftField ? 0.0 : (double)this.leftField; }
            set { this.leftField = value; }
        }
        [XmlIgnore]
        public bool Specified
        {
            get { return (null != leftField); }
        }

        [XmlAttribute]
        [DefaultValue(0D)]
        public double right
        {
            get { return null == this.rightField ? 0.0 : (double)this.rightField; }
            set { this.rightField = value; }
        }
        [XmlIgnore]
        public bool rightSpecified
        {
            get { return (null != rightField); }
        }

        [XmlAttribute]
        [DefaultValue(0D)]
        public double top
        {
            get { return null == this.topField ? 0.0 : (double)this.topField; }
            set { this.topField = value; }
        }
        [XmlIgnore]
        public bool topSpecified
        {
            get { return (null != topField); }
        }

        [XmlAttribute]
        [DefaultValue(0D)]
        public double bottom
        {
            get { return null == this.bottomField ? 0.0 : (double)this.bottomField; }
            set { this.bottomField = value; }
        }
        [XmlIgnore]
        public bool bottomSpecified
        {
            get { return (null != bottomField); }
        }
    }

    public class CT_XStringElement
    {

        private string vField;

        public string v
        {
            get
            {
                return this.vField;
            }
            set
            {
                this.vField = value;
            }
        }
    }
    [Serializable]
    [System.Diagnostics.DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    public class CT_Extension
    {

        private System.Xml.XmlElement anyField;

        private string uriField = null;

        [XmlAnyElement(Order = 0)]
        public System.Xml.XmlElement Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
        [XmlAttribute(DataType = "token")]
        public string uri
        {
            get
            {
                return this.uriField;
            }
            set
            {
                this.uriField = value;
            }
        }
        [XmlIgnore]
        public bool uriSpecified
        {
            get { return (null != uriField); }
        }

        public static CT_Extension Parse(XmlNode node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_Extension ctObj = new CT_Extension();
            ctObj.uri = XmlHelper.ReadString(node.Attributes["uri"]);
            //foreach (XmlNode childNode in node.ChildNodes)
            //{
            //    if (childNode.LocalName == "Any")
            //        ctObj.Any = XmlElement.Parse(childNode, namespaceManager);
            //}
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "uri", this.uri);
            sw.Write(">");
            //if (this.Any != null)
            //    this.Any.Write(sw, "Any");
            sw.Write(string.Format("</{0}>", nodeName));
        }
    }

    [Serializable]
    [System.Diagnostics.DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    public class CT_ExtensionList
    {
        private List<CT_Extension> extField = new List<CT_Extension>(); // 0..*

        public CT_ExtensionList Copy()
        {
            CT_ExtensionList obj = new CT_ExtensionList();
            obj.ext = new List<CT_Extension>(this.ext);
            return obj;
        }

        //[XmlArray(Order = 0)]
        [XmlElement]
        public List<CT_Extension> ext
        {
            get
            {
                return this.extField;
            }
            set
            {
                this.extField = value;
            }
        }

        public static CT_ExtensionList Parse(XmlNode node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_ExtensionList ctObj = new CT_ExtensionList();
            ctObj.ext = new List<CT_Extension>();
            foreach (XmlNode childNode in node.ChildNodes)
            {
                if (childNode.LocalName == "ext")
                    ctObj.ext.Add(CT_Extension.Parse(childNode, namespaceManager));
            }
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            sw.Write(">");
            if (this.ext != null)
            {
                foreach (CT_Extension x in this.ext)
                {
                    x.Write(sw, "ext");
                }
            }
            sw.Write(string.Format("</{0}>", nodeName));
        }

    }
}
