using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MSdocsMVC.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }


        //Utilizando DataAnnotations para setar a forma como o atributo será exibido na view.
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        //Aqui por exemplo podemos definir como o atributo será renderizado pela view
        // E podemos também especificar o tipo de data que precisamos,
        // Quando definimos nosso DataType.Date estamos tirando o tempo da notação de data.
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

    }
}
