using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Cel.Modelo.web.ViewModels
{
    public class FeedListViewModel
    {

        public IEnumerable<FeedViewModel> Feeds { get; set; }

        [Required(ErrorMessage = "Texto deve ser informado")]
        [Display(Name = "Feed")]
        public string TextoFeedNovo { get; set; }

    }
}