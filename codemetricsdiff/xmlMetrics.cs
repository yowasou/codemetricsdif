using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codemetricsdiff
{
    public class xmlMetrics
    {
        // メモ: 生成されたコードは、少なくとも .NET Framework 4.5または .NET Core/Standard 2.0 が必要な可能性があります。
        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
        public partial class CodeMetricsReport
        {

            private CodeMetricsReportTargets targetsField;

            private decimal versionField;

            /// <remarks/>
            public CodeMetricsReportTargets Targets
            {
                get
                {
                    return this.targetsField;
                }
                set
                {
                    this.targetsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public decimal Version
            {
                get
                {
                    return this.versionField;
                }
                set
                {
                    this.versionField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class CodeMetricsReportTargets
        {

            private CodeMetricsReportTargetsTarget targetField;

            /// <remarks/>
            public CodeMetricsReportTargetsTarget Target
            {
                get
                {
                    return this.targetField;
                }
                set
                {
                    this.targetField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class CodeMetricsReportTargetsTarget
        {

            private CodeMetricsReportTargetsTargetAssembly assemblyField;

            private string nameField;

            /// <remarks/>
            public CodeMetricsReportTargetsTargetAssembly Assembly
            {
                get
                {
                    return this.assemblyField;
                }
                set
                {
                    this.assemblyField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class CodeMetricsReportTargetsTargetAssembly
        {

            private CodeMetricsReportTargetsTargetAssemblyMetric[] metricsField;

            private CodeMetricsReportTargetsTargetAssemblyNamespace[] namespacesField;

            private string nameField;

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("Metric", IsNullable = false)]
            public CodeMetricsReportTargetsTargetAssemblyMetric[] Metrics
            {
                get
                {
                    return this.metricsField;
                }
                set
                {
                    this.metricsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("Namespace", IsNullable = false)]
            public CodeMetricsReportTargetsTargetAssemblyNamespace[] Namespaces
            {
                get
                {
                    return this.namespacesField;
                }
                set
                {
                    this.namespacesField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class CodeMetricsReportTargetsTargetAssemblyMetric
        {

            private string nameField;

            private ushort valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public ushort Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class CodeMetricsReportTargetsTargetAssemblyNamespace
        {

            private CodeMetricsReportTargetsTargetAssemblyNamespaceMetric[] metricsField;

            private CodeMetricsReportTargetsTargetAssemblyNamespaceNamedType[] typesField;

            private string nameField;

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("Metric", IsNullable = false)]
            public CodeMetricsReportTargetsTargetAssemblyNamespaceMetric[] Metrics
            {
                get
                {
                    return this.metricsField;
                }
                set
                {
                    this.metricsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("NamedType", IsNullable = false)]
            public CodeMetricsReportTargetsTargetAssemblyNamespaceNamedType[] Types
            {
                get
                {
                    return this.typesField;
                }
                set
                {
                    this.typesField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class CodeMetricsReportTargetsTargetAssemblyNamespaceMetric
        {

            private string nameField;

            private ushort valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public ushort Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class CodeMetricsReportTargetsTargetAssemblyNamespaceNamedType
        {

            private CodeMetricsReportTargetsTargetAssemblyNamespaceNamedTypeMetric[] metricsField;

            private CodeMetricsReportTargetsTargetAssemblyNamespaceNamedTypeMembers membersField;

            private string nameField;

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("Metric", IsNullable = false)]
            public CodeMetricsReportTargetsTargetAssemblyNamespaceNamedTypeMetric[] Metrics
            {
                get
                {
                    return this.metricsField;
                }
                set
                {
                    this.metricsField = value;
                }
            }

            /// <remarks/>
            public CodeMetricsReportTargetsTargetAssemblyNamespaceNamedTypeMembers Members
            {
                get
                {
                    return this.membersField;
                }
                set
                {
                    this.membersField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class CodeMetricsReportTargetsTargetAssemblyNamespaceNamedTypeMetric
        {

            private string nameField;

            private ushort valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public ushort Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class CodeMetricsReportTargetsTargetAssemblyNamespaceNamedTypeMembers
        {

            private object[] itemsField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Event", typeof(CodeMetricsReportTargetsTargetAssemblyNamespaceNamedTypeMembersEvent))]
            [System.Xml.Serialization.XmlElementAttribute("Field", typeof(CodeMetricsReportTargetsTargetAssemblyNamespaceNamedTypeMembersField))]
            [System.Xml.Serialization.XmlElementAttribute("Method", typeof(CodeMetricsReportTargetsTargetAssemblyNamespaceNamedTypeMembersMethod))]
            [System.Xml.Serialization.XmlElementAttribute("Property", typeof(CodeMetricsReportTargetsTargetAssemblyNamespaceNamedTypeMembersProperty))]
            public object[] Items
            {
                get
                {
                    return this.itemsField;
                }
                set
                {
                    this.itemsField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class CodeMetricsReportTargetsTargetAssemblyNamespaceNamedTypeMembersEvent
        {

            private CodeMetricsReportTargetsTargetAssemblyNamespaceNamedTypeMembersEventMetric[] metricsField;

            private string nameField;

            private string fileField;

            private byte lineField;

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("Metric", IsNullable = false)]
            public CodeMetricsReportTargetsTargetAssemblyNamespaceNamedTypeMembersEventMetric[] Metrics
            {
                get
                {
                    return this.metricsField;
                }
                set
                {
                    this.metricsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string File
            {
                get
                {
                    return this.fileField;
                }
                set
                {
                    this.fileField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte Line
            {
                get
                {
                    return this.lineField;
                }
                set
                {
                    this.lineField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class CodeMetricsReportTargetsTargetAssemblyNamespaceNamedTypeMembersEventMetric
        {

            private string nameField;

            private byte valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class CodeMetricsReportTargetsTargetAssemblyNamespaceNamedTypeMembersField
        {

            private CodeMetricsReportTargetsTargetAssemblyNamespaceNamedTypeMembersFieldMetric[] metricsField;

            private string nameField;

            private string fileField;

            private byte lineField;

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("Metric", IsNullable = false)]
            public CodeMetricsReportTargetsTargetAssemblyNamespaceNamedTypeMembersFieldMetric[] Metrics
            {
                get
                {
                    return this.metricsField;
                }
                set
                {
                    this.metricsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string File
            {
                get
                {
                    return this.fileField;
                }
                set
                {
                    this.fileField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte Line
            {
                get
                {
                    return this.lineField;
                }
                set
                {
                    this.lineField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class CodeMetricsReportTargetsTargetAssemblyNamespaceNamedTypeMembersFieldMetric
        {

            private string nameField;

            private byte valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class CodeMetricsReportTargetsTargetAssemblyNamespaceNamedTypeMembersMethod
        {

            private CodeMetricsReportTargetsTargetAssemblyNamespaceNamedTypeMembersMethodMetric[] metricsField;

            private string nameField;

            private string fileField;

            private ushort lineField;

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("Metric", IsNullable = false)]
            public CodeMetricsReportTargetsTargetAssemblyNamespaceNamedTypeMembersMethodMetric[] Metrics
            {
                get
                {
                    return this.metricsField;
                }
                set
                {
                    this.metricsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string File
            {
                get
                {
                    return this.fileField;
                }
                set
                {
                    this.fileField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public ushort Line
            {
                get
                {
                    return this.lineField;
                }
                set
                {
                    this.lineField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class CodeMetricsReportTargetsTargetAssemblyNamespaceNamedTypeMembersMethodMetric
        {

            private string nameField;

            private byte valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class CodeMetricsReportTargetsTargetAssemblyNamespaceNamedTypeMembersProperty
        {

            private CodeMetricsReportTargetsTargetAssemblyNamespaceNamedTypeMembersPropertyMetric[] metricsField;

            private CodeMetricsReportTargetsTargetAssemblyNamespaceNamedTypeMembersPropertyMethod[] accessorsField;

            private string nameField;

            private string fileField;

            private ushort lineField;

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("Metric", IsNullable = false)]
            public CodeMetricsReportTargetsTargetAssemblyNamespaceNamedTypeMembersPropertyMetric[] Metrics
            {
                get
                {
                    return this.metricsField;
                }
                set
                {
                    this.metricsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("Method", IsNullable = false)]
            public CodeMetricsReportTargetsTargetAssemblyNamespaceNamedTypeMembersPropertyMethod[] Accessors
            {
                get
                {
                    return this.accessorsField;
                }
                set
                {
                    this.accessorsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string File
            {
                get
                {
                    return this.fileField;
                }
                set
                {
                    this.fileField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public ushort Line
            {
                get
                {
                    return this.lineField;
                }
                set
                {
                    this.lineField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class CodeMetricsReportTargetsTargetAssemblyNamespaceNamedTypeMembersPropertyMetric
        {

            private string nameField;

            private byte valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class CodeMetricsReportTargetsTargetAssemblyNamespaceNamedTypeMembersPropertyMethod
        {

            private CodeMetricsReportTargetsTargetAssemblyNamespaceNamedTypeMembersPropertyMethodMetric[] metricsField;

            private string nameField;

            private string fileField;

            private ushort lineField;

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("Metric", IsNullable = false)]
            public CodeMetricsReportTargetsTargetAssemblyNamespaceNamedTypeMembersPropertyMethodMetric[] Metrics
            {
                get
                {
                    return this.metricsField;
                }
                set
                {
                    this.metricsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string File
            {
                get
                {
                    return this.fileField;
                }
                set
                {
                    this.fileField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public ushort Line
            {
                get
                {
                    return this.lineField;
                }
                set
                {
                    this.lineField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class CodeMetricsReportTargetsTargetAssemblyNamespaceNamedTypeMembersPropertyMethodMetric
        {

            private string nameField;

            private byte valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }


    }
}
