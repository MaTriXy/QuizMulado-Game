## QuizMulado (Versão Alpha)

<p align="center">

<img src="https://github.com/DoisLucas/QuizMulado-Unity-CSharp/blob/master/Imagens/tecnologia.png" width="50%" height="50%"/>

</p>


  **QuizMulado** é um aplicação mobile desenvolvida na Unity Engine utilizando **C#** como linguagem base, o objetivo do game consiste em responder perguntas no estilo *"Who Wants to Be a Millionaire"* de forma divertida e educativa.
> **Notice**: Project files updated for Unity 6000.1.6f1 with the latest package versions.
  
  
### Funcionamento:
  
Para cada acerto o jogador recebe uma quantia em moeda, e uma proxima pergunta é mostrada, a recompensa em moeda varia de acordo com o nivel de dificuldade da pergunta, para cada erro o jogador perde uma vida de um total inicial de cinco, acabando as vidas a partida se encerra, mostrando em seguida a pontuação obtida na partida. As pontuações são salvas no perfil do jogador fazendo com que cada vez mais o jogador se esforçe para quebrar seu record pessoal.

Com as moedas é possivel adquirir poderes na loja do game, dentre eles estão:

***PULO:*** Com o poder do pulo é possivel pular a pergunta atual.

***50/50:*** Duas alternativas erradas das 4 (totais) são descartadas.

***VIDA:*** O poder da vida adiciona mais uma vida permanentemente ao jogo.

***ESTATÍSTICA:*** Com o poder da estatÍstica é possivel resetar as estatisticas do jogador deixando suas moedas e poderes.

A partida começa com uma lista de perguntas, e ao errar, a pergunta entra no final da lista para ser respondida posteriormente, e as perguntas que são puladas com o poder, irão pra uma nova lista onda utiliza o mesmo mecanismo de erro, a nova lista será chamada logo após a primeira lista não ter nenhuma pergunta (certa ou errada) para ser respondida, lembrando que não existe a possibilidade de pular uma mesma pergunta duas vezes na mesma partida.

### Desenvolvimento:

Foi utilizado o padrão de projeto **Singleton** no qual garante a existência de apenas uma instância de uma classe, mantendo um ponto global de acesso ao seu objeto, onde é centralizado todas as informaçoes essenciais que será utilizada nas demais classes, como por exemplo todo o controle de audio da aplicação. O projeto atualmente possui 8 Scenes e 19 Script.

<p align="center">

<img src="https://github.com/DoisLucas/QuizMulado-Unity-CSharp/blob/master/Imagens/Navegação.png" width="80%" height="80%"/>

</p>

### Capturas de Tela:

<p align="center">

<img src="https://github.com/DoisLucas/QuizMulado-Unity-CSharp/blob/master/Imagens/gif3.gif" width="30%" height="30%"/>
<img src="https://github.com/DoisLucas/QuizMulado-Unity-CSharp/blob/master/Imagens/gif2.gif" width="30%" height="30%"/>
</p>



