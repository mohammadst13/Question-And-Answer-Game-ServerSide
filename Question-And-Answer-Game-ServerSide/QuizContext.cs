﻿using Microsoft.EntityFrameworkCore;
using Question_And_Answer_Game_ServerSide.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question_And_Answer_Game_ServerSide
{
    public class QuizContext:DbContext
    {
        public QuizContext(DbContextOptions<QuizContext> options) : base(options) 
        { }

        public DbSet<Question> Questions { get; set; }
    }
}
