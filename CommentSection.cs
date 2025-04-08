using System;
using System.Collections.Generic;

public class CommentSection
{
    class Comment{
        public int id;
        public string text;
        public List<Comment> responses;
        
        public Comment(int id, string text){
            if((text != null) && (id != null)){
                this.id = id;
                this.text = text;
                responses = new List<Comment>();
            }
        }
        
        public void addComment(string text){
            responses.Add(new Comment(0, text)); //id 0 to fix later
        }
        public void printComments(){
            recursivePrintComments(0);
        }
        
        private void recursivePrintComments(int level){
            string ident = new String(' ', (level * 2));
            Console.WriteLine(ident + '-' + this.text);
            foreach(var comment in this.responses){
                comment.recursivePrintComments(level + 1);
            }
            return;
        }
    }
    
    public static void Main(string[] args)
    {
        //Testing the structure
        Comment comentario = new Comment(0, "First comment");
        
        string texto;
        for( int i = 0; i < 2; i++){
            Console.WriteLine("Digit something for the comment: ");
            texto = Console.ReadLine();
            comentario.addComment(texto);
        }
        foreach (var comment in comentario.responses){
            for( int i = 0; i < 2; i++){
                Console.WriteLine("Digit the response for the comments you commented");
                texto = Console.ReadLine();
                comment.addComment(texto);
            }
        }
        comentario.printComments();
        
    }
}