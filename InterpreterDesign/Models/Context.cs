class Context
{
    private string ac_model = "";
    private bool isAircraft = false;

    public Context(string _ac_model)
    {
        this.ac_model = _ac_model;
    }

    public string getModel()
    {
        return this.ac_model;
    }

    public int getLenght()
    {
        return this.ac_model.Length;
    }

    public string getLastChar()
    {
        return this.ac_model[this.ac_model.Length - 1].ToString();
    }

    public string getFirstChar()
    {
        return this.ac_model[0].ToString();
    }

    public void setIsAircraft(bool _isAircraft)
    {
        this.isAircraft = _isAircraft;
    }

    public bool getIsAircraft()
    {
        return this.isAircraft;
    }
}
