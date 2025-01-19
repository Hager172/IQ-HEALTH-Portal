using ACMS_ONLINE_APPLICATION.ApprovalService.Commands.Approval;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMS_ONLINE_APPLICATION.ApprovalService.Commands.CreateApproval
{
    public class CreateApprovalCommandValidator : AbstractValidator<createApprovalCommand>
    {
        public CreateApprovalCommandValidator()
        {
            //RuleFor(p => p.InsuredID)
            //    .NotEmpty()
            //    .NotNull()
            //    .MaximumLength(100);

            //RuleFor(p => p.ClaimDate)
            //    .NotEmpty()
            //    .NotNull();
        }
    }
}
