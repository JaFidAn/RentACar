﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CoreCrossCuttingConcers.Exceptions;

public class AuthorizationProblemDetails : ProblemDetails
{
    public override string ToString() => JsonConvert.SerializeObject(this);
}