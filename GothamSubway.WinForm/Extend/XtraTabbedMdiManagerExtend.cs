using System.ComponentModel;

namespace GothamSubway.WinForm
{
    public class XtraTabbedMdiManagerExtend : DevExpress.XtraTabbedMdi.XtraTabbedMdiManager, DevExpress.XtraTab.IXtraTabProperties
    {
        public XtraTabbedMdiManagerExtend(IContainer container) : base(container) { }
        DevExpress.Utils.DefaultBoolean DevExpress.XtraTab.IXtraTabProperties.ShowTabHeader { get { return DevExpress.Utils.DefaultBoolean.False; } }
    }
}
