﻿using Abstractions.Queries;

using HomeConfect.Domain;
using HomeConfect.Domain.Criterion;

using System.Collections.Generic;
using System.Linq;

namespace HomeConfect.Storage.Queries
{
    public class GetAllRecipesQuery : AbstractQuery, IQuery<GetAllRecipes, List<Recipe>>
    {
        public GetAllRecipesQuery(Context context) : base(context)
        { }

        public List<Recipe> Ask(GetAllRecipes criterion)
        {
            return Context.Recipes.ToList();
        }
    }
}