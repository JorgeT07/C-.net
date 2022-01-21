using System;

namespace C_.net
{
    class Program
    {
        public static String MaxOccur(String word){
            int [] count = new int[256];
            int max = 0; 
            String result = ""; 

            for(int i =0; i<word.Length; i++){
                count[word[i]]++;
            }

            for(int i =0; i<word.Length; i++){
                // Console.WriteLine(word[i]);
                if(max < count[word[i]] ){
                    max = count[word[i]];
                    result = word[i].ToString();
                    // Console.WriteLine("inside if" + word[i]);
                }
                if(max == count[word[i]]){
                    result += word[i].ToString();
                    // Console.WriteLine(word[i]);
                }

            }
            return result;
        }
        static void Main(string[] args)
        {

            String word;
            Boolean running = true;
            String returned = "";
            while(running){
                Console.WriteLine("Please type a word");
                word = Console.ReadLine();
                returned = MaxOccur(word);
                char [] forWord = new char [returned.Length];
                
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
                        Console.Write(forWord[i]);    
                    }  
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
