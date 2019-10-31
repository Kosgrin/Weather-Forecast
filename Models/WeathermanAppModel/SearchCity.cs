using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Weatherman.Models.WeathermanAppModel
{
	public class SearchCity
	{
		[Required(ErrorMessage = "Введите пожалуйста название города")]
		[RegularExpression("^[A-Za-z ]+$", ErrorMessage = "Допускаються только буквы")]
		[StringLength(20, MinimumLength = 2, ErrorMessage = "Название города должно быть минимум от 2-х символов")]
		[Display(Name = "Город")]
		public string CityName { get; set; } 
	}
}
