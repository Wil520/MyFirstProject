using System;
using System.Collections.Generic;

namespace MyFirstProject
{
    /*
  Challenge:
  - 1. Add a data member for a unique Id to the Movie class
  - 2. Add a data member for a collection of numerical ratings
  - 3. Add a constructor that initializes all the data members of a movie
  - 4. Add a method that allows you to add a rating between 1 and 5 (inclusive) to the movie
  - 5. Add a mechanism that allows you to get the average rating of a movie
  */
    public class Movie
    {


        public int MovieId { get; } // Read-only property
        public string Title { get; set; }
        public string Director { get; set; }
        public int Year { get; set; }

        private List<double> ratings = new List<double>();


        public Movie(int movieId, string title, string director, int year)
        {
            MovieId = movieId;
            Title = title;
            Director = director;
            Year = year;
        }

        public void rate(double rating)
        {
            if (rating < 1.0 || rating > 5.0)
            {
                throw new Exception("Only 1-5 is allowed");
            }
            ratings.Add(rating);
        }

        public double GetAverageRating()
        {
            double averageRating = 0;
            if (ratings.Count > 0)
            {
                double sum = 0;
                for (int i = 0; i < ratings.Count; i++)
                {
                    sum += ratings[i];
                }
                averageRating = sum / ratings.Count;
            }

            return averageRating;
        }
        
        public void PrintDetails()
        {
            Console.WriteLine($"Movie Title: {Title}");
            Console.WriteLine($"Director: {Director}");
            Console.WriteLine($"Year: {Year}\n");
        }
    }
}