# Clonar Apenas um Projeto no Git

Este tutorial descreve como clonar apenas uma parte específica de um repositório Git usando o recurso "sparse checkout".

## Passos

1. **Copie o URL de clone:**
   - Primeiro, copie o URL de clone.
    ~~~node
    git clone https://github.com/Geovany-Gutierrez/Estudos.Net-Maui.git
    ~~~

2. **Selecione uma pasta local:**
   - Com o URL de clone, vá para a pasta onde deseja clonar os arquivos específicos do repositório e digite os seguintes comandos:

   ~~~node
   git clone --no-checkout --filter=blob:none https://github.com/Geovany-Gutierrez/Estudos.Net-Maui.git <NOME_DA_PASTA>
   ~~~

3. **Navegue até o repositório clonado vazio:**
   - Clone o repositório, mas sem nenhum conteúdo, e entre no diretório clonado.
   ~~~node
   cd <NOME_DA_PASTA>
   ~~~

4. **Configure o sparse checkout:**
   - Dentro do repositório, execute um comando para habilitar o sparse checkout.

   ~~~node
   git sparse-checkout set --cone
   ~~~

5. **Selecione um branch:**
   - Vá para o branch do repositório que você deseja clonar a pasta.
   ~~~node
   git checkout main
   ~~~

6. **Clone a pasta específica:**
   - Finalmente, clone a pasta específica que você deseja baixar.

   ~~~node
   git sparse-checkout set src/nome_da_pasta
   ~~~

Este método permite que você clone apenas uma parte específica do repositório. 
~~~javascript
Certifique-se de ter uma versão do Git igual ou superior a 2.25.0 para utilizar o comando `sparse-checkout`.
~~~
