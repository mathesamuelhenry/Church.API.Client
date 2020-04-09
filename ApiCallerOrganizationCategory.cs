using Church.API.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Church.API.Client
{
    public class ApiCallerOrganizationCategory : ApiCallerBase
    {
        public ApiCallerOrganizationCategory(string uri) :
            base(uri)
        {

        }

        public List<OrganizationCategory> GetOrganizationCategoryList()
        {
            string url = $"api/OrganizationCategories";

            var organizationCategoryList = ApiHelper.CallGetWebApi<List<OrganizationCategory>>(url);

            return organizationCategoryList;
        }

        public List<OrganizationCategory> GetCategoryListByOrganizationId(int orgId)
        {
            string url = $"api/OrganizationCategories/GetCategoryListByOrganizationId/{orgId}";

            var organizationCategoryList = ApiHelper.CallGetWebApi<List<OrganizationCategory>>(url);

            return organizationCategoryList;
        }

        public OrganizationCategory GetOrganizationCategoryById(int id)
        {
            string url = $"api/OrganizationCategories/{id}";

            var organizationCategory = ApiHelper.CallGetWebApi<OrganizationCategory>(url);

            return organizationCategory;
        }

        public OrganizationCategory PostAddOrganizationCategory(OrganizationCategory orgCatRequest)
        {
            string url = $"api/OrganizationCategories";

            var organizationCategory = ApiHelper.CallPostWebApi<OrganizationCategory, OrganizationCategory>(url, orgCatRequest);

            return organizationCategory;
        }

        public void PutUpdateOrganizationCategory(int id, OrganizationCategory orgCatRequest)
        {
            string url = $"api/OrganizationCategories/{id}";

            var organizationCategory = ApiHelper.CallPutWebApi<OrganizationCategory, OrganizationCategory>(url, orgCatRequest);
        }
    }
}
