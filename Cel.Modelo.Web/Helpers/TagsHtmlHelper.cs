using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace Cel.Modelo.web.Helpers
{
    public class TagsHtmlHelper
    {
        public static MvcHtmlString LinkModal(string url, string nome, int width, int height, string classe)
        {
            //var botao = "<input onclick='location.href = '{1}';' class='btn trans action {0} ' value='{3}' data-target='#{2}'  type='Button'></input>";
            var id = "Modal" + Guid.NewGuid();

            var str = new StringBuilder().AppendFormat("<a data-toggle='modal'   role='button' class='{0}' href='{1}' data-target='#{2}'>{3}</a>", classe, url, id, nome)
                                         .AppendLine("<script>jQuery(document).ready(function () {")
                                         .AppendLine("var $div = jQuery('#PanelModal');")
                                         .AppendFormat("var divClone = $div.clone().prop('id', '{0}' );", id)
                                         .AppendLine("$div.after(divClone);")
                                         .AppendFormat("jQuery('#{0} .modal-dialog').width('{1}');", id, width + "%")
                                         .AppendFormat("jQuery('#{0} .modal-dialog').height('{1}');", id, height + "%")
                                         .AppendLine("})</script>").ToString();

            return new MvcHtmlString(str);
        }

        public static MvcHtmlString ButtonSubmitConfirm(string value)
        {
            var tagBuilder = new TagBuilder("input");
            tagBuilder.Attributes.Add("type", "submit");
            tagBuilder.Attributes.Add("value", "Salvar");
            tagBuilder.Attributes.Add("class", "btn btn-primary confirm-alert");

            return new MvcHtmlString(tagBuilder.ToString());
        }

    }
}