using ScalemateWPF.Views.Helpers;

namespace ScalemateWPF.Views.ExecuteScale
{
    class ExecuteScaleViewModel : ObservableObject, IPageViewModel
    {
        public string Name => "Executar teste";

        public int Column => 1;
    }
}
