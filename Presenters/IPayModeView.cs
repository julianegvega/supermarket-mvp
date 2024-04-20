

namespace supermarkett_mvp.Presenters
{
    internal interface IPayModeView
    {
        Action<object?, EventArgs> SearchEvent { get; set; }
        Action<object?, EventArgs> AddNewEvent { get; set; }
        Action<object?, EventArgs> EditEvent { get; set; }
        Action<object?, EventArgs> DeleteEvent { get; set; }
        Action<object?, EventArgs> SaveEvent { get; set; }
        Action<object?, EventArgs> CancelEvent { get; set; }
        bool PayModeId { get; set; }
        object PayModeName { get; set; }
        object PayModeObservation { get; set; }
        bool IsEdit { get; set; }
        string Message { get; set; }
        bool IsSuccesful { get; set; }
        string? SearchValue { get; set; }

        void SetPayModeListBildingSource(BindingSource payModeBindingSource);
        void Show();
    }
}