using System;
using Xamarin.Forms;

namespace Tanker.Mobile.Core.Domain.Entities
{
    public class MenuPageItem
    {
        public string Title { get; set; }
        public ImageSource Icon { get; set; }
        public Type TargetType { get; set; }
    }
}