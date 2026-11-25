using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using EManzanilla.BE;

namespace EManzanilla.Val
{
    public class ValidarEmpleado : AbstractValidator<Empleado>
    {
        public ValidarEmpleado()
        {
            // 🔹 Validar nombre y apellido
            RuleFor(e => e.Nombre)
                .NotEmpty().WithMessage("El nombre y apellido no pueden estar vacíos.")
                .Matches(@"^[A-Za-zÁÉÍÓÚáéíóúÑñ]+ [A-Za-zÁÉÍÓÚáéíóúÑñ]+$")
                .WithMessage("Debe ingresar nombre y apellido separados por un espacio, sin números ni caracteres especiales.")
                .MaximumLength(60).WithMessage("El nombre y apellido no pueden superar los 60 caracteres.");

            // 🔹 Validar DNI
            RuleFor(e => e.Dni)
                .NotEmpty().WithMessage("El DNI no puede estar vacío.")
                .Matches(@"^\d+$").WithMessage("El DNI solo puede contener números.")
                .Length(7, 8).WithMessage("El DNI debe tener entre 7 y 8 dígitos.");

            // 🔹 Validar Teléfono
            RuleFor(e => e.Telefono)
                .NotEmpty().WithMessage("El teléfono no puede estar vacío.")
                .Matches(@"^\d+$").WithMessage("El teléfono solo puede contener números.")
                .Length(6, 15).WithMessage("El teléfono debe tener entre 6 y 15 números.");

            // 🔹 Validar Precio por Hora
            RuleFor(e => e.PHora)
                .GreaterThan(0).WithMessage("El precio por hora debe ser mayor a 0.")
                .LessThanOrEqualTo(999999999).WithMessage("El precio por hora no puede superar 999.999.999.");

            // 🔹 Validar que Activo tenga valor
            RuleFor(e => e.Activo)
                .NotNull().WithMessage("Debe especificar si el empleado está activo o no.");
        }
    }
}

    

