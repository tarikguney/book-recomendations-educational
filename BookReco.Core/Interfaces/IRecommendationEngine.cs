using BookReco.Core.Models;

namespace BookReco.Core.Interfaces;

public interface IRecommendationEngine
{
    Book GetRecommendedBook();
} 