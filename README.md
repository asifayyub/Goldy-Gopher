# Goldy Gopher
 I have used MVC Core. Please clone this repo and click on MVC_Application.sln. it will load the project in visual Studio. 
# i realise the better way to  making form with the helper tag
<form method="post" asp-controller="Home" asp-action="Index">
                
                    <header class ="head" >ENTER THE NUMBER</header>
                    <div>
                    <label asp-for="LowerBound" class="lower">Lower Bound</label>
                    <input asp-for="LowerBound" class="tableInputClass" />
                </div>
                <div>
                    <label asp-for="UpperBound" class="upper">Upper Bound</label>
                    <input asp-for="UpperBound" class="tableInputClass" />
                </div>
                <div>
                    <input type="submit" value="submit" class="buttonClass" >
                 </div>
            </form>
            
            
