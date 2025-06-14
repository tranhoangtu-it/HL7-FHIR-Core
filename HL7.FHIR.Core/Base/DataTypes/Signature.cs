using System;
using System.Collections.Generic;

namespace HL7.FHIR.Core.Base.DataTypes;

public class Signature
{
    /// <summary>Hệ thống chữ ký: XMLDSig | JWT | ...</summary>
    public string? TypeSystem { get; set; } = "urn:iso-astm:E1762-95:2013";

    /// <summary>Kiểu chữ ký: author, verifier, ...</summary>
    public List<Coding>? Type { get; set; }

    /// <summary>Thời gian chữ ký được tạo</summary>
    public DateTime? When { get; set; }

    /// <summary>Ai là người ký</summary>
    public Reference? Who { get; set; }

    /// <summary>Đại diện cho ai</summary>
    public Reference? OnBehalfOf { get; set; }

    /// <summary>Định dạng MIME (application/signature+xml)</summary>
    public string? TargetFormat { get; set; }

    /// <summary>Định dạng MIME của chữ ký (application/pkcs7-mime)</summary>
    public string? SigFormat { get; set; }

    /// <summary>Dữ liệu nhị phân base64</summary>
    public string? Data { get; set; }
}