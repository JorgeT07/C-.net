using System;

namespace C_.net
{
    class Program
    {
        public static String MaxOccur(String word){
            int [] count = new int[512];
            int max = 0; 
            String result = ""; 

            Console.WriteLine("before first for");
            for(int i =0; i<word.Length; i++){
                count[word[i]]++;
            }
            Console.WriteLine("after first for");
            for(int i =0; i<word.Length; i++){
                // Console.WriteLine(word[i]);
                if(max < count[word[i]] && count[word[i]] >1){
                    max = count[word[i]];
                    result = word[i].ToString();
                    // Console.WriteLine("inside if" + word[i]);
                }
                if(max == count[word[i]] && count[word[i]] > 1){
                    result += word[i].ToString();
                    // Console.WriteLine(word[i]);
                }
            }
            if(max == 0){
                result = "No Repetition";
            }
            Console.WriteLine("before sending result");
            return result;
        }
        static void Main(string[] args)
        {

            String word;
            Boolean running = true;
            String returned = "";
            while(running){
                Console.WriteLine("Please type a word:");
                word = Console.ReadLine();
                // word = word.Replace(" ", "");
                returned = MaxOccur(word);
                if(!returned.Equals("No Repetition")){
                    char [] forWord = new char [1024];

                    for(int i =0; i<word.Length; i++){
                        if(returned[i] != forWord[i]){
                            forWord[i] = returned[i];
                        }
                    }

                    for(int i =0; i < forWord.Length; i++){
                        Boolean isDuplicate = false;
                        for(int j = 0; j<i; j++){
                            if(forWord[i] == forWord[j]){
                                isDuplicate = true;
                                break;
                            }
                        }
                        if(!isDuplicate){  
                            Console.Write(forWord[i] + " ,");    
                        }  
                    }
                }
                else{
                    Console.Write(returned);
                }
            
                Console.WriteLine("\nWould you like to exit? Press x");
                String resp = Console.ReadLine();
                
                if(resp == "x" || resp=="X"){
                    running = false;
                }

            }

        }
    }
}
