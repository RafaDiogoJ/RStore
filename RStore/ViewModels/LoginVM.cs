using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RStore.ViewModels
{
    public class LoginVM
    {
        [Display(Name="Email ou Nome de Usuário", Prompt = "Informe seu Email ou Nome de Usuário")]
        [Required(ErrorMessage ="Por favor, informe seu email ou o nome de usuário")]
        public string Email { get; set; }

        [Display(Name ="Senha de acesso", Prompt ="********")]
        [Required(ErrorMessage ="Por favor, infomre sua senha")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Display(Name ="Manter Conectado?")]
        public bool Lembrar { get; set; }
        public string UrlRetorno { get; set; }
    }
}