using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace BillCalculator
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class WaterTips : Page
    {
        public WaterTips()
        {
            this.InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            string StrText = "١- لا تترك الصنبور مفتوحا طوال فترة حلاقة الذقن، والوضوء، وغسل اليدين، وتنظيف الأسنان.\n٢- تأكد من إغلاق الصنابير كلها بشكل محكم قبل النوم وعند مغادرة المنزل، وإصلاح أى تسرب بها فى أسرع وقت.\n٣- لا تسكبى الماء أثناء التنظيف ويُستحسن استخدام وعاء مملوء بالماء أو قماشة مبللة.\n٤ - لا تستخدم «السيفون» إلا عند الحاجة فقط ويمكنك وضع حجر أو كيس مملوء بالماء بداخله، للتقليل من كمية الماء المهدرة بداخله.\n٥ - غسل الفواكه والخضراوات فى إناء مملوء بالماء بدلاً من غسلها تحتالصنبور.\n٦ - عدم غسل السجاد، والمفروشات الأرضية باستخدام خراطيم المياه، بل باستخدام أجهزة التنظيف الخاصة، أو بواسطة الشركات المتخصصة.\n٧٠ مراقبة الأطفال وحثهم على عدم الاستهتار فى التعامل مع المياه والحفاظ عليها.\n٨ - لا تضع  المواد المجمدة تحت المياه لإذابة الثلج ويقضى الغرض استخراجها قبل استخدامها بوقت كاف من الثلاجة.\n٩ - استخدم «الدش» عند الاستحمام مع مراعاة غلقه وفتحه عند الحاجة بدلا من استخدام «البانيو»، الذى يستهلك ما يزيد على ١٤٠ لتراً فى المرة الواحدة.\n١٠ - اختيار نباتات الزينة بعناية كالصباح حتى تتحمل الجفاف.";
            ContentTextBlock.Text = StrText;
        }
    }
}
