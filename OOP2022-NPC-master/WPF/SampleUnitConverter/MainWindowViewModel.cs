using System.Linq;
using System.Windows.Input;

namespace SampleUnitConverter {
    public class MainWindowViewModel : ViewModel {
        private double metricValue, imperialvalue;

        public double MetricValue {
            get { return this.metricValue; }
            set
            {
                this.metricValue = value;
                this.OnPropertyChanged();
            }
        }
        public double Imperialvalue {
            get { return this.imperialvalue; }
            set
            {
                this.imperialvalue = value;
                this.OnPropertyChanged();
            }
        }

        //上のコンボボックスで選択されている値（単位）
        public MetricUnit CurrentMetricUnit { get;  set; }

        //下のコンボボックスで選択されている値（単位）
        public ImperialUnit CurrentImperialUnit { get;  set; }

        //▲ボタンで呼ばれるコマンド
        public ICommand ImperialUnitToMetric { get; private set; }

        //▼ボタンで呼ばれるコマンド
        public ICommand MetricToImperalUnit { get; private set; }

        public MainWindowViewModel() {
            this.CurrentMetricUnit = MetricUnit.Units.First();
            this.CurrentImperialUnit = ImperialUnit.Units.First();
            this.MetricToImperalUnit = new DelegateCommand (
                ()=>this.imperialvalue = this.CurrentImperialUnit.FromMetricUnit(
                    this.CurrentMetricUnit,this.MetricValue)
            );

            this.ImperialUnitToMetric = new DelegateCommand(
                () => this.MetricValue = this.CurrentMetricUnit.FromImperialUnit(
                    this.CurrentImperialUnit, this.imperialvalue)
            );
        }
    }
}
