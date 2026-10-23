using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LocationVoitures.Web.Models
{
    public class Voiture
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "La marque est obligatoire.")]
        [StringLength(50, ErrorMessage = "La marque ne peut pas dépasser 50 caractères.")]
        [Display(Name = "Marque")]
        public string Marque { get; set; } = string.Empty;

        [Required(ErrorMessage = "Le modèle est obligatoire.")]
        [StringLength(50, ErrorMessage = "Le modèle ne peut pas dépasser 50 caractères.")]
        [Display(Name = "Modèle")]
        public string Modele { get; set; } = string.Empty;

        [Required(ErrorMessage = "L'immatriculation (matricule) est obligatoire.")]
        [StringLength(30, ErrorMessage = "Le matricule ne peut pas dépasser 30 caractères.")]
        [Display(Name = "Immatriculation")]
        public string Matricule { get; set; } = string.Empty;

        [Required(ErrorMessage = "L'année est obligatoire.")]
        [Range(2000, 2030, ErrorMessage = "L'année doit être comprise entre 2000 et 2030.")]
        [Display(Name = "Année de fabrication")]
        public int Annee { get; set; } = DateTime.Now.Year;

        [Required(ErrorMessage = "Le tarif par jour est obligatoire.")]
        [Range(10.0, 10000.0, ErrorMessage = "Le tarif journalier doit être supérieur à 10.")]
        [Column(TypeName = "decimal(18,2)")]
        [Display(Name = "Tarif / Jour (TND)")]
        public decimal PrixJour { get; set; }

        [Display(Name = "Disponible immédiatement")]
        public bool EstDisponible { get; set; } = true;

        // =========================================================================
        // RELATION 1-N AVEC CATEGORYVOITURE (Clé étrangère et propriété de navigation)
        // =========================================================================

        /// <summary>
        /// Clé étrangère pointant vers la table CategoriesVoitures
        /// </summary>
        [Required(ErrorMessage = "La catégorie est obligatoire.")]
        [Display(Name = "Catégorie")]
        public int CategoryVoitureId { get; set; }

        /// <summary>
        /// Propriété de navigation : permet d'accéder directement à l'objet CategoryVoiture lié
        /// </summary>
        [ForeignKey(nameof(CategoryVoitureId))]
        [Display(Name = "Catégorie")]
        public CategoryVoiture? CategoryVoiture { get; set; }
    }
}
