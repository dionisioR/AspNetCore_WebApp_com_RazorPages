using Agenda.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;



namespace Agenda.Areas.Contatos.Pages {
    public class CreateModel : PageModel {

        /*
         * Fornece os dados a controladores e páginas Razor em parâmetros de método e propriedades públicas.
        */
        [BindProperty]


        /*
         * criando uma variável do tipo do modelo CONTATO
         * deste modo esse arquivo terá acesso as informações deste modelo
         */
        public Contato Contato { get; set; }

        public void OnGet() {
        }

        public IActionResult OnPost() {
            if (!ModelState.IsValid) {
                // retorna para a mesma página
                return Page();
            }
            // todo: persistir os dados
            return RedirectToPage("Index");
        }
    }
}
