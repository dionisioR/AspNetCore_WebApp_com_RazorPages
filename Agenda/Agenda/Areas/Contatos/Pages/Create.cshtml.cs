using Agenda.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;



namespace Agenda.Areas.Contatos.Pages {
    public class CreateModel : PageModel {

        /*
         * Fornece os dados a controladores e p�ginas Razor em par�metros de m�todo e propriedades p�blicas.
        */
        [BindProperty]


        /*
         * criando uma vari�vel do tipo do modelo CONTATO
         * deste modo esse arquivo ter� acesso as informa��es deste modelo
         */
        public Contato Contato { get; set; }

        public void OnGet() {
        }

        public IActionResult OnPost() {
            if (!ModelState.IsValid) {
                // retorna para a mesma p�gina
                return Page();
            }
            // todo: persistir os dados
            return RedirectToPage("Index");
        }
    }
}
