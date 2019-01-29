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
    public sealed partial class ElectricityTips : Page
    {
        public ElectricityTips()
        {
            this.InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            string StrText = "لا شك أن توفير الطاقة الكهربائية له فوائد عديدة، فهى تقلل من القيمة التى تدفعها فى فاتورة الكهرباء، كما أن ترشيد استهلاك الكهرباء يعد أحد الركائز الأساسية للاستغلال الأمثل لمصادر الطاقة بالدولة. \rنقدم مجموعة من النصائح التى تساعدك على ترشيد استهلاك الكهرباء فى المنزل:\r 1)الاعتماد على الإضاءة الطبيعية أثناء النهار، وتقليل استخدام المصابيح من خلال ترك النوافذ مفتوحة، فذلك سوف يساعد على تقليل استهلاك الكهرباء.\r 2)استخدم المصابيح الموفرة بدلا من المصابيح العادية، فهى تعطى إضاءة أقوى إضافة إلى أن المصابيح العادية تستهلك أضعاف الطاقة التى تستهلكها المصابيح الموفرة.\r 3)أطفئ المصابيح التى لا تحتاجها بالمنزل حتى ولو لبضع دقائق فذلك سوف يساعد على توفير الكهرباء.\r 4)عدم تشغيل الأجهزة الكهربائية مثل الكمبيوتر والتليفزيون لفترات طويلة دون الحاجة إليها.\r 5)إذا كنت تحتاج لاستخدام الكمبيوتر لفترة طويلة فيفضل استخدام اللاب توب بدلا من الديسك توب، وذلك لأنه يستهلك ثلث الطاقة التى يستهلكها جهاز الكمبيوتر العادي.\r 6)تجنب استخدام المدفأة الكهربائية لفترات طويلة لتدفئة المنزل فهى تستهلك الكثير من الطاقة، فمن الممكن استخدام طرق أخرى للتدفئة مثل استخدام السجاد المبطن أو الستائر السميكة.\r 7)أطفئ سخان المياه فى حال عدم الحاجة إليه.\r 8)فى الصيف نحتاج إلى التلطيف من حرارة الجو، ولكن يفضل التقليل من استخدام التكييف لفترة طويلة، لأنه يستهلك كمية كبيرة من الكهرباء فيمكن استخدام المروحة أو فتح النوافذ كوسيلة لتقليل درجة الحرارة بشكل يساعد على توفير الكهرباء.";
            ContentTextBlock.Text = StrText;
        }
    }
}
