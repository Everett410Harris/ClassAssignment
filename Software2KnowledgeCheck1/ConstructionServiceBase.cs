namespace Software2KnowledgeCheck1
{
    internal class ConstructionServiceBase : MaterialsRepo
    {
        private readonly MaterialsRepo materialRepo = new MaterialsRepo();
        private readonly ZoningAndPermitRepo permitRepo = new ZoningAndPermitRepo();



        public bool ConstructBuilding<T>(T Building) where T : Building
        {
            var materialsNeeded = materialRepo.GetMaterials();

            if (permitRepo.GetPermit() && permitRepo.ZoningApproves())
            {
                foreach (var material in materialsNeeded)
                {
                    if (material == "concrete")
                    {
                        // start laying foundation
                    }
                    else if (material == "steel")
                    {
                        // start building structure
                    }
                    // etc etc...
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    
    
}