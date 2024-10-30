using System.Threading.Tasks;
using Grpc.Core;
using GrpcMultiplyService.Services;

namespace GrpcMultiplyService.Services
{
    public class CalculatorServiceImpl: GrpcMultiplyService.Services.CalculatorService.CalculatorServiceBase
    {
        public override Task<CalculationResult> Multiply(TwoNumbers request, ServerCallContext context)
        {
            int result = request.Num1 * request.Num2;

            return Task.FromResult(new CalculationResult { Result = result });
        }
    }
}
