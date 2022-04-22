﻿namespace Enterspeed.Plugins.UmbracoCms.V9.SsgDeploy.Models
{
    public class ApiResponse<T>
    {
        public bool IsSuccess { get; set; }
        public string ErrorCode { get; set; }
        public T Data { get; set; }
    }
}