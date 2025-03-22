using Agenda.Model;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;



namespace Agenda.Areas.Contatos.Pages {
    public class CreateModel : PageModel {

        private readonly IWebHostEnvironment _env;

        /*
         * Fornece os dados a controladores e p�ginas Razor em par�metros de m�todo e propriedades p�blicas.
        */
        [BindProperty]


        /*
         * criando uma vari�vel do tipo do modelo CONTATO
         * deste modo esse arquivo ter� acesso as informa��es deste modelo
         */
        public Contato Contato { get; set; }


        // Construtor
        public CreateModel(IWebHostEnvironment env)
        {
            _env = env;
        }

        public void OnGet() {
        }

        public async Task<IActionResult> OnPostAsync(CancellationToken cancellationToken) {

            if (!ModelState.IsValid) {
                // retorna para a mesma p�gina
                return Page();
            }

            // Salvar a imagem
            Contato.Id = Guid.NewGuid();
            Contato.FotoUrl = Path.Combine("Images", "Contatos", $"{Contato.Id}-{Contato.Foto.FileName}");

            // _env.WebRootPath - pega o caminho do servidor at� a pasta wwwroot
            var fullPath = Path.Combine(_env.WebRootPath,Contato.FotoUrl);
            using(var fileStream = new FileStream(fullPath, FileMode.Create)) {
                await Contato.Foto.CopyToAsync(fileStream, cancellationToken);
            }
            
            // todo: persistir os dados
            return RedirectToPage("Index");
        }
    }
}
