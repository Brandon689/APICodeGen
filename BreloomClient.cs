using WooCommerceAPI.Models.Clients.Breloom.Exceptions;
using WooCommerceAPI.Models.Services.Foundations.Breloom;
using WooCommerceAPI.Models.Services.Foundations.Breloom.Exceptions;
using WooCommerceAPI.Models.Services.Foundations.BreloomVariations;
using WooCommerceAPI.Services.Foundations.Breloom;
using Xeptions;

namespace WooCommerceAPI.Clients.Breloom
{
    internal partial class BreloomClient : IBreloomClient
    {
        private readonly IBreloomService BreloomService;

        public BreloomClient(IBreloomService BreloomService) =>
            this.BreloomService = BreloomService;

        public async ValueTask<Breloom> SendBreloomAsync(Breloom Breloom)
        {
            try
            {
                return await BreloomService.SendBreloomAsync(Breloom);
            }
            catch (BreloomValidationException completionValidationException)
            {
                throw new BreloomClientValidationException(
                    completionValidationException.InnerException as Xeption);
            }
            catch (BreloomDependencyValidationException completionDependencyValidationException)
            {
                throw new BreloomClientValidationException(
                    completionDependencyValidationException.InnerException as Xeption);
            }
            catch (BreloomDependencyException completionDependencyException)
            {
                throw new BreloomClientDependencyException(
                    completionDependencyException.InnerException as Xeption);
            }
            catch (BreloomServiceException completionServiceException)
            {
                throw new BreloomClientServiceException(
                    completionServiceException.InnerException as Xeption);
            }
        }

        public async ValueTask<BreloomVariations> SendBreloomVariationsAsync(BreloomVariations Breloom)
        {
            try
            {
                return await BreloomService.SendBreloomVariationsAsync(Breloom);
            }
            catch (BreloomValidationException completionValidationException)
            {
                throw new BreloomClientValidationException(
                    completionValidationException.InnerException as Xeption);
            }
            catch (BreloomDependencyValidationException completionDependencyValidationException)
            {
                throw new BreloomClientValidationException(
                    completionDependencyValidationException.InnerException as Xeption);
            }
            catch (BreloomDependencyException completionDependencyException)
            {
                throw new BreloomClientDependencyException(
                    completionDependencyException.InnerException as Xeption);
            }
            catch (BreloomServiceException completionServiceException)
            {
                throw new BreloomClientServiceException(
                    completionServiceException.InnerException as Xeption);
            }
        }
    }
}
