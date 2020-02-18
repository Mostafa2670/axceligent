
    class Humanoid
    {
        Skill skill;
        public Humanoid()
        {
            this.skill = null;
        }
        public Humanoid (Skill skill)
        {
            this.skill = skill;
        }
        public string ShowSkill()
        {
            if (skill == null)
                return "no skill is defined";
            return skill.ShowSkill();
        }
    }
    class Skill
    {
        protected string skill;
        public Skill()
        {
            skill = "no skill is defined";
        }
        public string ShowSkill()
        {
            return skill;
        }
    }
    class Dancing : Skill
    {
        public Dancing()
        {
            skill = "dancing";
        }
    }
    class Cooking : Skill
    {
        public Cooking()
        {
            skill = "cooking";
        }
    }
}
