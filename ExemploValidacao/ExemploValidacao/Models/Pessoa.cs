using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExemploValidacao.Models
{
    public class Pessoa
    {
        //o System.ComponentModel.DataAnnotations faz a validacao no lado do cliente como no lado do servidor:
        [Required(ErrorMessage = "O campo deve ser preenchido")]
        public string Nome { get; set; }
        [StringLength(50,MinimumLength =5,ErrorMessage ="A observacao deve ter entre 5 e 50 caracteres")]
        [Required(ErrorMessage ="Preencha a observacao")]
        public string Observacao { get; set; }
        [Range(18,50,ErrorMessage ="A idade deve da pessoa deve ser entre 18 e 50 anos")]
        [Required(ErrorMessage ="Informe a idade")]
        public int Idade { get; set; }
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage ="O email informado nao e valido")]
        public string Email { get; set; }
        [RegularExpression(@"[a-zA-Z]{5,15}", ErrorMessage ="O login deve possuir somente letras e deve ter de 5 a 15 caracteres")]
        [Required(ErrorMessage ="O login deve ser preenchido")]
        [Remote("LoginUnico","Pessoa",ErrorMessage ="Este nome de login ja existe")]
        public string Login { get; set; }
        [Required(ErrorMessage ="A senha deve ser informada")]
        public string Senha { get; set; }
        [System.ComponentModel.DataAnnotations.Compare("Senha", ErrorMessage ="As senhas nao conferem")]
        public string ConfirmarSenha { get; set; }

    }
}