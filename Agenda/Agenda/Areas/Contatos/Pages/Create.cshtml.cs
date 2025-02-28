using Agenda.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;



namespace Agenda.Areas.Contatos.Pages
{
    public class CreateModel : PageModel
    {
        /*
         * criando uma variável do tipo do modelo CONTATO
         * deste modo esse arquivo terá acesso as informações deste modelo
         */

        public Contato Contato { get; set; }

        public void OnGet()
        {
        }
    }
}
