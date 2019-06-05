<Grid>
        <StackLayout Padding="10">
            <Button
                Text="Show PopUp"
                TextColor="White"
                BackgroundColor="Black"
                CornerRadius="10"
                Command="{Binding ExibirPopUpCommand}" />
        </StackLayout>

        <ContentView
            BackgroundColor="#C0808080"
            IsVisible="{Binding ExibirPopUp}"
            HorizontalOptions="FillAndExpand"
            VerticalOptions="FillAndExpand">
            <StackLayout
                Margin="10,10"
                HorizontalOptions="FillAndExpand"
                VerticalOptions="FillAndExpand">
                <Frame
                    Padding="0"
                    HasShadow="False"
                    CornerRadius="10"
                    HeightRequest="300">
                    <StackLayout Padding="10">
                        <Label
                            Text="Xamarin Forms"
                            HorizontalTextAlignment="Center"
                            FontSize="Medium" />
                        <Button
                            Text="Fechar PopUp"
                            BackgroundColor="White"
                            BorderColor="Black"
                            BorderWidth="1"
                            HeightRequest="40"
                            CornerRadius="20"
                            VerticalOptions="EndAndExpand"
                            Command="{Binding FecharPopUpCommand}" />
                    </StackLayout>
                </Frame>
            </StackLayout>
        </ContentView>
    </Grid>
