﻿using WebApplication1.Shared;

namespace WebApplication1.Domain.Instituicao;

public class EmailInstituicao : IValueObject
{

    public string Email { get; set; }

    public EmailInstituicao()
    {
        
    }

    public EmailInstituicao(string email)
    {
        Email = email;
    }
}




