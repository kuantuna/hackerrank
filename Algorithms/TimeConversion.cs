static string timeConversion(string s) {
    string str = "";
    if(s.Substring(8)=="AM"){
        if(s.Substring(0,2)=="12"){
            str += "00";
            str += s.Substring(2,6);
        }
        else{
            str += s.Substring(0,8);
        }
    }
    else{
        if(s.Substring(0,2)=="12"){
            str += s.Substring(0,8);
        }
        else{
            int cl = Convert.ToInt32(s.Substring(0,2));
            cl += 12;
            str += String.Concat(Convert.ToString(cl), s.Substring(2,6));
        }
    }
    return str;
}
