using System.Collections.Generic;
using VideoRentalService.Models;

namespace VideoRentalService.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}