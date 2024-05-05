# UnitySnakeGame

## Descrição
Projeto desenvolvido em Unity para ajudar iniciantes a se familiarizarem com o ambiente de desenvolvimento da Unity enquanto criam uma versão do clássico jogo da cobrinha.

## Funcionalidades
Controles simples de teclado para mover a cobra.
Crescimento da cobra ao comer maçãs.
Detecção de colisão com paredes e com o próprio corpo da cobra.
Interface gráfica básica com uma tela de game over e pontuação.

## Requisitos
Unity 20XX.XX ou superior.

## Como Usar
Clone ou faça o download do repositório.  
Abra o projeto na Unity.  
Navegue até a cena principal (MainScene) localizada em Assets/Scenes.  
Pressione Play para iniciar o jogo.  
Use as teclas de seta para controlar a direção da cobra.  
Coma maçãs para crescer a cobra e aumentar sua pontuação.  

## Estrutura dos Scripts
**GameOver.cs:** Controla o estado de game over e exibe a tela correspondente quando a cobra atinge o limite.  
**GrowSnake.cs:** Gerencia o crescimento da cobra ao comer maçãs e movimenta as partes adicionais do corpo.  
**Pontuacao.cs:** Atualiza a pontuação exibida na interface gráfica com base no tamanho da cobra.  
**SnakeMove.cs:** Controla o movimento da cobra e detecta colisões com as paredes e o próprio corpo.  
**SpawnApple.cs:** Gera maçãs aleatoriamente no cenário e verifica se a cobra comeu uma maçã.  

## Contribuindo
Contribuições são bem-vindas! Sinta-se à vontade para abrir um pull request com melhorias, correções de bugs ou novas funcionalidades.

##

Sinta-se à vontade para adicionar ou modificar informações conforme necessário!
