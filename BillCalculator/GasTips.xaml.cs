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
    public sealed partial class GasTips : Page
    {
        public GasTips()
        {
            this.InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            string StrText = "مع انخفاض درجات الحرارة وتدنيها المتكرر في فصل الشتاء، يكثر استهلاك الغاز الطبيعي خاصة في بلدان البحر المتوسط، حيث يعتمدون عليه كثيرا في تدفئة المنزل وتسخين الماء وغيرها من الاستخدامات اليومية، الأمر الذي يرهق ميزانية البيت ليشكل عبئا على فاتورة الغاز الطبيعي أو شراء أسطوانات الغاز. فإليك بعض النصائح التي تساعدك على خفض استهلاكك من الغاز أو أسطوانات الغاز:\r1-استبدل السخان الذي يعمل بالغاز والأسطوانات بأخرى تعمل بالطاقة الشمسية.\r2-تأكد من سلامة جميع الوصلات والأنابيب، للتأكد من عدم وجود تسرب بها ولحفظ السلامة والأمان لك ولأسرتك.\r3-استخدم قدر الضغط في الطبخ، فهو يستهلك وقت أقل في تسوية الطعام وبالتالي استهلاك أقل للغاز المستخدم.\r4-عند استخدامك لإناء عادي في طبخ الطعام، قوم بغلقه بغطاء محكم كي لا يتسرب البخار والحرارة من داخله فتخفضّي من وقت واستهلاك الغاز.\r5-عند الإنتهاء من استعمال الغاز اغلق جميع المحابس لضمان عدم حدوث أي تسريب.\r6-راقب عداد الغاز الموجود داخل البيت للتأكد من كفاءته، وإذا لاحظت أي أخطاء أبلغ الشركة بسرعة.\r7-عند تشغيلك للغاز لغلي الماء لعمل الشاي والمشروبات وما إلى ذلك استخدم ما تحتاجه فقط من الماء في الغليان.\r8-إذا كان لديك سخان يعمل بالغاز، فلا تسرف في استخدام الماء لغسيل الأطباق والخضروات.";
            ContentTextBlock.Text = StrText;
        }
    }
}
