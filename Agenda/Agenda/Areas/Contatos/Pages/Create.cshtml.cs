using Agenda.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;



namespace Agenda.Areas.Contatos.Pages
{
    public class CreateModel : PageModel
    {
        /*
         * criando uma vari�vel do tipo do modelo CONTATO
         * deste modo esse arquivo ter� acesso as informa��es deste modelo
         */

        public Contato Contato { get; set; }

        public void OnGet()
        {
        }
    }
}
